using System;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.CSharp;
using static System.Windows.Forms.DataFormats;
using System.Net.Sockets;


namespace Charmeleon2
{
    partial class Charmeleon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charmeleon));
            this.auxBox = new System.Windows.Forms.GroupBox();
            this.electrodeControl76 = new electrode.electrodeControl();
            this.electrodeControl77 = new electrode.electrodeControl();
            this.electrodeControl78 = new electrode.electrodeControl();
            this.electrodeControl75 = new electrode.electrodeControl();
            this.electrodeControl74 = new electrode.electrodeControl();
            this.electrodeControl73 = new electrode.electrodeControl();
            this.Legenda = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LegLabel1 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LegLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SaveHeadFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colormapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadHeadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenColorMap = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.electrodeControl57 = new electrode.electrodeControl();
            this.electrodeControl2 = new electrode.electrodeControl();
            this.electrodeControl31 = new electrode.electrodeControl();
            this.electrodeControl11 = new electrode.electrodeControl();
            this.electrodeControl19 = new electrode.electrodeControl();
            this.electrodeControl62 = new electrode.electrodeControl();
            this.electrodeControl64 = new electrode.electrodeControl();
            this.electrodeControl20 = new electrode.electrodeControl();
            this.electrodeControl42 = new electrode.electrodeControl();
            this.electrodeControl63 = new electrode.electrodeControl();
            this.electrodeControl18 = new electrode.electrodeControl();
            this.electrodeControl36 = new electrode.electrodeControl();
            this.electrodeControl67 = new electrode.electrodeControl();
            this.electrodeControl34 = new electrode.electrodeControl();
            this.electrodeControl69 = new electrode.electrodeControl();
            this.electrodeControl70 = new electrode.electrodeControl();
            this.electrodeControl65 = new electrode.electrodeControl();
            this.electrodeControl30 = new electrode.electrodeControl();
            this.electrodeControl33 = new electrode.electrodeControl();
            this.electrodeControl26 = new electrode.electrodeControl();
            this.electrodeControl66 = new electrode.electrodeControl();
            this.electrodeControl37 = new electrode.electrodeControl();
            this.electrodeControl41 = new electrode.electrodeControl();
            this.electrodeControl68 = new electrode.electrodeControl();
            this.electrodeControl4 = new electrode.electrodeControl();
            this.electrodeControl13 = new electrode.electrodeControl();
            this.electrodeControl6 = new electrode.electrodeControl();
            this.electrodeControl29 = new electrode.electrodeControl();
            this.electrodeControl72 = new electrode.electrodeControl();
            this.electrodeControl48 = new electrode.electrodeControl();
            this.electrodeControl44 = new electrode.electrodeControl();
            this.electrodeControl40 = new electrode.electrodeControl();
            this.electrodeControl56 = new electrode.electrodeControl();
            this.electrodeControl22 = new electrode.electrodeControl();
            this.electrodeControl25 = new electrode.electrodeControl();
            this.electrodeControl46 = new electrode.electrodeControl();
            this.electrodeControl47 = new electrode.electrodeControl();
            this.electrodeControl55 = new electrode.electrodeControl();
            this.electrodeControl45 = new electrode.electrodeControl();
            this.electrodeControl15 = new electrode.electrodeControl();
            this.electrodeControl12 = new electrode.electrodeControl();
            this.electrodeControl5 = new electrode.electrodeControl();
            this.electrodeControl38 = new electrode.electrodeControl();
            this.electrodeControl49 = new electrode.electrodeControl();
            this.electrodeControl23 = new electrode.electrodeControl();
            this.electrodeControl53 = new electrode.electrodeControl();
            this.electrodeControl27 = new electrode.electrodeControl();
            this.electrodeControl51 = new electrode.electrodeControl();
            this.electrodeControl60 = new electrode.electrodeControl();
            this.electrodeControl24 = new electrode.electrodeControl();
            this.electrodeControl52 = new electrode.electrodeControl();
            this.electrodeControl1 = new electrode.electrodeControl();
            this.electrodeControl8 = new electrode.electrodeControl();
            this.electrodeControl16 = new electrode.electrodeControl();
            this.electrodeControl28 = new electrode.electrodeControl();
            this.electrodeControl39 = new electrode.electrodeControl();
            this.electrodeControl21 = new electrode.electrodeControl();
            this.electrodeControl54 = new electrode.electrodeControl();
            this.electrodeControl61 = new electrode.electrodeControl();
            this.electrodeControl59 = new electrode.electrodeControl();
            this.electrodeControl50 = new electrode.electrodeControl();
            this.electrodeControl10 = new electrode.electrodeControl();
            this.electrodeControl7 = new electrode.electrodeControl();
            this.electrodeControl71 = new electrode.electrodeControl();
            this.electrodeControl3 = new electrode.electrodeControl();
            this.electrodeControl9 = new electrode.electrodeControl();
            this.electrodeControl17 = new electrode.electrodeControl();
            this.electrodeControl58 = new electrode.electrodeControl();
            this.electrodeControl32 = new electrode.electrodeControl();
            this.electrodeControl35 = new electrode.electrodeControl();
            this.electrodeControl43 = new electrode.electrodeControl();
            this.electrodeControl14 = new electrode.electrodeControl();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exceptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Joop = new System.Windows.Forms.ToolStripMenuItem();
            this.ChannelsView = new System.Windows.Forms.ToolStripMenuItem();
            this.DeselectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxBox.SuspendLayout();
            this.Legenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // auxBox
            // 
            this.auxBox.Controls.Add(this.electrodeControl76);
            this.auxBox.Controls.Add(this.electrodeControl77);
            this.auxBox.Controls.Add(this.electrodeControl78);
            this.auxBox.Controls.Add(this.electrodeControl75);
            this.auxBox.Controls.Add(this.electrodeControl74);
            this.auxBox.Controls.Add(this.electrodeControl73);
            this.auxBox.Location = new System.Drawing.Point(632, 439);
            this.auxBox.Name = "auxBox";
            this.auxBox.Size = new System.Drawing.Size(146, 244);
            this.auxBox.TabIndex = 56;
            this.auxBox.TabStop = false;
            this.auxBox.Text = "Auxillary";
            // 
            // electrodeControl76
            // 
            this.electrodeControl76.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl76.ElectrodeLabel = null;
            this.electrodeControl76.HardwareChannel = 0;
            this.electrodeControl76.Location = new System.Drawing.Point(32, 107);
            this.electrodeControl76.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl76.Name = "electrodeControl76";
            this.electrodeControl76.Number = 0;
            this.electrodeControl76.Selected = true;
            this.electrodeControl76.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl76.TabIndex = 5;
            // 
            // electrodeControl77
            // 
            this.electrodeControl77.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl77.ElectrodeLabel = null;
            this.electrodeControl77.HardwareChannel = 0;
            this.electrodeControl77.Location = new System.Drawing.Point(32, 184);
            this.electrodeControl77.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl77.Name = "electrodeControl77";
            this.electrodeControl77.Number = 0;
            this.electrodeControl77.Selected = true;
            this.electrodeControl77.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl77.TabIndex = 4;
            // 
            // electrodeControl78
            // 
            this.electrodeControl78.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl78.ElectrodeLabel = null;
            this.electrodeControl78.HardwareChannel = 0;
            this.electrodeControl78.Location = new System.Drawing.Point(81, 184);
            this.electrodeControl78.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl78.Name = "electrodeControl78";
            this.electrodeControl78.Number = 0;
            this.electrodeControl78.Selected = true;
            this.electrodeControl78.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl78.TabIndex = 3;
            // 
            // electrodeControl75
            // 
            this.electrodeControl75.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl75.ElectrodeLabel = null;
            this.electrodeControl75.HardwareChannel = 0;
            this.electrodeControl75.Location = new System.Drawing.Point(81, 107);
            this.electrodeControl75.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl75.Name = "electrodeControl75";
            this.electrodeControl75.Number = 0;
            this.electrodeControl75.Selected = true;
            this.electrodeControl75.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl75.TabIndex = 2;
            // 
            // electrodeControl74
            // 
            this.electrodeControl74.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl74.ElectrodeLabel = null;
            this.electrodeControl74.HardwareChannel = 0;
            this.electrodeControl74.Location = new System.Drawing.Point(81, 30);
            this.electrodeControl74.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl74.Name = "electrodeControl74";
            this.electrodeControl74.Number = 0;
            this.electrodeControl74.Selected = true;
            this.electrodeControl74.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl74.TabIndex = 1;
            // 
            // electrodeControl73
            // 
            this.electrodeControl73.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl73.ElectrodeLabel = null;
            this.electrodeControl73.HardwareChannel = 0;
            this.electrodeControl73.Location = new System.Drawing.Point(32, 30);
            this.electrodeControl73.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl73.Name = "electrodeControl73";
            this.electrodeControl73.Number = 0;
            this.electrodeControl73.Selected = true;
            this.electrodeControl73.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl73.TabIndex = 0;
            // 
            // Legenda
            // 
            this.Legenda.Controls.Add(this.label7);
            this.Legenda.Controls.Add(this.label6);
            this.Legenda.Controls.Add(this.label2);
            this.Legenda.Controls.Add(this.label1);
            this.Legenda.Controls.Add(this.label5);
            this.Legenda.Controls.Add(this.label4);
            this.Legenda.Controls.Add(this.label3);
            this.Legenda.Controls.Add(this.LegLabel1);
            this.Legenda.Controls.Add(this.shapeContainer2);
            this.Legenda.Location = new System.Drawing.Point(632, 63);
            this.Legenda.Name = "Legenda";
            this.Legenda.Size = new System.Drawing.Size(149, 318);
            this.Legenda.TabIndex = 55;
            this.Legenda.TabStop = false;
            this.Legenda.Text = "Legenda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Really High";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "200 kOhm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "100";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "50";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "20";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LegLabel1
            // 
            this.LegLabel1.AutoSize = true;
            this.LegLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegLabel1.Location = new System.Drawing.Point(77, 9);
            this.LegLabel1.Name = "LegLabel1";
            this.LegLabel1.Size = new System.Drawing.Size(13, 13);
            this.LegLabel1.TabIndex = 58;
            this.LegLabel1.Text = "2";
            this.LegLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LegLine});
            this.shapeContainer2.Size = new System.Drawing.Size(143, 299);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // LegLine
            // 
            this.LegLine.Name = "LegLine";
            this.LegLine.X1 = 0;
            this.LegLine.X2 = 0;
            this.LegLine.Y1 = 0;
            this.LegLine.Y2 = 0;
            // 
            // SaveHeadFileDialog
            // 
            this.SaveHeadFileDialog.FileName = "default.head";
            this.SaveHeadFileDialog.Filter = "Head Files|*.head";
            this.SaveHeadFileDialog.RestoreDirectory = true;
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSetupToolStripMenuItem,
            this.saveSetupToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // loadSetupToolStripMenuItem
            // 
            this.loadSetupToolStripMenuItem.Name = "loadSetupToolStripMenuItem";
            this.loadSetupToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadSetupToolStripMenuItem.Text = "Load Setup";
            this.loadSetupToolStripMenuItem.Click += new System.EventHandler(this.loadSetupToolStripMenuItem_Click);
            // 
            // saveSetupToolStripMenuItem
            // 
            this.saveSetupToolStripMenuItem.Name = "saveSetupToolStripMenuItem";
            this.saveSetupToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveSetupToolStripMenuItem.Text = "Save Setup";
            this.saveSetupToolStripMenuItem.Click += new System.EventHandler(this.saveSetupToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // colormapToolStripMenuItem
            // 
            this.colormapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.colormapToolStripMenuItem.Name = "colormapToolStripMenuItem";
            this.colormapToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.colormapToolStripMenuItem.Text = "Colormap";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // LoadHeadFileDialog
            // 
            this.LoadHeadFileDialog.FileName = "default.head";
            this.LoadHeadFileDialog.Filter = "Head Files | *.head";
            this.LoadHeadFileDialog.RestoreDirectory = true;
            // 
            // OpenColorMap
            // 
            this.OpenColorMap.FileName = "default.map";
            this.OpenColorMap.Filter = "Colormap | *.map";
            this.OpenColorMap.RestoreDirectory = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.electrodeControl57);
            this.panel1.Controls.Add(this.electrodeControl2);
            this.panel1.Controls.Add(this.electrodeControl31);
            this.panel1.Controls.Add(this.electrodeControl11);
            this.panel1.Controls.Add(this.electrodeControl19);
            this.panel1.Controls.Add(this.electrodeControl62);
            this.panel1.Controls.Add(this.electrodeControl64);
            this.panel1.Controls.Add(this.electrodeControl20);
            this.panel1.Controls.Add(this.auxBox);
            this.panel1.Controls.Add(this.Legenda);
            this.panel1.Controls.Add(this.electrodeControl42);
            this.panel1.Controls.Add(this.electrodeControl63);
            this.panel1.Controls.Add(this.electrodeControl18);
            this.panel1.Controls.Add(this.electrodeControl36);
            this.panel1.Controls.Add(this.electrodeControl67);
            this.panel1.Controls.Add(this.electrodeControl34);
            this.panel1.Controls.Add(this.electrodeControl69);
            this.panel1.Controls.Add(this.electrodeControl70);
            this.panel1.Controls.Add(this.electrodeControl65);
            this.panel1.Controls.Add(this.electrodeControl30);
            this.panel1.Controls.Add(this.electrodeControl33);
            this.panel1.Controls.Add(this.electrodeControl26);
            this.panel1.Controls.Add(this.electrodeControl66);
            this.panel1.Controls.Add(this.electrodeControl37);
            this.panel1.Controls.Add(this.electrodeControl41);
            this.panel1.Controls.Add(this.electrodeControl68);
            this.panel1.Controls.Add(this.electrodeControl4);
            this.panel1.Controls.Add(this.electrodeControl13);
            this.panel1.Controls.Add(this.electrodeControl6);
            this.panel1.Controls.Add(this.electrodeControl29);
            this.panel1.Controls.Add(this.electrodeControl72);
            this.panel1.Controls.Add(this.electrodeControl48);
            this.panel1.Controls.Add(this.electrodeControl44);
            this.panel1.Controls.Add(this.electrodeControl40);
            this.panel1.Controls.Add(this.electrodeControl56);
            this.panel1.Controls.Add(this.electrodeControl22);
            this.panel1.Controls.Add(this.electrodeControl25);
            this.panel1.Controls.Add(this.electrodeControl46);
            this.panel1.Controls.Add(this.electrodeControl47);
            this.panel1.Controls.Add(this.electrodeControl55);
            this.panel1.Controls.Add(this.electrodeControl45);
            this.panel1.Controls.Add(this.electrodeControl15);
            this.panel1.Controls.Add(this.electrodeControl12);
            this.panel1.Controls.Add(this.electrodeControl5);
            this.panel1.Controls.Add(this.electrodeControl38);
            this.panel1.Controls.Add(this.electrodeControl49);
            this.panel1.Controls.Add(this.electrodeControl23);
            this.panel1.Controls.Add(this.electrodeControl53);
            this.panel1.Controls.Add(this.electrodeControl27);
            this.panel1.Controls.Add(this.electrodeControl51);
            this.panel1.Controls.Add(this.electrodeControl60);
            this.panel1.Controls.Add(this.electrodeControl24);
            this.panel1.Controls.Add(this.electrodeControl52);
            this.panel1.Controls.Add(this.electrodeControl1);
            this.panel1.Controls.Add(this.electrodeControl8);
            this.panel1.Controls.Add(this.electrodeControl16);
            this.panel1.Controls.Add(this.electrodeControl28);
            this.panel1.Controls.Add(this.electrodeControl39);
            this.panel1.Controls.Add(this.electrodeControl21);
            this.panel1.Controls.Add(this.electrodeControl54);
            this.panel1.Controls.Add(this.electrodeControl61);
            this.panel1.Controls.Add(this.electrodeControl59);
            this.panel1.Controls.Add(this.electrodeControl50);
            this.panel1.Controls.Add(this.electrodeControl10);
            this.panel1.Controls.Add(this.electrodeControl7);
            this.panel1.Controls.Add(this.electrodeControl71);
            this.panel1.Controls.Add(this.electrodeControl3);
            this.panel1.Controls.Add(this.electrodeControl9);
            this.panel1.Controls.Add(this.electrodeControl17);
            this.panel1.Controls.Add(this.electrodeControl58);
            this.panel1.Controls.Add(this.electrodeControl32);
            this.panel1.Controls.Add(this.electrodeControl35);
            this.panel1.Controls.Add(this.electrodeControl43);
            this.panel1.Controls.Add(this.electrodeControl14);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 686);
            this.panel1.TabIndex = 5;
            // 
            // electrodeControl57
            // 
            this.electrodeControl57.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl57.ElectrodeLabel = null;
            this.electrodeControl57.HardwareChannel = 0;
            this.electrodeControl57.Location = new System.Drawing.Point(148, 466);
            this.electrodeControl57.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl57.Name = "electrodeControl57";
            this.electrodeControl57.Number = 0;
            this.electrodeControl57.Selected = true;
            this.electrodeControl57.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl57.TabIndex = 6;
            // 
            // electrodeControl2
            // 
            this.electrodeControl2.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl2.ElectrodeLabel = "";
            this.electrodeControl2.HardwareChannel = 0;
            this.electrodeControl2.Location = new System.Drawing.Point(297, 140);
            this.electrodeControl2.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl2.Name = "electrodeControl2";
            this.electrodeControl2.Number = 0;
            this.electrodeControl2.Selected = true;
            this.electrodeControl2.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl2.TabIndex = 2;
            // 
            // electrodeControl31
            // 
            this.electrodeControl31.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl31.ElectrodeLabel = null;
            this.electrodeControl31.HardwareChannel = 0;
            this.electrodeControl31.Location = new System.Drawing.Point(492, 480);
            this.electrodeControl31.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl31.Name = "electrodeControl31";
            this.electrodeControl31.Number = 0;
            this.electrodeControl31.Selected = true;
            this.electrodeControl31.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl31.TabIndex = 26;
            // 
            // electrodeControl11
            // 
            this.electrodeControl11.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl11.ElectrodeLabel = null;
            this.electrodeControl11.HardwareChannel = 0;
            this.electrodeControl11.Location = new System.Drawing.Point(370, 82);
            this.electrodeControl11.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl11.Name = "electrodeControl11";
            this.electrodeControl11.Number = 0;
            this.electrodeControl11.Selected = true;
            this.electrodeControl11.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl11.TabIndex = 5;
            // 
            // electrodeControl19
            // 
            this.electrodeControl19.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl19.ElectrodeLabel = null;
            this.electrodeControl19.HardwareChannel = 0;
            this.electrodeControl19.Location = new System.Drawing.Point(358, 326);
            this.electrodeControl19.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl19.Name = "electrodeControl19";
            this.electrodeControl19.Number = 0;
            this.electrodeControl19.Selected = true;
            this.electrodeControl19.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl19.TabIndex = 16;
            // 
            // electrodeControl62
            // 
            this.electrodeControl62.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl62.ElectrodeLabel = null;
            this.electrodeControl62.HardwareChannel = 0;
            this.electrodeControl62.Location = new System.Drawing.Point(443, 466);
            this.electrodeControl62.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl62.Name = "electrodeControl62";
            this.electrodeControl62.Number = 0;
            this.electrodeControl62.Selected = true;
            this.electrodeControl62.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl62.TabIndex = 45;
            // 
            // electrodeControl64
            // 
            this.electrodeControl64.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl64.ElectrodeLabel = null;
            this.electrodeControl64.HardwareChannel = 0;
            this.electrodeControl64.Location = new System.Drawing.Point(370, 512);
            this.electrodeControl64.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl64.Name = "electrodeControl64";
            this.electrodeControl64.Number = 0;
            this.electrodeControl64.Selected = true;
            this.electrodeControl64.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl64.TabIndex = 6;
            // 
            // electrodeControl20
            // 
            this.electrodeControl20.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl20.ElectrodeLabel = null;
            this.electrodeControl20.HardwareChannel = 0;
            this.electrodeControl20.Location = new System.Drawing.Point(224, 82);
            this.electrodeControl20.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl20.Name = "electrodeControl20";
            this.electrodeControl20.Number = 0;
            this.electrodeControl20.Selected = true;
            this.electrodeControl20.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl20.TabIndex = 5;
            // 
            // electrodeControl42
            // 
            this.electrodeControl42.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl42.ElectrodeLabel = null;
            this.electrodeControl42.HardwareChannel = 0;
            this.electrodeControl42.Location = new System.Drawing.Point(347, 202);
            this.electrodeControl42.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl42.Name = "electrodeControl42";
            this.electrodeControl42.Number = 0;
            this.electrodeControl42.Selected = true;
            this.electrodeControl42.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl42.TabIndex = 33;
            // 
            // electrodeControl63
            // 
            this.electrodeControl63.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl63.ElectrodeLabel = null;
            this.electrodeControl63.HardwareChannel = 0;
            this.electrodeControl63.Location = new System.Drawing.Point(224, 512);
            this.electrodeControl63.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl63.Name = "electrodeControl63";
            this.electrodeControl63.Number = 0;
            this.electrodeControl63.Selected = true;
            this.electrodeControl63.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl63.TabIndex = 6;
            // 
            // electrodeControl18
            // 
            this.electrodeControl18.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl18.ElectrodeLabel = null;
            this.electrodeControl18.HardwareChannel = 0;
            this.electrodeControl18.Location = new System.Drawing.Point(420, 326);
            this.electrodeControl18.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl18.Name = "electrodeControl18";
            this.electrodeControl18.Number = 0;
            this.electrodeControl18.Selected = true;
            this.electrodeControl18.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl18.TabIndex = 15;
            // 
            // electrodeControl36
            // 
            this.electrodeControl36.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl36.ElectrodeLabel = null;
            this.electrodeControl36.HardwareChannel = 0;
            this.electrodeControl36.Location = new System.Drawing.Point(18, 238);
            this.electrodeControl36.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl36.Name = "electrodeControl36";
            this.electrodeControl36.Number = 0;
            this.electrodeControl36.Selected = true;
            this.electrodeControl36.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl36.TabIndex = 5;
            // 
            // electrodeControl67
            // 
            this.electrodeControl67.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl67.ElectrodeLabel = null;
            this.electrodeControl67.HardwareChannel = 0;
            this.electrodeControl67.Location = new System.Drawing.Point(137, 584);
            this.electrodeControl67.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl67.Name = "electrodeControl67";
            this.electrodeControl67.Number = 0;
            this.electrodeControl67.Selected = true;
            this.electrodeControl67.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl67.TabIndex = 6;
            // 
            // electrodeControl34
            // 
            this.electrodeControl34.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl34.ElectrodeLabel = null;
            this.electrodeControl34.HardwareChannel = 0;
            this.electrodeControl34.Location = new System.Drawing.Point(172, 326);
            this.electrodeControl34.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl34.Name = "electrodeControl34";
            this.electrodeControl34.Number = 0;
            this.electrodeControl34.Selected = true;
            this.electrodeControl34.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl34.TabIndex = 28;
            // 
            // electrodeControl69
            // 
            this.electrodeControl69.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl69.ElectrodeLabel = null;
            this.electrodeControl69.HardwareChannel = 0;
            this.electrodeControl69.Location = new System.Drawing.Point(213, 620);
            this.electrodeControl69.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl69.Name = "electrodeControl69";
            this.electrodeControl69.Number = 0;
            this.electrodeControl69.Selected = true;
            this.electrodeControl69.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl69.TabIndex = 48;
            // 
            // electrodeControl70
            // 
            this.electrodeControl70.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl70.ElectrodeLabel = null;
            this.electrodeControl70.HardwareChannel = 0;
            this.electrodeControl70.Location = new System.Drawing.Point(370, 621);
            this.electrodeControl70.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl70.Name = "electrodeControl70";
            this.electrodeControl70.Number = 0;
            this.electrodeControl70.Selected = true;
            this.electrodeControl70.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl70.TabIndex = 49;
            // 
            // electrodeControl65
            // 
            this.electrodeControl65.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl65.ElectrodeLabel = null;
            this.electrodeControl65.HardwareChannel = 0;
            this.electrodeControl65.Location = new System.Drawing.Point(39, 496);
            this.electrodeControl65.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl65.Name = "electrodeControl65";
            this.electrodeControl65.Number = 0;
            this.electrodeControl65.Selected = true;
            this.electrodeControl65.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl65.TabIndex = 6;
            // 
            // electrodeControl30
            // 
            this.electrodeControl30.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl30.ElectrodeLabel = null;
            this.electrodeControl30.HardwareChannel = 0;
            this.electrodeControl30.Location = new System.Drawing.Point(436, 530);
            this.electrodeControl30.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl30.Name = "electrodeControl30";
            this.electrodeControl30.Number = 0;
            this.electrodeControl30.Selected = true;
            this.electrodeControl30.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl30.TabIndex = 25;
            // 
            // electrodeControl33
            // 
            this.electrodeControl33.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl33.ElectrodeLabel = null;
            this.electrodeControl33.HardwareChannel = 0;
            this.electrodeControl33.Location = new System.Drawing.Point(234, 326);
            this.electrodeControl33.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl33.Name = "electrodeControl33";
            this.electrodeControl33.Number = 0;
            this.electrodeControl33.Selected = true;
            this.electrodeControl33.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl33.TabIndex = 5;
            // 
            // electrodeControl26
            // 
            this.electrodeControl26.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl26.ElectrodeLabel = null;
            this.electrodeControl26.HardwareChannel = 0;
            this.electrodeControl26.Location = new System.Drawing.Point(99, 480);
            this.electrodeControl26.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl26.Name = "electrodeControl26";
            this.electrodeControl26.Number = 0;
            this.electrodeControl26.Selected = true;
            this.electrodeControl26.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl26.TabIndex = 21;
            // 
            // electrodeControl66
            // 
            this.electrodeControl66.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl66.ElectrodeLabel = null;
            this.electrodeControl66.HardwareChannel = 0;
            this.electrodeControl66.Location = new System.Drawing.Point(556, 496);
            this.electrodeControl66.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl66.Name = "electrodeControl66";
            this.electrodeControl66.Number = 0;
            this.electrodeControl66.Selected = true;
            this.electrodeControl66.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl66.TabIndex = 46;
            // 
            // electrodeControl37
            // 
            this.electrodeControl37.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl37.ElectrodeLabel = null;
            this.electrodeControl37.HardwareChannel = 0;
            this.electrodeControl37.Location = new System.Drawing.Point(235, 140);
            this.electrodeControl37.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl37.Name = "electrodeControl37";
            this.electrodeControl37.Number = 0;
            this.electrodeControl37.Selected = true;
            this.electrodeControl37.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl37.TabIndex = 5;
            // 
            // electrodeControl41
            // 
            this.electrodeControl41.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl41.ElectrodeLabel = null;
            this.electrodeControl41.HardwareChannel = 0;
            this.electrodeControl41.Location = new System.Drawing.Point(356, 140);
            this.electrodeControl41.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl41.Name = "electrodeControl41";
            this.electrodeControl41.Number = 0;
            this.electrodeControl41.Selected = true;
            this.electrodeControl41.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl41.TabIndex = 32;
            // 
            // electrodeControl68
            // 
            this.electrodeControl68.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl68.ElectrodeLabel = null;
            this.electrodeControl68.HardwareChannel = 0;
            this.electrodeControl68.Location = new System.Drawing.Point(458, 584);
            this.electrodeControl68.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl68.Name = "electrodeControl68";
            this.electrodeControl68.Number = 0;
            this.electrodeControl68.Selected = true;
            this.electrodeControl68.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl68.TabIndex = 47;
            // 
            // electrodeControl4
            // 
            this.electrodeControl4.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl4.ElectrodeLabel = null;
            this.electrodeControl4.HardwareChannel = 0;
            this.electrodeControl4.Location = new System.Drawing.Point(297, 264);
            this.electrodeControl4.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl4.Name = "electrodeControl4";
            this.electrodeControl4.Number = 0;
            this.electrodeControl4.Selected = true;
            this.electrodeControl4.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl4.TabIndex = 4;
            // 
            // electrodeControl13
            // 
            this.electrodeControl13.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl13.ElectrodeLabel = null;
            this.electrodeControl13.HardwareChannel = 0;
            this.electrodeControl13.Location = new System.Drawing.Point(497, 191);
            this.electrodeControl13.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl13.Name = "electrodeControl13";
            this.electrodeControl13.Number = 0;
            this.electrodeControl13.Selected = true;
            this.electrodeControl13.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl13.TabIndex = 12;
            // 
            // electrodeControl6
            // 
            this.electrodeControl6.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl6.ElectrodeLabel = null;
            this.electrodeControl6.HardwareChannel = 0;
            this.electrodeControl6.Location = new System.Drawing.Point(296, 388);
            this.electrodeControl6.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl6.Name = "electrodeControl6";
            this.electrodeControl6.Number = 0;
            this.electrodeControl6.Selected = true;
            this.electrodeControl6.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl6.TabIndex = 6;
            // 
            // electrodeControl29
            // 
            this.electrodeControl29.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl29.ElectrodeLabel = null;
            this.electrodeControl29.HardwareChannel = 0;
            this.electrodeControl29.Location = new System.Drawing.Point(367, 566);
            this.electrodeControl29.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl29.Name = "electrodeControl29";
            this.electrodeControl29.Number = 0;
            this.electrodeControl29.Selected = true;
            this.electrodeControl29.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl29.TabIndex = 24;
            // 
            // electrodeControl72
            // 
            this.electrodeControl72.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl72.ElectrodeLabel = null;
            this.electrodeControl72.HardwareChannel = 0;
            this.electrodeControl72.Location = new System.Drawing.Point(53, 43);
            this.electrodeControl72.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl72.Name = "electrodeControl72";
            this.electrodeControl72.Number = 0;
            this.electrodeControl72.Selected = true;
            this.electrodeControl72.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl72.TabIndex = 53;
            // 
            // electrodeControl48
            // 
            this.electrodeControl48.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl48.ElectrodeLabel = null;
            this.electrodeControl48.HardwareChannel = 0;
            this.electrodeControl48.Location = new System.Drawing.Point(354, 263);
            this.electrodeControl48.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl48.Name = "electrodeControl48";
            this.electrodeControl48.Number = 0;
            this.electrodeControl48.Selected = true;
            this.electrodeControl48.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl48.TabIndex = 36;
            // 
            // electrodeControl44
            // 
            this.electrodeControl44.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl44.ElectrodeLabel = null;
            this.electrodeControl44.HardwareChannel = 0;
            this.electrodeControl44.Location = new System.Drawing.Point(447, 197);
            this.electrodeControl44.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl44.Name = "electrodeControl44";
            this.electrodeControl44.Number = 0;
            this.electrodeControl44.Selected = true;
            this.electrodeControl44.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl44.TabIndex = 35;
            // 
            // electrodeControl40
            // 
            this.electrodeControl40.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl40.ElectrodeLabel = null;
            this.electrodeControl40.HardwareChannel = 0;
            this.electrodeControl40.Location = new System.Drawing.Point(247, 204);
            this.electrodeControl40.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl40.Name = "electrodeControl40";
            this.electrodeControl40.Number = 0;
            this.electrodeControl40.Selected = true;
            this.electrodeControl40.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl40.TabIndex = 5;
            // 
            // electrodeControl56
            // 
            this.electrodeControl56.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl56.ElectrodeLabel = null;
            this.electrodeControl56.HardwareChannel = 0;
            this.electrodeControl56.Location = new System.Drawing.Point(470, 396);
            this.electrodeControl56.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl56.Name = "electrodeControl56";
            this.electrodeControl56.Number = 0;
            this.electrodeControl56.Selected = true;
            this.electrodeControl56.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl56.TabIndex = 41;
            // 
            // electrodeControl22
            // 
            this.electrodeControl22.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl22.ElectrodeLabel = null;
            this.electrodeControl22.HardwareChannel = 0;
            this.electrodeControl22.Location = new System.Drawing.Point(97, 193);
            this.electrodeControl22.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl22.Name = "electrodeControl22";
            this.electrodeControl22.Number = 0;
            this.electrodeControl22.Selected = true;
            this.electrodeControl22.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl22.TabIndex = 5;
            // 
            // electrodeControl25
            // 
            this.electrodeControl25.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl25.ElectrodeLabel = null;
            this.electrodeControl25.HardwareChannel = 0;
            this.electrodeControl25.Location = new System.Drawing.Point(64, 405);
            this.electrodeControl25.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl25.Name = "electrodeControl25";
            this.electrodeControl25.Number = 0;
            this.electrodeControl25.Selected = true;
            this.electrodeControl25.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl25.TabIndex = 20;
            // 
            // electrodeControl46
            // 
            this.electrodeControl46.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl46.ElectrodeLabel = null;
            this.electrodeControl46.HardwareChannel = 0;
            this.electrodeControl46.Location = new System.Drawing.Point(180, 263);
            this.electrodeControl46.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl46.Name = "electrodeControl46";
            this.electrodeControl46.Number = 0;
            this.electrodeControl46.Selected = true;
            this.electrodeControl46.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl46.TabIndex = 6;
            // 
            // electrodeControl47
            // 
            this.electrodeControl47.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl47.ElectrodeLabel = null;
            this.electrodeControl47.HardwareChannel = 0;
            this.electrodeControl47.Location = new System.Drawing.Point(238, 263);
            this.electrodeControl47.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl47.Name = "electrodeControl47";
            this.electrodeControl47.Number = 0;
            this.electrodeControl47.Selected = true;
            this.electrodeControl47.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl47.TabIndex = 6;
            // 
            // electrodeControl55
            // 
            this.electrodeControl55.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl55.ElectrodeLabel = null;
            this.electrodeControl55.HardwareChannel = 0;
            this.electrodeControl55.Location = new System.Drawing.Point(412, 392);
            this.electrodeControl55.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl55.Name = "electrodeControl55";
            this.electrodeControl55.Number = 0;
            this.electrodeControl55.Selected = true;
            this.electrodeControl55.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl55.TabIndex = 40;
            // 
            // electrodeControl45
            // 
            this.electrodeControl45.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl45.ElectrodeLabel = null;
            this.electrodeControl45.HardwareChannel = 0;
            this.electrodeControl45.Location = new System.Drawing.Point(122, 260);
            this.electrodeControl45.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl45.Name = "electrodeControl45";
            this.electrodeControl45.Number = 0;
            this.electrodeControl45.Selected = true;
            this.electrodeControl45.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl45.TabIndex = 5;
            // 
            // electrodeControl15
            // 
            this.electrodeControl15.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl15.ElectrodeLabel = null;
            this.electrodeControl15.HardwareChannel = 0;
            this.electrodeControl15.Location = new System.Drawing.Point(544, 326);
            this.electrodeControl15.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl15.Name = "electrodeControl15";
            this.electrodeControl15.Number = 0;
            this.electrodeControl15.Selected = true;
            this.electrodeControl15.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl15.TabIndex = 14;
            // 
            // electrodeControl12
            // 
            this.electrodeControl12.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl12.ElectrodeLabel = null;
            this.electrodeControl12.HardwareChannel = 0;
            this.electrodeControl12.Location = new System.Drawing.Point(436, 121);
            this.electrodeControl12.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl12.Name = "electrodeControl12";
            this.electrodeControl12.Number = 0;
            this.electrodeControl12.Selected = true;
            this.electrodeControl12.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl12.TabIndex = 11;
            // 
            // electrodeControl5
            // 
            this.electrodeControl5.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl5.ElectrodeLabel = null;
            this.electrodeControl5.HardwareChannel = 0;
            this.electrodeControl5.Location = new System.Drawing.Point(297, 326);
            this.electrodeControl5.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl5.Name = "electrodeControl5";
            this.electrodeControl5.Number = 0;
            this.electrodeControl5.Selected = true;
            this.electrodeControl5.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl5.TabIndex = 5;
            // 
            // electrodeControl38
            // 
            this.electrodeControl38.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl38.ElectrodeLabel = null;
            this.electrodeControl38.HardwareChannel = 0;
            this.electrodeControl38.Location = new System.Drawing.Point(147, 199);
            this.electrodeControl38.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl38.Name = "electrodeControl38";
            this.electrodeControl38.Number = 0;
            this.electrodeControl38.Selected = true;
            this.electrodeControl38.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl38.TabIndex = 30;
            // 
            // electrodeControl49
            // 
            this.electrodeControl49.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl49.ElectrodeLabel = null;
            this.electrodeControl49.HardwareChannel = 0;
            this.electrodeControl49.Location = new System.Drawing.Point(412, 263);
            this.electrodeControl49.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl49.Name = "electrodeControl49";
            this.electrodeControl49.Number = 0;
            this.electrodeControl49.Selected = true;
            this.electrodeControl49.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl49.TabIndex = 37;
            // 
            // electrodeControl23
            // 
            this.electrodeControl23.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl23.ElectrodeLabel = null;
            this.electrodeControl23.HardwareChannel = 0;
            this.electrodeControl23.Location = new System.Drawing.Point(64, 253);
            this.electrodeControl23.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl23.Name = "electrodeControl23";
            this.electrodeControl23.Number = 0;
            this.electrodeControl23.Selected = true;
            this.electrodeControl23.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl23.TabIndex = 18;
            // 
            // electrodeControl53
            // 
            this.electrodeControl53.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl53.ElectrodeLabel = null;
            this.electrodeControl53.HardwareChannel = 0;
            this.electrodeControl53.Location = new System.Drawing.Point(238, 389);
            this.electrodeControl53.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl53.Name = "electrodeControl53";
            this.electrodeControl53.Number = 0;
            this.electrodeControl53.Selected = true;
            this.electrodeControl53.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl53.TabIndex = 39;
            // 
            // electrodeControl27
            // 
            this.electrodeControl27.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl27.ElectrodeLabel = null;
            this.electrodeControl27.HardwareChannel = 0;
            this.electrodeControl27.Location = new System.Drawing.Point(158, 530);
            this.electrodeControl27.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl27.Name = "electrodeControl27";
            this.electrodeControl27.Number = 0;
            this.electrodeControl27.Selected = true;
            this.electrodeControl27.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl27.TabIndex = 22;
            // 
            // electrodeControl51
            // 
            this.electrodeControl51.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl51.ElectrodeLabel = null;
            this.electrodeControl51.HardwareChannel = 0;
            this.electrodeControl51.Location = new System.Drawing.Point(122, 396);
            this.electrodeControl51.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl51.Name = "electrodeControl51";
            this.electrodeControl51.Number = 0;
            this.electrodeControl51.Selected = true;
            this.electrodeControl51.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl51.TabIndex = 6;
            // 
            // electrodeControl60
            // 
            this.electrodeControl60.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl60.ElectrodeLabel = null;
            this.electrodeControl60.HardwareChannel = 0;
            this.electrodeControl60.Location = new System.Drawing.Point(344, 455);
            this.electrodeControl60.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl60.Name = "electrodeControl60";
            this.electrodeControl60.Number = 0;
            this.electrodeControl60.Selected = true;
            this.electrodeControl60.Size = new System.Drawing.Size(38, 52);
            this.electrodeControl60.TabIndex = 44;
            // 
            // electrodeControl24
            // 
            this.electrodeControl24.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl24.ElectrodeLabel = null;
            this.electrodeControl24.HardwareChannel = 0;
            this.electrodeControl24.Location = new System.Drawing.Point(48, 326);
            this.electrodeControl24.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl24.Name = "electrodeControl24";
            this.electrodeControl24.Number = 0;
            this.electrodeControl24.Selected = true;
            this.electrodeControl24.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl24.TabIndex = 19;
            // 
            // electrodeControl52
            // 
            this.electrodeControl52.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl52.ElectrodeLabel = null;
            this.electrodeControl52.HardwareChannel = 0;
            this.electrodeControl52.Location = new System.Drawing.Point(180, 392);
            this.electrodeControl52.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl52.Name = "electrodeControl52";
            this.electrodeControl52.Number = 0;
            this.electrodeControl52.Selected = true;
            this.electrodeControl52.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl52.TabIndex = 6;
            // 
            // electrodeControl1
            // 
            this.electrodeControl1.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl1.ElectrodeLabel = "";
            this.electrodeControl1.HardwareChannel = 0;
            this.electrodeControl1.Location = new System.Drawing.Point(297, 78);
            this.electrodeControl1.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl1.Name = "electrodeControl1";
            this.electrodeControl1.Number = 0;
            this.electrodeControl1.Selected = true;
            this.electrodeControl1.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl1.TabIndex = 1;
            // 
            // electrodeControl8
            // 
            this.electrodeControl8.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl8.ElectrodeLabel = null;
            this.electrodeControl8.HardwareChannel = 0;
            this.electrodeControl8.Location = new System.Drawing.Point(297, 512);
            this.electrodeControl8.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl8.Name = "electrodeControl8";
            this.electrodeControl8.Number = 0;
            this.electrodeControl8.Selected = true;
            this.electrodeControl8.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl8.TabIndex = 8;
            // 
            // electrodeControl16
            // 
            this.electrodeControl16.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl16.ElectrodeLabel = null;
            this.electrodeControl16.HardwareChannel = 0;
            this.electrodeControl16.Location = new System.Drawing.Point(578, 238);
            this.electrodeControl16.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl16.Name = "electrodeControl16";
            this.electrodeControl16.Number = 0;
            this.electrodeControl16.Selected = true;
            this.electrodeControl16.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl16.TabIndex = 5;
            // 
            // electrodeControl28
            // 
            this.electrodeControl28.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl28.ElectrodeLabel = null;
            this.electrodeControl28.HardwareChannel = 0;
            this.electrodeControl28.Location = new System.Drawing.Point(215, 566);
            this.electrodeControl28.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl28.Name = "electrodeControl28";
            this.electrodeControl28.Number = 0;
            this.electrodeControl28.Selected = true;
            this.electrodeControl28.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl28.TabIndex = 23;
            // 
            // electrodeControl39
            // 
            this.electrodeControl39.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl39.ElectrodeLabel = null;
            this.electrodeControl39.HardwareChannel = 0;
            this.electrodeControl39.Location = new System.Drawing.Point(197, 202);
            this.electrodeControl39.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl39.Name = "electrodeControl39";
            this.electrodeControl39.Number = 0;
            this.electrodeControl39.Selected = true;
            this.electrodeControl39.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl39.TabIndex = 31;
            // 
            // electrodeControl21
            // 
            this.electrodeControl21.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl21.ElectrodeLabel = null;
            this.electrodeControl21.HardwareChannel = 0;
            this.electrodeControl21.Location = new System.Drawing.Point(158, 121);
            this.electrodeControl21.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl21.Name = "electrodeControl21";
            this.electrodeControl21.Number = 0;
            this.electrodeControl21.Selected = true;
            this.electrodeControl21.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl21.TabIndex = 17;
            // 
            // electrodeControl54
            // 
            this.electrodeControl54.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl54.ElectrodeLabel = null;
            this.electrodeControl54.HardwareChannel = 0;
            this.electrodeControl54.Location = new System.Drawing.Point(354, 389);
            this.electrodeControl54.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl54.Name = "electrodeControl54";
            this.electrodeControl54.Number = 0;
            this.electrodeControl54.Selected = true;
            this.electrodeControl54.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl54.TabIndex = 6;
            // 
            // electrodeControl61
            // 
            this.electrodeControl61.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl61.ElectrodeLabel = null;
            this.electrodeControl61.HardwareChannel = 0;
            this.electrodeControl61.Location = new System.Drawing.Point(394, 460);
            this.electrodeControl61.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl61.Name = "electrodeControl61";
            this.electrodeControl61.Number = 0;
            this.electrodeControl61.Selected = true;
            this.electrodeControl61.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl61.TabIndex = 6;
            // 
            // electrodeControl59
            // 
            this.electrodeControl59.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl59.ElectrodeLabel = null;
            this.electrodeControl59.HardwareChannel = 0;
            this.electrodeControl59.Location = new System.Drawing.Point(246, 455);
            this.electrodeControl59.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl59.Name = "electrodeControl59";
            this.electrodeControl59.Number = 0;
            this.electrodeControl59.Selected = true;
            this.electrodeControl59.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl59.TabIndex = 43;
            // 
            // electrodeControl50
            // 
            this.electrodeControl50.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl50.ElectrodeLabel = null;
            this.electrodeControl50.HardwareChannel = 0;
            this.electrodeControl50.Location = new System.Drawing.Point(470, 260);
            this.electrodeControl50.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl50.Name = "electrodeControl50";
            this.electrodeControl50.Number = 0;
            this.electrodeControl50.Selected = true;
            this.electrodeControl50.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl50.TabIndex = 38;
            // 
            // electrodeControl10
            // 
            this.electrodeControl10.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl10.ElectrodeLabel = null;
            this.electrodeControl10.HardwareChannel = 0;
            this.electrodeControl10.Location = new System.Drawing.Point(297, 630);
            this.electrodeControl10.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl10.Name = "electrodeControl10";
            this.electrodeControl10.Number = 0;
            this.electrodeControl10.Selected = true;
            this.electrodeControl10.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl10.TabIndex = 10;
            // 
            // electrodeControl7
            // 
            this.electrodeControl7.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl7.ElectrodeLabel = null;
            this.electrodeControl7.HardwareChannel = 0;
            this.electrodeControl7.Location = new System.Drawing.Point(295, 450);
            this.electrodeControl7.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl7.Name = "electrodeControl7";
            this.electrodeControl7.Number = 0;
            this.electrodeControl7.Selected = true;
            this.electrodeControl7.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl7.TabIndex = 7;
            // 
            // electrodeControl71
            // 
            this.electrodeControl71.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl71.ElectrodeLabel = null;
            this.electrodeControl71.HardwareChannel = 0;
            this.electrodeControl71.Location = new System.Drawing.Point(9, 43);
            this.electrodeControl71.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl71.Name = "electrodeControl71";
            this.electrodeControl71.Number = 0;
            this.electrodeControl71.Selected = true;
            this.electrodeControl71.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl71.TabIndex = 52;
            // 
            // electrodeControl3
            // 
            this.electrodeControl3.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl3.ElectrodeLabel = null;
            this.electrodeControl3.HardwareChannel = 0;
            this.electrodeControl3.Location = new System.Drawing.Point(297, 202);
            this.electrodeControl3.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl3.Name = "electrodeControl3";
            this.electrodeControl3.Number = 0;
            this.electrodeControl3.Selected = true;
            this.electrodeControl3.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl3.TabIndex = 3;
            // 
            // electrodeControl9
            // 
            this.electrodeControl9.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl9.ElectrodeLabel = null;
            this.electrodeControl9.HardwareChannel = 0;
            this.electrodeControl9.Location = new System.Drawing.Point(297, 574);
            this.electrodeControl9.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl9.Name = "electrodeControl9";
            this.electrodeControl9.Number = 0;
            this.electrodeControl9.Selected = true;
            this.electrodeControl9.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl9.TabIndex = 9;
            // 
            // electrodeControl17
            // 
            this.electrodeControl17.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl17.ElectrodeLabel = null;
            this.electrodeControl17.HardwareChannel = 0;
            this.electrodeControl17.Location = new System.Drawing.Point(482, 326);
            this.electrodeControl17.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl17.Name = "electrodeControl17";
            this.electrodeControl17.Number = 0;
            this.electrodeControl17.Selected = true;
            this.electrodeControl17.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl17.TabIndex = 5;
            // 
            // electrodeControl58
            // 
            this.electrodeControl58.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl58.ElectrodeLabel = null;
            this.electrodeControl58.HardwareChannel = 0;
            this.electrodeControl58.Location = new System.Drawing.Point(197, 460);
            this.electrodeControl58.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl58.Name = "electrodeControl58";
            this.electrodeControl58.Number = 0;
            this.electrodeControl58.Selected = true;
            this.electrodeControl58.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl58.TabIndex = 42;
            // 
            // electrodeControl32
            // 
            this.electrodeControl32.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl32.ElectrodeLabel = null;
            this.electrodeControl32.HardwareChannel = 0;
            this.electrodeControl32.Location = new System.Drawing.Point(528, 405);
            this.electrodeControl32.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl32.Name = "electrodeControl32";
            this.electrodeControl32.Number = 0;
            this.electrodeControl32.Selected = true;
            this.electrodeControl32.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl32.TabIndex = 27;
            // 
            // electrodeControl35
            // 
            this.electrodeControl35.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl35.ElectrodeLabel = null;
            this.electrodeControl35.HardwareChannel = 0;
            this.electrodeControl35.Location = new System.Drawing.Point(110, 326);
            this.electrodeControl35.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl35.Name = "electrodeControl35";
            this.electrodeControl35.Number = 0;
            this.electrodeControl35.Selected = true;
            this.electrodeControl35.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl35.TabIndex = 29;
            // 
            // electrodeControl43
            // 
            this.electrodeControl43.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl43.ElectrodeLabel = null;
            this.electrodeControl43.HardwareChannel = 0;
            this.electrodeControl43.Location = new System.Drawing.Point(397, 202);
            this.electrodeControl43.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl43.Name = "electrodeControl43";
            this.electrodeControl43.Number = 0;
            this.electrodeControl43.Selected = true;
            this.electrodeControl43.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl43.TabIndex = 34;
            // 
            // electrodeControl14
            // 
            this.electrodeControl14.BackColor = System.Drawing.Color.Transparent;
            this.electrodeControl14.ElectrodeLabel = null;
            this.electrodeControl14.HardwareChannel = 0;
            this.electrodeControl14.Location = new System.Drawing.Point(529, 252);
            this.electrodeControl14.Margin = new System.Windows.Forms.Padding(0);
            this.electrodeControl14.Name = "electrodeControl14";
            this.electrodeControl14.Number = 0;
            this.electrodeControl14.Selected = true;
            this.electrodeControl14.Size = new System.Drawing.Size(37, 55);
            this.electrodeControl14.TabIndex = 13;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 24);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape2,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(899, 662);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape2
            // 
            this.ovalShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ovalShape2.Location = new System.Drawing.Point(65, 74);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(500, 500);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 15;
            this.lineShape4.X2 = 615;
            this.lineShape4.Y1 = 324;
            this.lineShape4.Y2 = 324;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 315;
            this.lineShape3.X2 = 315;
            this.lineShape3.Y1 = 24;
            this.lineShape3.Y2 = 624;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 343;
            this.lineShape2.X2 = 313;
            this.lineShape2.Y1 = 25;
            this.lineShape2.Y2 = 4;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 283;
            this.lineShape1.X2 = 313;
            this.lineShape1.Y1 = 25;
            this.lineShape1.Y2 = 4;
            // 
            // ovalShape1
            // 
            this.ovalShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ovalShape1.BackColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Location = new System.Drawing.Point(15, 24);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(600, 600);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.colormapToolStripMenuItem,
            this.exceptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exceptionsToolStripMenuItem
            // 
            this.exceptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Joop,
            this.ChannelsView,
            this.DeselectItem});
            this.exceptionsToolStripMenuItem.Name = "exceptionsToolStripMenuItem";
            this.exceptionsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exceptionsToolStripMenuItem.Text = "Exceptions";
            // 
            // Joop
            // 
            this.Joop.Name = "Joop";
            this.Joop.Size = new System.Drawing.Size(195, 22);
            this.Joop.Text = "Joop Clots hack";
            this.Joop.Click += new System.EventHandler(this.JoopToolStripMenuItem_Click);
            // 
            // ChannelsView
            // 
            this.ChannelsView.Name = "ChannelsView";
            this.ChannelsView.Size = new System.Drawing.Size(195, 22);
            this.ChannelsView.Text = "View ChannelNumbers";
            this.ChannelsView.Click += new System.EventHandler(this.ChannelsViewToolStripMenuItem_Click);
            // 
            // DeselectItem
            // 
            this.DeselectItem.Name = "DeselectItem";
            this.DeselectItem.Size = new System.Drawing.Size(195, 22);
            this.DeselectItem.Text = "Deselect all";
            this.DeselectItem.Click += new System.EventHandler(this.DeselectItemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 708);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Charmeleon";
            this.auxBox.ResumeLayout(false);
            this.Legenda.ResumeLayout(false);
            this.Legenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox auxBox;
        private electrode.electrodeControl electrodeControl76;
        private electrode.electrodeControl electrodeControl77;
        private electrode.electrodeControl electrodeControl78;
        private electrode.electrodeControl electrodeControl75;
        private electrode.electrodeControl electrodeControl74;
        private electrode.electrodeControl electrodeControl73;
        private System.Windows.Forms.GroupBox Legenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LegLabel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape LegLine;
        private electrode.electrodeControl electrodeControl72;
        private electrode.electrodeControl electrodeControl71;
        private electrode.electrodeControl electrodeControl70;
        private electrode.electrodeControl electrodeControl69;
        private electrode.electrodeControl electrodeControl68;
        private electrode.electrodeControl electrodeControl67;
        private electrode.electrodeControl electrodeControl66;
        private electrode.electrodeControl electrodeControl65;
        private electrode.electrodeControl electrodeControl64;
        private electrode.electrodeControl electrodeControl63;
        private electrode.electrodeControl electrodeControl62;
        private electrode.electrodeControl electrodeControl61;
        private electrode.electrodeControl electrodeControl60;
        private electrode.electrodeControl electrodeControl59;
        private electrode.electrodeControl electrodeControl58;
        private electrode.electrodeControl electrodeControl56;
        private electrode.electrodeControl electrodeControl55;
        private electrode.electrodeControl electrodeControl54;
        private System.Windows.Forms.SaveFileDialog SaveHeadFileDialog;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colormapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog LoadHeadFileDialog;
        private electrode.electrodeControl electrodeControl57;
        private System.Windows.Forms.OpenFileDialog OpenColorMap;
        private electrode.electrodeControl electrodeControl53;
        private electrode.electrodeControl electrodeControl52;
        private electrode.electrodeControl electrodeControl51;
        private electrode.electrodeControl electrodeControl50;
        private electrode.electrodeControl electrodeControl49;
        private electrode.electrodeControl electrodeControl48;
        private electrode.electrodeControl electrodeControl47;
        private electrode.electrodeControl electrodeControl46;
        private electrode.electrodeControl electrodeControl45;
        private electrode.electrodeControl electrodeControl44;
        private electrode.electrodeControl electrodeControl43;
        private electrode.electrodeControl electrodeControl42;
        private electrode.electrodeControl electrodeControl41;
        private electrode.electrodeControl electrodeControl40;
        private electrode.electrodeControl electrodeControl39;
        private electrode.electrodeControl electrodeControl38;
        private electrode.electrodeControl electrodeControl37;
        private electrode.electrodeControl electrodeControl36;
        private electrode.electrodeControl electrodeControl35;
        private electrode.electrodeControl electrodeControl34;
        private electrode.electrodeControl electrodeControl33;
        private electrode.electrodeControl electrodeControl32;
        private electrode.electrodeControl electrodeControl31;
        private electrode.electrodeControl electrodeControl30;
        private electrode.electrodeControl electrodeControl29;
        private System.Windows.Forms.Panel panel1;
        private electrode.electrodeControl electrodeControl28;
        private electrode.electrodeControl electrodeControl27;
        private electrode.electrodeControl electrodeControl26;
        private electrode.electrodeControl electrodeControl25;
        private electrode.electrodeControl electrodeControl24;
        private electrode.electrodeControl electrodeControl23;
        private electrode.electrodeControl electrodeControl22;
        private electrode.electrodeControl electrodeControl21;
        private electrode.electrodeControl electrodeControl20;
        private electrode.electrodeControl electrodeControl19;
        private electrode.electrodeControl electrodeControl18;
        private electrode.electrodeControl electrodeControl17;
        private electrode.electrodeControl electrodeControl16;
        private electrode.electrodeControl electrodeControl15;
        private electrode.electrodeControl electrodeControl14;
        private electrode.electrodeControl electrodeControl13;
        private electrode.electrodeControl electrodeControl12;
        private electrode.electrodeControl electrodeControl11;
        private electrode.electrodeControl electrodeControl10;
        private electrode.electrodeControl electrodeControl9;
        private electrode.electrodeControl electrodeControl8;
        private electrode.electrodeControl electrodeControl7;
        private electrode.electrodeControl electrodeControl6;
        private electrode.electrodeControl electrodeControl5;
        private electrode.electrodeControl electrodeControl4;
        private electrode.electrodeControl electrodeControl3;
        private electrode.electrodeControl electrodeControl2;
        private electrode.electrodeControl electrodeControl1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exceptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Joop;
        private System.Windows.Forms.ToolStripMenuItem DeselectItem;
        private System.Windows.Forms.ToolStripMenuItem ChannelsView;

    }
}