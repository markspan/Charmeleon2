using Microsoft.VisualBasic.PowerPacks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Timers;
using System.Xml.Serialization;

namespace Charmeleon2
{
    public partial class Charmeleon : Form
    {
        public Charmeleon()
        {
            string[] rgb = File.ReadAllLines(@"heat.map");

            Str2Col(rgb);
            try
            {
                Amplifier = new RtDeviceDriver.RefaDriver();
                try
                {
                    Amplifier.Initialize();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + Environment.NewLine + "Could you Check whether the Refa (Blue Box) is actually on?");
                    Environment.Exit(-1);
                }
                Amplifier.InitiateImpedanceDataMode();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + "Could you Check whether the Refa (Blue Box) is actually on?");
                Environment.Exit(-1);
            }

            if (Amplifier.NrOfChannels == 0)
            {
                Environment.Exit(-1);
            }

            InitializeComponent();
            PutElectrodesInArray();

            SpeedTimer = new System.Timers.Timer(500);
            SpeedTimer.Elapsed += new ElapsedEventHandler(Redraw_Callback);
            SpeedTimer.Enabled = true;
        }
        public
        unsafe void Redraw_Callback(object source, ElapsedEventArgs e)
        {
            int* Impedances = (int*)Amplifier.getImpedances();
            if (Impedances != null)
            {
                foreach (electrode.electrodeControl el in Electrodes)
                {
                    el.Impedance = Impedances[el.HardwareChannel - 1] + joophack;
                    el.Invalidate();
                }
            }
            else
            {
                foreach (electrode.electrodeControl el in Electrodes)
                {
                    el.Impedance = 0;
                    el.Invalidate();
                }
            }
        }

        private
        void PutElectrodesInArray()
        {
            Electrodes = new electrode.electrodeControl[78];
            Electrodes[0] = electrodeControl1;
            Electrodes[1] = electrodeControl2;
            Electrodes[2] = electrodeControl3;
            Electrodes[3] = electrodeControl4;
            Electrodes[4] = electrodeControl5;
            Electrodes[5] = electrodeControl6;
            Electrodes[6] = electrodeControl7;
            Electrodes[7] = electrodeControl8;
            Electrodes[8] = electrodeControl9;
            Electrodes[9] = electrodeControl10;
            Electrodes[10] = electrodeControl11;
            Electrodes[11] = electrodeControl12;
            Electrodes[12] = electrodeControl13;
            Electrodes[13] = electrodeControl14;
            Electrodes[14] = electrodeControl15;
            Electrodes[15] = electrodeControl16;
            Electrodes[16] = electrodeControl17;
            Electrodes[17] = electrodeControl18;
            Electrodes[18] = electrodeControl19;
            Electrodes[19] = electrodeControl20;
            Electrodes[20] = electrodeControl21;
            Electrodes[21] = electrodeControl22;
            Electrodes[22] = electrodeControl23;
            Electrodes[23] = electrodeControl24;
            Electrodes[24] = electrodeControl25;
            Electrodes[25] = electrodeControl26;
            Electrodes[26] = electrodeControl27;
            Electrodes[27] = electrodeControl28;
            Electrodes[28] = electrodeControl29;
            Electrodes[29] = electrodeControl30;
            Electrodes[30] = electrodeControl31;
            Electrodes[31] = electrodeControl32;
            Electrodes[32] = electrodeControl33;
            Electrodes[33] = electrodeControl34;
            Electrodes[34] = electrodeControl35;
            Electrodes[35] = electrodeControl36;
            Electrodes[36] = electrodeControl37;
            Electrodes[37] = electrodeControl38;
            Electrodes[38] = electrodeControl39;
            Electrodes[39] = electrodeControl40;
            Electrodes[40] = electrodeControl41;
            Electrodes[41] = electrodeControl42;
            Electrodes[42] = electrodeControl43;
            Electrodes[43] = electrodeControl44;
            Electrodes[44] = electrodeControl45;
            Electrodes[45] = electrodeControl46;
            Electrodes[46] = electrodeControl47;
            Electrodes[47] = electrodeControl48;
            Electrodes[48] = electrodeControl49;
            Electrodes[49] = electrodeControl50;
            Electrodes[50] = electrodeControl51;
            Electrodes[51] = electrodeControl52;
            Electrodes[52] = electrodeControl53;
            Electrodes[53] = electrodeControl54;
            Electrodes[54] = electrodeControl55;
            Electrodes[55] = electrodeControl56;
            Electrodes[56] = electrodeControl57;
            Electrodes[57] = electrodeControl58;
            Electrodes[58] = electrodeControl59;
            Electrodes[59] = electrodeControl60;
            Electrodes[60] = electrodeControl61;
            Electrodes[61] = electrodeControl62;
            Electrodes[62] = electrodeControl63;
            Electrodes[63] = electrodeControl64;
            Electrodes[64] = electrodeControl65;
            Electrodes[65] = electrodeControl66;
            Electrodes[66] = electrodeControl67;
            Electrodes[67] = electrodeControl68;
            Electrodes[68] = electrodeControl69;
            Electrodes[69] = electrodeControl70;
            Electrodes[70] = electrodeControl71;
            Electrodes[71] = electrodeControl72;
            Electrodes[72] = electrodeControl73;
            Electrodes[73] = electrodeControl74;
            Electrodes[74] = electrodeControl75;
            Electrodes[75] = electrodeControl76;
            Electrodes[76] = electrodeControl77;
            Electrodes[77] = electrodeControl78;

            int n = 0;
            foreach (electrode.electrodeControl e in Electrodes)
            {
                string Label = LongChannelNames[n].ToUpper();
                e.ElectrodeLabel = Label;
                e.Number = n++;
                e.HardwareChannel = (n - 1) % (Amplifier.NrOfChannels - 1) + 1;
                e.Selected = true;
                e.SetMap(Map);
            }
            CreateLegenda();
        }

        void Str2Col(string[] StringArray)
        {
            Map = new Color[256];
            int index = 0;
            foreach (string line in StringArray)
            {
                if (line.Length > 1)
                {
                    string[] rgb = line.Split(',');
                    int red = Convert.ToInt32(rgb[0]);
                    int green = Convert.ToInt32(rgb[1]);
                    int blue = Convert.ToInt32(rgb[2]);
                    Map[index++] = Color.FromArgb(red, green, blue);
                }
            }

        }
        void CreateLegenda()
        {
            LegendaLines = new LineShape[256];
            for (int e = 0; e < 256; e++)
                LegendaLines[e] = new LineShape { X1 = 0, X2 = 60, Y1 = e, Y2 = e, BorderColor = electrode.electrodeControl.Map[e] };

            int[] borders = new int[] { 2, 5, 10, 20, 50, 100, 200, 256 };
            LegendaIndex = new LineShape[borders.Length];

            for (int e = 0; e < borders.Length; e++)
                LegendaIndex[e] = new LineShape { X1 = 60, X2 = 80, Y1 = borders[e], Y2 = borders[e], BorderColor = Color.Black };

            this.shapeContainer2.Shapes.Clear();
            this.shapeContainer2.Shapes.AddRange(LegendaLines);
            this.shapeContainer2.Shapes.AddRange(LegendaIndex);
            for (int e = 0; e < 78; e++) Electrodes[e].Invalidate();
        }

        private
        static string[] LongChannelNames = new string[] {
            "FPz", "AFz", "Fz", "FCz", "Cz", "CPz", "Pz", "POz", "Oz", "Iz", "FP2", "AF8", "F8", "FT8", "T8", "FT10",
            "C6", "C4", "C2", "FP1", "AF7", "F7", "FT7", "T7", "TP7", "P7", "PO7", "O1", "O2", "PO8", "P8", "TP8",
            "C1", "C3", "C5", "FT9", "AF3", "F5", "F3", "F1", "AF4", "F2", "F4", "F6", "FC5", "FC3", "FC1", "FC2",
            "FC4", "FC6", "CP5", "CP3", "CP1", "CP2", "CP4", "CP6", "P5", "P3", "P1", "P2", "P4", "P6", "PO3", "PO4",
            "P9", "P10", "PO9", "PO10", "O9", "O10", "A1", "A2", "G1", "G2", "HE1", "HE2", "VE1", "VE2"
         };

        RtDeviceDriver.RefaDriver Amplifier;
        Color[] Map;
        electrode.electrodeControl[] Electrodes;
        static LineShape[] LegendaLines;
        static LineShape[] LegendaIndex;
        static System.Timers.Timer SpeedTimer;
        static int joophack = 0;
        static Random R = new Random();

        private void DeselectItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (electrode.electrodeControl el in Electrodes)
            {
                el.DeSelect();
            }
        }



        private void ChannelsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == ChannelsView)
                ChannelsView.Checked = !ChannelsView.Checked;
            foreach (electrode.electrodeControl el in Electrodes)
            {
                el.ChannelNumberShown = Convert.ToInt32(ChannelsView.Checked);
            }
        }


        private void JoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == Joop)
                Joop.Checked = !Joop.Checked;
            if (Joop.Checked)
            {
                joophack = -1;
            }
            else
            {
                joophack = 0;
            }
        }

        private void loadSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LoadHeadFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadSetup(this.LoadHeadFileDialog.FileName);
            }
        }

        private void loadSetup(String Filename)
        {
            FileStream fs = new (this.LoadHeadFileDialog.FileName, FileMode.Open);
            XmlSerializer serializer = new (typeof(electrode.electrodeControl) );

            for (int i = 0; i < Electrodes.Length; i++)
            {
                try
                {
                    Electrodes[i].Data = serializer.Deserialize(fs) as electrode.electrodeControl.mData;
                    Electrodes[i].Invalidate();
                }
                catch (SerializationException exception2)
                {
                    MessageBox.Show("Failed to Deserialize. Reason: {" + exception2.Message + "}");
                    return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Failed to Deserialize. Reason: {" + exception.Message + "}");
                    return;
                }
            }
            fs.Close();
        }

        private void saveSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            XmlSerializer serializer = null;
            if (this.SaveHeadFileDialog.ShowDialog() == DialogResult.OK)
            {
               fs = new (this.SaveHeadFileDialog.FileName, FileMode.Create);
                serializer = new(typeof(electrode.electrodeControl));
                for (int i = 0; i < Electrodes.Length; i++)
                {
                    try
                    {
                        serializer.Serialize(fs, Electrodes[i].Data);
                    }
                    catch (SerializationException exception)
                    {
                        MessageBox.Show("Failed to serialize. Reason: {" + exception.Message + "}");
                        throw;
                    }
                }
               fs.Close();
            }
        }
        private void Serialize()
        {
            FileStream fs = new ("Default.head", FileMode.Create);
            XmlSerializer serializer = new(typeof(electrode.electrodeControl));
            for (int i = 0; i < Electrodes.Length; i++)
            {
                try
                {
                    serializer.Serialize(fs, Electrodes[i].Data);
                }
                catch (SerializationException exception)
                {
                    MessageBox.Show("Failed to serialize. Reason: {" + exception.Message + "}");
                    throw;
                }
            }
            fs.Close();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newMap = null;
            if (this.OpenColorMap.ShowDialog() == DialogResult.OK)
            {
                newMap = OpenColorMap.FileName;
                Electrodes[0].SetMap(newMap);
            }
            CreateLegenda();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}