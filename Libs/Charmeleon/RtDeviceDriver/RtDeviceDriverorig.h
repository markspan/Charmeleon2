// RtDeviceDriver.h

#pragma once

#include <Windows.h>

#include <stdio.h>
#include <wchar.h>
#include <conio.h>
#include <tchar.h> 

#include "RtDevice.h"
#include "Feature.h" 

using namespace System;

namespace RtDeviceDriver {

#define __load_dll_func__(var, type, name) \
	var = (type)::GetProcAddress(m_oLibHandle, name); \
	isValid = true; \
	if(!var) \
		{ \
		throw gcnew System::IO::FileNotFoundException("Load method error", e); \
		isValid=false; \
		return; \
		}

#define MEASURE_MODE_NORMAL			((ULONG)0x0)
#define MEASURE_MODE_IMPEDANCE		((ULONG)0x1)
#define MEASURE_MODE_CALIBRATION	((ULONG)0x2)
#define MEASURE_MODE_IMPEDANCE_EX	((ULONG)0x3)
#define MEASURE_MODE_CALIBRATION_EX	((ULONG)0x4)

#define IC_OHM_002                  ((ULONG)0x0)
#define IC_OHM_005                  ((ULONG)0x1)
#define IC_OHM_010                  ((ULONG)0x2)
#define IC_OHM_020                  ((ULONG)0x3)
#define IC_OHM_050                  ((ULONG)0x4)
#define IC_OHM_100                  ((ULONG)0x5)


#define MAX_DEVICE			1	//Max number of devices supported by this demo
#define USE_MASTER_SLAVE	FALSE
	//#define CHANNELS 20

	int CHANNELS = 0;
	bool isValid = false;
	public ref class RefaDriver
	{
		static ULONG Index;
		static ULONG SampleRate;
		static ULONG BufferSize;

		static ULONG NrOfSamples = 0, Total = 0;
		static ULONG PercentFull, Overflow;
		static ULONG BytesPerSample;
		static ULONG BytesReturned;


		// Get handle to my device
		static signed int *SignalBuffer;

		static RTDeviceEx *Master;

	public: void Initialize()
	{
		try {
			RTDeviceEx *Device[MAX_DEVICE];

			for (Index = 0; Index < MAX_DEVICE; Index++)
				Device[Index] = NULL;

			if (USE_MASTER_SLAVE)
				UseMasterSlave(Device, MAX_DEVICE);
			else
				Device[0] = SelectDevice(TRUE);

			Master = Device[0];

			if (Master == NULL)
			{
			}

			Master->Reset();

			// Get the size of each sample 
			BytesPerSample = SignalInfo(Master);

			if (BytesPerSample == 0)
			{
				printf("\nDevice returns no samples");
			}

			//Initialize signal buffer		
			//If the supplied parameters can not be matched by the device
			//this function will return the clossed math

			SampleRate = MAX_SAMPLE_RATE;
			BufferSize = MAX_BUFFER_SIZE;
			ULONG sr = SampleRate;
			ULONG bs = BufferSize;
			Master->SetSignalBuffer(&sr, &bs);

			wprintf(L"\nMaximum sample rate = %d Hz", SampleRate / 1000);
			wprintf(L"\nMaximum Buffer size = %d Samples", BufferSize);

			//Set sample rate 
			SampleRate = 250000;
			//Set buffer size;
			BufferSize = 1000;

			sr = SampleRate;
			bs = BufferSize;
			Master->SetSignalBuffer(&sr, &bs);

			wprintf(L"\nSelected sample rate = %d Hz", SampleRate / 1000);
			wprintf(L"\nSelected Buffer size = %d Samples", BufferSize);

			// Some example routines for testing device features 

			/********** MEASURING MODE ****************/

			// Measuring mode can switch the device to 
			// Calbartion mode 
			// Impedance mode
			// and back to normal measurment 

			// flash on the amplifier only!
			if (!Master->MeasuringMode(MEASURE_MODE_IMPEDANCE, IC_OHM_100))
			{
				wprintf(L"\nCalibration indication not supported by this device\n");
			}

			if (!Master->MeasuringMode(MEASURE_MODE_IMPEDANCE_EX, IC_OHM_100))
			{
				wprintf(L"\nCalibration and Impedance measurement not supported by this device\n");
			}

			Master->Start();
		}
		catch (Exception^ e)
		{
			throw gcnew System::IO::FileNotFoundException("No REFA connected (is it on?)", e);
		}
	}

	ULONG SignalInfo(RTDevice *Device)
	{
		BOOLEAN Allocate = TRUE;
		ULONG BytesPerSample = 0;
		ULONG i, NumberOfChannels = 0;

		PSIGNAL_FORMAT psf;
		if (Allocate)
		{
			SIGNAL_FORMAT sf;
			memset(&sf, 0, sizeof(SIGNAL_FORMAT));
			sf.Elements = 1;
			sf.Size = sizeof(SIGNAL_FORMAT);
			if (Device->GetSignalFormat(&sf) != NULL)
			{
				ULONG TotalSize = sf.Size * sf.Elements;
				psf = (SIGNAL_FORMAT *)LocalAlloc(LMEM_FIXED | LMEM_ZEROINIT, TotalSize);
				if (psf == NULL) return 0;
				psf[0].Size = sf.Size;
				psf[0].Elements = sf.Elements;
				Device->GetSignalFormat(psf);
			}
		}
		else
			psf = Device->GetSignalFormat(NULL);

		if (psf != NULL)
		{
			UINT Size = LocalSize(psf);
			if (Size < sizeof(SIGNAL_FORMAT) * psf->Elements)
					return 0;

			NumberOfChannels = psf->Elements;
			CHANNELS = NumberOfChannels;
			wprintf(L"\n");
			for (i = 0; i < NumberOfChannels; i++)
			{
				BytesPerSample += psf[i].Bytes;
				wprintf(L"\nChannel %3d: %s on device %s:%d", i + 1, psf[i].Name, psf[i].PortName, psf[i].SerialNumber);
			}
				//Remove the data from memory
			if (Allocate)
				LocalFree(psf);
			else Device->Free(psf);
				wprintf(L"\n");
		}

		return BytesPerSample;
	}

	ULONG UseMasterSlave(RTDeviceEx **Devices, ULONG Max)
	{
		ULONG NrOfDevices;
		ULONG x;

		for (x = 0; x < Max; x++)
		{
			Devices[x] = new RTDeviceEx(x);
			if (Devices[x] == NULL) break;
			if (!Devices[x]->InitOk)
			{
				delete Devices[x];
				Devices[x] = NULL;
				break;
			}
		}

		NrOfDevices = x;

		for (x = 0; x < NrOfDevices; x++)
		{
			TCHAR DeviceName[40] = _T("Unknown Device");
			ULONG SerialNumber = 0;
			ULONG Size;

			Size = sizeof(SerialNumber);
			RegQueryValueEx(Devices[x]->DeviceRegKey, _T("DeviceSerialNumber"), NULL, NULL, (PBYTE)&SerialNumber, &Size);

			Size = sizeof(DeviceName);
			RegQueryValueEx(Devices[x]->DeviceRegKey, _T("DeviceDescription"), NULL, NULL, (PBYTE)&DeviceName[0], &Size);

			_tprintf(_T("%d . %s %d\n"), x + 1, DeviceName, SerialNumber);

			if (x != 0)
			{
				HANDLE SlaveHandle = Devices[x]->GetSlaveHandle();
				if (SlaveHandle == 0)
					_tprintf(_T("Unable to get a handle from device %d\n"), x + 1);
				break;
				Devices[0]->AddSlave(SlaveHandle);
			}
		}
		return NrOfDevices;
	}

	RTDeviceEx *SelectDevice(IN BOOLEAN Present)
	{
		ULONG Count = 0;
		ULONG Max = 0;
		RTDeviceEx *Device;

		Device = new RTDeviceEx;

		if (Device == NULL)
			return NULL;

		if (!Device->InitOk)
		{
			delete Device;
			return NULL;
		}

		PSP_DEVICE_PATH Id;

		while (1)
		{
			TCHAR DeviceName[40] = _T("Unknown Device");
			ULONG SerialNumber = 0;
			HKEY hKey;

			Id = Device->GetInstanceId(Count++, Present, &Max);
			if (!Id) break;

			hKey = Device->OpenRegistryKey(Id);
			if (hKey != INVALID_HANDLE_VALUE)
			{
				ULONG Size;
				Size = sizeof(SerialNumber);
				RegQueryValueEx(hKey, _T("DeviceSerialNumber"), NULL, NULL, (PBYTE)&SerialNumber, &Size);
				Size = sizeof(DeviceName);
				RegQueryValueEx(hKey, _T("DeviceDescription"), NULL, NULL, (PBYTE)&DeviceName[0], &Size);
				RegCloseKey(hKey);
			}

			Device->Free(Id);
		}

		if (Max == 0)
		{
			printf("There are no device connected to the PC\n");
			return NULL;
		}

		if (Max == 1)
		{
			Id = Device->GetInstanceId(0, Present);
		}		else
		{}

		if (!Device->Open(Id))
		{
			Device->Free(Id);
			delete Device;
			return NULL;
		}

		return Device;
	}
			int getChannels()
			{
				return CHANNELS;
			}
			signed int* getImpedances()
			{
				//Get Signal buffer information
				ULONG of = Overflow;
				ULONG pf = PercentFull;
				Master->GetBufferInfo(&of, &pf);

				if (pf > 0)
				{
					// if there is data available get samples from the device
					// GetSamples returns the number of bytes written in the signal buffer
					// This will always be a multiple op BytesPerSample. 

					// Divide the result by BytesPerSamples to get the number of samples returned
					BytesReturned = Master->GetSamples((PULONG)SignalBuffer, sizeof(*SignalBuffer)*(CHANNELS + 2));
					if (BytesReturned != 0)
					{
						Total += BytesReturned;
						return SignalBuffer;
					}
				}
				return NULL;
			}
			// TODO: Add your methods for this class here.
	};
}
