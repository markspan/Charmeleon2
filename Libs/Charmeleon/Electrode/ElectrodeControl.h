#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace System::Resources;
using namespace System::IO;
using namespace Reflection;

namespace electrode {

	/// <summary>
	/// Summary for electrodeControl
	/// </summary>
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	public ref class electrodeControl : public System::Windows::Forms::UserControl
	{
	public:
		electrodeControl(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			Data = gcnew mData();
			this->ChannelValue->Visible = false;

			Map = CreateMap("Heat.map");
		}


			[Category("Info")]
			[Description("Label of the Electrode")]
			property  String^ ElectrodeLabel
			{
				String^ get(){ return Data->mElectrodeLabel; }
				void set(String^ NewLabel)
				{
					if (Data->mElectrodeLabel != NewLabel)
					{
						Data->mElectrodeLabel = NewLabel;
						this->Invalidate();
					}
				}
			};
			[Category("Info")]
			[Description("HardwareChannel Associated with the Electrode")]
			property  int HardwareChannel
			{
				int get(){ return Data->mHardwareChannel; }
				void set(int NewChannel)
				{
					if (Data->mHardwareChannel != NewChannel)
					{
						Data->mHardwareChannel = NewChannel;
					}
				}
			};


			[Category("Info")]
			[Description("Is the electrode selected in the current setup?")]
			property  bool Selected
			{
				bool get(){ return Data->mSelected; }
				void set(bool NewSelected)
				{
					if (NewSelected = true) nConnected++;
					if (NewSelected != true) nConnected--;

					Data->mSelected = NewSelected;
				}
			};

			[Category("Info")]
			[Description("Impedance Associated with the Electrode")]
			property  int Impedance
			{
				void set(int NewImpedance)
				{
					if (Data->mImpedance != NewImpedance)
					{
						Data->mImpedance = NewImpedance;
						this->Invalidate();
					}
				}
			};
			[Category("Info")]
			[Description("Number of the Electrode")]
			property  int Number
			{
				void set(int NewNumber)
				{
					Data->refNr = NewNumber;
				}
				int get()
				{
					return Data->refNr;
				}
			};
			[Category("Info")]
			[Description("What Info is shown")]
			property  int ChannelNumberShown 
			{
				void set(int ChannelNumberShown)
				{
					if (ChannelNumberShown)
					{
						this->ChannelValue->Text = Convert::ToString(this->HardwareChannel);
						this->Value->Visible = false;
						this->ChannelValue->Visible = true;
					}
					else
					{
						this->Data->mHardwareChannel = Convert::ToInt32(this->ChannelValue->Text);
						this->Value->Visible = true;
						this->ChannelValue->Visible = false;
					}
					
					this->mChannelNumberShown = ChannelNumberShown;
					this->Invalidate();
				}
			};


	public:
		array<MenuItem^>^menuItems = gcnew array<MenuItem^>(3);

		[Serializable]
		ref class mData : public System::Object
		{
		public:
			String^ mElectrodeLabel;
			int mHardwareChannel;
			int mConnector;
			int mImpedance;
			int refNr;
			bool mSelected;
			int mCurrentConnector;
		};
		
		int mChannelNumberShown = 0;

		mData^ Data;

	public:
		static int nConnected = 0;
		static array<System::Drawing::Color>^ Map;
		void SetMap(array<System::Drawing::Color>^ NewMap){
			Map = NewMap;
		};
		void SetMap(String^ NewMap){
			Map = CreateMap(NewMap);
		};
	
		int getNumberConnected()
		{
			return nConnected;
		}
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~electrodeControl()
		{
			if (components)
			{
				delete components;
			}
		}

	public: Microsoft::VisualBasic::PowerPacks::ShapeContainer^  shapeContainer1;
	protected:
	private: Microsoft::VisualBasic::PowerPacks::OvalShape^  ElectrodeShape;
	private: System::Windows::Forms::Label^  ELabel;

	private: System::Windows::Forms::Label^  Value;
	private: System::Windows::Forms::TextBox^  ChannelValue;

	private: System::ComponentModel::IContainer^  components;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->shapeContainer1 = (gcnew Microsoft::VisualBasic::PowerPacks::ShapeContainer());
			this->ElectrodeShape = (gcnew Microsoft::VisualBasic::PowerPacks::OvalShape());
			this->ELabel = (gcnew System::Windows::Forms::Label());
			this->Value = (gcnew System::Windows::Forms::Label());
			this->ChannelValue = (gcnew System::Windows::Forms::TextBox());
			this->SuspendLayout();
			// 
			// shapeContainer1
			// 
			this->shapeContainer1->Location = System::Drawing::Point(0, 0);
			this->shapeContainer1->Margin = System::Windows::Forms::Padding(0);
			this->shapeContainer1->Name = L"shapeContainer1";
			this->shapeContainer1->Shapes->AddRange(gcnew cli::array< Microsoft::VisualBasic::PowerPacks::Shape^  >(1) { this->ElectrodeShape });
			this->shapeContainer1->Size = System::Drawing::Size(37, 47);
			this->shapeContainer1->TabIndex = 0;
			this->shapeContainer1->TabStop = false;
			// 
			// ElectrodeShape
			// 
			this->ElectrodeShape->BackColor = System::Drawing::Color::LightGray;
			this->ElectrodeShape->BackStyle = Microsoft::VisualBasic::PowerPacks::BackStyle::Opaque;
			this->ElectrodeShape->Location = System::Drawing::Point(0, 0);
			this->ElectrodeShape->Name = L"ElectrodeShape";
			this->ElectrodeShape->Size = System::Drawing::Size(35, 35);
			this->ElectrodeShape->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &electrodeControl::hopclick);
			// 
			// ELabel
			// 
			this->ELabel->BackColor = System::Drawing::Color::Transparent;
			this->ELabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 7, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->ELabel->Location = System::Drawing::Point(2, 8);
			this->ELabel->Margin = System::Windows::Forms::Padding(1, 0, 1, 0);
			this->ELabel->Name = L"ELabel";
			this->ELabel->Size = System::Drawing::Size(29, 12);
			this->ELabel->TabIndex = 1;
			this->ELabel->Text = L"NA";
			this->ELabel->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			this->ELabel->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &electrodeControl::hopclick);
			// 
			// Value
			// 
			this->Value->Dock = System::Windows::Forms::DockStyle::Bottom;
			this->Value->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 6));
			this->Value->Location = System::Drawing::Point(0, 34);
			this->Value->Name = L"Value";
			this->Value->Size = System::Drawing::Size(37, 13);
			this->Value->TabIndex = 2;
			this->Value->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// ChannelValue
			// 
			this->ChannelValue->BackColor = System::Drawing::SystemColors::ButtonFace;
			this->ChannelValue->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->ChannelValue->Dock = System::Windows::Forms::DockStyle::Bottom;
			this->ChannelValue->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8));
			this->ChannelValue->Location = System::Drawing::Point(0, 21);
			this->ChannelValue->Name = L"ChannelValue";
			this->ChannelValue->Size = System::Drawing::Size(37, 13);
			this->ChannelValue->TabIndex = 2;
			this->ChannelValue->TextAlign = System::Windows::Forms::HorizontalAlignment::Center;
			// 
			// electrodeControl
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::Transparent;
			this->Controls->Add(this->ChannelValue);
			this->Controls->Add(this->Value);
			this->Controls->Add(this->ELabel);
			this->Controls->Add(this->shapeContainer1);
			this->DoubleBuffered = true;
			this->Margin = System::Windows::Forms::Padding(0);
			this->Name = L"electrodeControl";
			this->Size = System::Drawing::Size(37, 47);
			this->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &electrodeControl::RePaint);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private:
		array<System::Drawing::Color>^ CreateBlockedMap()
		{
			Map = gcnew array<System::Drawing::Color>(257);
			for (int col = 0; col < 257; col++)
			{
				Map[col] = System::Drawing::Color::AntiqueWhite;
				if (col > 1) Map[col] = System::Drawing::Color::Green;
				if (col > 4) Map[col] = System::Drawing::Color::GreenYellow;
				if (col > 9) Map[col] = System::Drawing::Color::Yellow;
				if (col > 19) Map[col] = System::Drawing::Color::Orange;
				if (col > 49) Map[col] = System::Drawing::Color::OrangeRed;
				if (col > 99) Map[col] = System::Drawing::Color::Red;
			}
			return Map;
		}

		array<System::Drawing::Color>^ CreateMap(String^ FileName)
		{
			try
			{
				array<String^>^ StringArray = System::IO::File::ReadAllLines(FileName);
				int len = StringArray->Length;
				Map = gcnew array<System::Drawing::Color>(len);
				int index = 0;
				for each (String^ line in StringArray) {
					array<String^>^ rgb = line->Split(',');
					int red = Convert::ToInt32(rgb[0]);
					int green = Convert::ToInt32(rgb[1]);
					int blue = Convert::ToInt32(rgb[2]);
					Map[index++] = Drawing::Color::FromArgb(red, green, blue);
				}
			}
			catch (Exception^ )
			{
				// Create default map
				Map = CreateBlockedMap();
			}
			return Map;
		}
		
	private: System::Void RePaint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
		if (Data->mSelected)
		{
			this->Value->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 7.0F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));

			if (Data->mImpedance < 255 && Data->mImpedance >= 0)
			{
				this->Value->Text = Convert::ToString(Data->mImpedance);
				this->ElectrodeShape->BackColor = Map[Data->mImpedance];
				this->ELabel->BackColor = Map[Data->mImpedance];
				this->ELabel->ForeColor = System::Drawing::Color::Black;
				//this->Value->Text = Convert::ToString(Data->mHardwareChannel);
				this->ELabel->Text = Data->mElectrodeLabel;
			}
			if (Data->mImpedance >= 255)
			{
				this->Value->Text = Convert::ToString("inf");
				this->ElectrodeShape->BackColor = Map[Map->Length - 1];
				this->ELabel->BackColor = Map[Map->Length - 1];
				this->ELabel->Text = Data->mElectrodeLabel;
			}
		}
		else
			{
				this->Value->Text = Convert::ToString("*");
				this->ElectrodeShape->BackColor = System::Drawing::Color::FromArgb(150, System::Drawing::Color::LightGray);
				this->ElectrodeShape->BorderColor = System::Drawing::Color::FromArgb(200, System::Drawing::Color::Gray);
				this->ELabel->ForeColor = System::Drawing::Color::FromArgb(50, System::Drawing::Color::Gray);
				this->ELabel->BackColor = System::Drawing::Color::FromArgb(150, System::Drawing::Color::LightGray);
				this->ELabel->Text = Data->mElectrodeLabel;
			}
	}

	private: System::Void hopclick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		this->ToggleSelect();
	}

	public:System::Void DeSelect()
	{
		Data->mSelected = false;
		this->Invalidate();
	}


	public: System::Void ToggleSelect()
	{
		Data->mSelected = !Data->mSelected;
		this->Invalidate();
	}


	private: System::Void Value_Click(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		if (e->Button == System::Windows::Forms::MouseButtons::Left)
		{
			this->ToggleSelect();
		}
	}
	};
}
