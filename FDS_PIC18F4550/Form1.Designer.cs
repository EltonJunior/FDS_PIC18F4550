﻿
namespace FDS_PIC18F4550
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbADC = new System.Windows.Forms.GroupBox();
            this.btnAD1_media = new System.Windows.Forms.Button();
            this.btnAD1_instante = new System.Windows.Forms.Button();
            this.btnAD0_media = new System.Windows.Forms.Button();
            this.btnAD0_instante = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AD1_InstGauge = new System.Windows.Forms.AGauge();
            this.AD0_InstGauge = new System.Windows.Forms.AGauge();
            this.AD1_MediaGauge = new System.Windows.Forms.AGauge();
            this.AD0_MediaGauge = new System.Windows.Forms.AGauge();
            this.gbLEDs = new System.Windows.Forms.GroupBox();
            this.LED7 = new System.Windows.Forms.CheckBox();
            this.LED6 = new System.Windows.Forms.CheckBox();
            this.LED5 = new System.Windows.Forms.CheckBox();
            this.LED4 = new System.Windows.Forms.CheckBox();
            this.LED3 = new System.Windows.Forms.CheckBox();
            this.LED2 = new System.Windows.Forms.CheckBox();
            this.LED1 = new System.Windows.Forms.CheckBox();
            this.LED0 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstCOMPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbEEPROM = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.gbADC.SuspendLayout();
            this.gbLEDs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEEPROM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbADC
            // 
            this.gbADC.Controls.Add(this.btnAD1_media);
            this.gbADC.Controls.Add(this.btnAD1_instante);
            this.gbADC.Controls.Add(this.btnAD0_media);
            this.gbADC.Controls.Add(this.btnAD0_instante);
            this.gbADC.Controls.Add(this.label6);
            this.gbADC.Controls.Add(this.label8);
            this.gbADC.Controls.Add(this.label7);
            this.gbADC.Controls.Add(this.label5);
            this.gbADC.Controls.Add(this.AD1_MediaGauge);
            this.gbADC.Controls.Add(this.AD1_InstGauge);
            this.gbADC.Controls.Add(this.AD0_InstGauge);
            this.gbADC.Controls.Add(this.AD0_MediaGauge);
            this.gbADC.Enabled = false;
            this.gbADC.Location = new System.Drawing.Point(7, 58);
            this.gbADC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbADC.Name = "gbADC";
            this.gbADC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbADC.Size = new System.Drawing.Size(458, 405);
            this.gbADC.TabIndex = 3;
            this.gbADC.TabStop = false;
            this.gbADC.Text = "ADC";
            // 
            // btnAD1_media
            // 
            this.btnAD1_media.Location = new System.Drawing.Point(313, 179);
            this.btnAD1_media.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAD1_media.Name = "btnAD1_media";
            this.btnAD1_media.Size = new System.Drawing.Size(56, 19);
            this.btnAD1_media.TabIndex = 9;
            this.btnAD1_media.Text = "AD1";
            this.btnAD1_media.UseVisualStyleBackColor = true;
            this.btnAD1_media.Click += new System.EventHandler(this.btnAD1_media_Click);
            // 
            // btnAD1_instante
            // 
            this.btnAD1_instante.Location = new System.Drawing.Point(313, 375);
            this.btnAD1_instante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAD1_instante.Name = "btnAD1_instante";
            this.btnAD1_instante.Size = new System.Drawing.Size(56, 19);
            this.btnAD1_instante.TabIndex = 9;
            this.btnAD1_instante.Text = "AD1";
            this.btnAD1_instante.UseVisualStyleBackColor = true;
            this.btnAD1_instante.Click += new System.EventHandler(this.btnAD1_instante_Click);
            // 
            // btnAD0_media
            // 
            this.btnAD0_media.Location = new System.Drawing.Point(87, 179);
            this.btnAD0_media.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAD0_media.Name = "btnAD0_media";
            this.btnAD0_media.Size = new System.Drawing.Size(56, 19);
            this.btnAD0_media.TabIndex = 9;
            this.btnAD0_media.Text = "AD0";
            this.btnAD0_media.UseVisualStyleBackColor = true;
            this.btnAD0_media.Click += new System.EventHandler(this.btnAD0_media_Click);
            // 
            // btnAD0_instante
            // 
            this.btnAD0_instante.Location = new System.Drawing.Point(87, 375);
            this.btnAD0_instante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAD0_instante.Name = "btnAD0_instante";
            this.btnAD0_instante.Size = new System.Drawing.Size(56, 19);
            this.btnAD0_instante.TabIndex = 9;
            this.btnAD0_instante.Text = "AD0";
            this.btnAD0_instante.UseVisualStyleBackColor = true;
            this.btnAD0_instante.Click += new System.EventHandler(this.btnAD0_instante_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(323, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Médio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(310, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Instantaneo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(97, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Médio";
            // 
            // AD1_InstGauge
            // 
            this.AD1_InstGauge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AD1_InstGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.AD1_InstGauge.BaseArcRadius = 80;
            this.AD1_InstGauge.BaseArcStart = 135;
            this.AD1_InstGauge.BaseArcSweep = 270;
            this.AD1_InstGauge.BaseArcWidth = 2;
            this.AD1_InstGauge.Center = new System.Drawing.Point(110, 110);
            this.AD1_InstGauge.GaugeAutoSize = false;
            this.AD1_InstGauge.Location = new System.Drawing.Point(231, 209);
            this.AD1_InstGauge.MaxValue = 1100F;
            this.AD1_InstGauge.MinValue = 0F;
            this.AD1_InstGauge.Name = "AD1_InstGauge";
            this.AD1_InstGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.AD1_InstGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.AD1_InstGauge.NeedleRadius = 80;
            this.AD1_InstGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.AD1_InstGauge.NeedleWidth = 2;
            this.AD1_InstGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.AD1_InstGauge.ScaleLinesInterInnerRadius = 73;
            this.AD1_InstGauge.ScaleLinesInterOuterRadius = 80;
            this.AD1_InstGauge.ScaleLinesInterWidth = 1;
            this.AD1_InstGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.AD1_InstGauge.ScaleLinesMajorInnerRadius = 70;
            this.AD1_InstGauge.ScaleLinesMajorOuterRadius = 80;
            this.AD1_InstGauge.ScaleLinesMajorStepValue = 50F;
            this.AD1_InstGauge.ScaleLinesMajorWidth = 2;
            this.AD1_InstGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.AD1_InstGauge.ScaleLinesMinorInnerRadius = 75;
            this.AD1_InstGauge.ScaleLinesMinorOuterRadius = 80;
            this.AD1_InstGauge.ScaleLinesMinorTicks = 9;
            this.AD1_InstGauge.ScaleLinesMinorWidth = 1;
            this.AD1_InstGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.AD1_InstGauge.ScaleNumbersFormat = null;
            this.AD1_InstGauge.ScaleNumbersRadius = 95;
            this.AD1_InstGauge.ScaleNumbersRotation = 0;
            this.AD1_InstGauge.ScaleNumbersStartScaleLine = 0;
            this.AD1_InstGauge.ScaleNumbersStepScaleLines = 1;
            this.AD1_InstGauge.Size = new System.Drawing.Size(220, 190);
            this.AD1_InstGauge.TabIndex = 7;
            this.AD1_InstGauge.Text = "AD1_InstGauge";
            this.AD1_InstGauge.Value = 0F;
            // 
            // AD0_InstGauge
            // 
            this.AD0_InstGauge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AD0_InstGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.AD0_InstGauge.BaseArcRadius = 80;
            this.AD0_InstGauge.BaseArcStart = 135;
            this.AD0_InstGauge.BaseArcSweep = 270;
            this.AD0_InstGauge.BaseArcWidth = 2;
            this.AD0_InstGauge.Center = new System.Drawing.Point(110, 110);
            this.AD0_InstGauge.GaugeAutoSize = false;
            this.AD0_InstGauge.Location = new System.Drawing.Point(5, 209);
            this.AD0_InstGauge.MaxValue = 1100F;
            this.AD0_InstGauge.MinValue = 0F;
            this.AD0_InstGauge.Name = "AD0_InstGauge";
            this.AD0_InstGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.AD0_InstGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.AD0_InstGauge.NeedleRadius = 80;
            this.AD0_InstGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.AD0_InstGauge.NeedleWidth = 2;
            this.AD0_InstGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.AD0_InstGauge.ScaleLinesInterInnerRadius = 73;
            this.AD0_InstGauge.ScaleLinesInterOuterRadius = 80;
            this.AD0_InstGauge.ScaleLinesInterWidth = 1;
            this.AD0_InstGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.AD0_InstGauge.ScaleLinesMajorInnerRadius = 70;
            this.AD0_InstGauge.ScaleLinesMajorOuterRadius = 80;
            this.AD0_InstGauge.ScaleLinesMajorStepValue = 50F;
            this.AD0_InstGauge.ScaleLinesMajorWidth = 2;
            this.AD0_InstGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.AD0_InstGauge.ScaleLinesMinorInnerRadius = 75;
            this.AD0_InstGauge.ScaleLinesMinorOuterRadius = 80;
            this.AD0_InstGauge.ScaleLinesMinorTicks = 9;
            this.AD0_InstGauge.ScaleLinesMinorWidth = 1;
            this.AD0_InstGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.AD0_InstGauge.ScaleNumbersFormat = null;
            this.AD0_InstGauge.ScaleNumbersRadius = 95;
            this.AD0_InstGauge.ScaleNumbersRotation = 0;
            this.AD0_InstGauge.ScaleNumbersStartScaleLine = 0;
            this.AD0_InstGauge.ScaleNumbersStepScaleLines = 1;
            this.AD0_InstGauge.Size = new System.Drawing.Size(220, 190);
            this.AD0_InstGauge.TabIndex = 7;
            this.AD0_InstGauge.Text = "AD0_InstGauge";
            this.AD0_InstGauge.Value = 0F;
            // 
            // AD1_MediaGauge
            // 
            this.AD1_MediaGauge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AD1_MediaGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.AD1_MediaGauge.BaseArcRadius = 80;
            this.AD1_MediaGauge.BaseArcStart = 135;
            this.AD1_MediaGauge.BaseArcSweep = 270;
            this.AD1_MediaGauge.BaseArcWidth = 2;
            this.AD1_MediaGauge.Center = new System.Drawing.Point(110, 110);
            this.AD1_MediaGauge.GaugeAutoSize = false;
            this.AD1_MediaGauge.Location = new System.Drawing.Point(231, 13);
            this.AD1_MediaGauge.MaxValue = 1100F;
            this.AD1_MediaGauge.MinValue = 0F;
            this.AD1_MediaGauge.Name = "AD1_MediaGauge";
            this.AD1_MediaGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.AD1_MediaGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.AD1_MediaGauge.NeedleRadius = 80;
            this.AD1_MediaGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.AD1_MediaGauge.NeedleWidth = 2;
            this.AD1_MediaGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.AD1_MediaGauge.ScaleLinesInterInnerRadius = 73;
            this.AD1_MediaGauge.ScaleLinesInterOuterRadius = 80;
            this.AD1_MediaGauge.ScaleLinesInterWidth = 1;
            this.AD1_MediaGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.AD1_MediaGauge.ScaleLinesMajorInnerRadius = 70;
            this.AD1_MediaGauge.ScaleLinesMajorOuterRadius = 80;
            this.AD1_MediaGauge.ScaleLinesMajorStepValue = 50F;
            this.AD1_MediaGauge.ScaleLinesMajorWidth = 2;
            this.AD1_MediaGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.AD1_MediaGauge.ScaleLinesMinorInnerRadius = 75;
            this.AD1_MediaGauge.ScaleLinesMinorOuterRadius = 80;
            this.AD1_MediaGauge.ScaleLinesMinorTicks = 9;
            this.AD1_MediaGauge.ScaleLinesMinorWidth = 1;
            this.AD1_MediaGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.AD1_MediaGauge.ScaleNumbersFormat = null;
            this.AD1_MediaGauge.ScaleNumbersRadius = 95;
            this.AD1_MediaGauge.ScaleNumbersRotation = 0;
            this.AD1_MediaGauge.ScaleNumbersStartScaleLine = 0;
            this.AD1_MediaGauge.ScaleNumbersStepScaleLines = 1;
            this.AD1_MediaGauge.Size = new System.Drawing.Size(220, 190);
            this.AD1_MediaGauge.TabIndex = 7;
            this.AD1_MediaGauge.Text = "AD1_MediaGauge";
            this.AD1_MediaGauge.Value = 0F;
            // 
            // AD0_MediaGauge
            // 
            this.AD0_MediaGauge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AD0_MediaGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.AD0_MediaGauge.BaseArcRadius = 80;
            this.AD0_MediaGauge.BaseArcStart = 135;
            this.AD0_MediaGauge.BaseArcSweep = 270;
            this.AD0_MediaGauge.BaseArcWidth = 2;
            this.AD0_MediaGauge.Center = new System.Drawing.Point(110, 110);
            this.AD0_MediaGauge.GaugeAutoSize = false;
            this.AD0_MediaGauge.Location = new System.Drawing.Point(5, 13);
            this.AD0_MediaGauge.MaxValue = 1100F;
            this.AD0_MediaGauge.MinValue = 0F;
            this.AD0_MediaGauge.Name = "AD0_MediaGauge";
            this.AD0_MediaGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.AD0_MediaGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.AD0_MediaGauge.NeedleRadius = 80;
            this.AD0_MediaGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.AD0_MediaGauge.NeedleWidth = 2;
            this.AD0_MediaGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.AD0_MediaGauge.ScaleLinesInterInnerRadius = 73;
            this.AD0_MediaGauge.ScaleLinesInterOuterRadius = 80;
            this.AD0_MediaGauge.ScaleLinesInterWidth = 1;
            this.AD0_MediaGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.AD0_MediaGauge.ScaleLinesMajorInnerRadius = 70;
            this.AD0_MediaGauge.ScaleLinesMajorOuterRadius = 80;
            this.AD0_MediaGauge.ScaleLinesMajorStepValue = 50F;
            this.AD0_MediaGauge.ScaleLinesMajorWidth = 2;
            this.AD0_MediaGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.AD0_MediaGauge.ScaleLinesMinorInnerRadius = 75;
            this.AD0_MediaGauge.ScaleLinesMinorOuterRadius = 80;
            this.AD0_MediaGauge.ScaleLinesMinorTicks = 9;
            this.AD0_MediaGauge.ScaleLinesMinorWidth = 1;
            this.AD0_MediaGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.AD0_MediaGauge.ScaleNumbersFormat = null;
            this.AD0_MediaGauge.ScaleNumbersRadius = 95;
            this.AD0_MediaGauge.ScaleNumbersRotation = 0;
            this.AD0_MediaGauge.ScaleNumbersStartScaleLine = 0;
            this.AD0_MediaGauge.ScaleNumbersStepScaleLines = 1;
            this.AD0_MediaGauge.Size = new System.Drawing.Size(220, 190);
            this.AD0_MediaGauge.TabIndex = 7;
            this.AD0_MediaGauge.Text = "AD0_MediaGauge";
            this.AD0_MediaGauge.Value = 0F;
            // 
            // gbLEDs
            // 
            this.gbLEDs.Controls.Add(this.LED7);
            this.gbLEDs.Controls.Add(this.LED6);
            this.gbLEDs.Controls.Add(this.LED5);
            this.gbLEDs.Controls.Add(this.LED4);
            this.gbLEDs.Controls.Add(this.LED3);
            this.gbLEDs.Controls.Add(this.LED2);
            this.gbLEDs.Controls.Add(this.LED1);
            this.gbLEDs.Controls.Add(this.LED0);
            this.gbLEDs.Enabled = false;
            this.gbLEDs.Location = new System.Drawing.Point(469, 58);
            this.gbLEDs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLEDs.Name = "gbLEDs";
            this.gbLEDs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLEDs.Size = new System.Drawing.Size(109, 405);
            this.gbLEDs.TabIndex = 4;
            this.gbLEDs.TabStop = false;
            this.gbLEDs.Text = "LEDs";
            // 
            // LED7
            // 
            this.LED7.AutoSize = true;
            this.LED7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED7.Location = new System.Drawing.Point(15, 343);
            this.LED7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(85, 29);
            this.LED7.TabIndex = 0;
            this.LED7.Text = "LED 7";
            this.LED7.UseVisualStyleBackColor = true;
            // 
            // LED6
            // 
            this.LED6.AutoSize = true;
            this.LED6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED6.Location = new System.Drawing.Point(15, 299);
            this.LED6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(85, 29);
            this.LED6.TabIndex = 0;
            this.LED6.Text = "LED 6";
            this.LED6.UseVisualStyleBackColor = true;
            // 
            // LED5
            // 
            this.LED5.AutoSize = true;
            this.LED5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED5.Location = new System.Drawing.Point(15, 255);
            this.LED5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(85, 29);
            this.LED5.TabIndex = 0;
            this.LED5.Text = "LED 5";
            this.LED5.UseVisualStyleBackColor = true;
            // 
            // LED4
            // 
            this.LED4.AutoSize = true;
            this.LED4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED4.Location = new System.Drawing.Point(15, 211);
            this.LED4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(85, 29);
            this.LED4.TabIndex = 0;
            this.LED4.Text = "LED 4";
            this.LED4.UseVisualStyleBackColor = true;
            // 
            // LED3
            // 
            this.LED3.AutoSize = true;
            this.LED3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED3.Location = new System.Drawing.Point(15, 167);
            this.LED3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(85, 29);
            this.LED3.TabIndex = 0;
            this.LED3.Text = "LED 3";
            this.LED3.UseVisualStyleBackColor = true;
            // 
            // LED2
            // 
            this.LED2.AutoSize = true;
            this.LED2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED2.Location = new System.Drawing.Point(15, 123);
            this.LED2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(85, 29);
            this.LED2.TabIndex = 0;
            this.LED2.Text = "LED 2";
            this.LED2.UseVisualStyleBackColor = true;
            // 
            // LED1
            // 
            this.LED1.AutoSize = true;
            this.LED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED1.Location = new System.Drawing.Point(15, 79);
            this.LED1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(85, 29);
            this.LED1.TabIndex = 0;
            this.LED1.Text = "LED 1";
            this.LED1.UseVisualStyleBackColor = true;
            // 
            // LED0
            // 
            this.LED0.AutoSize = true;
            this.LED0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LED0.Location = new System.Drawing.Point(15, 35);
            this.LED0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LED0.Name = "LED0";
            this.LED0.Size = new System.Drawing.Size(85, 29);
            this.LED0.TabIndex = 0;
            this.LED0.Text = "LED 0";
            this.LED0.UseVisualStyleBackColor = true;
            this.LED0.CheckedChanged += new System.EventHandler(this.LED0_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstCOMPorts);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(571, 48);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PORTA USB";
            // 
            // lstCOMPorts
            // 
            this.lstCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstCOMPorts.FormattingEnabled = true;
            this.lstCOMPorts.Location = new System.Drawing.Point(13, 16);
            this.lstCOMPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCOMPorts.Name = "lstCOMPorts";
            this.lstCOMPorts.Size = new System.Drawing.Size(138, 24);
            this.lstCOMPorts.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(454, 16);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 24);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECTAR";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbEEPROM
            // 
            this.gbEEPROM.Controls.Add(this.label4);
            this.gbEEPROM.Controls.Add(this.label2);
            this.gbEEPROM.Controls.Add(this.label3);
            this.gbEEPROM.Controls.Add(this.label1);
            this.gbEEPROM.Controls.Add(this.txtReadData);
            this.gbEEPROM.Controls.Add(this.numericUpDown2);
            this.gbEEPROM.Controls.Add(this.btnRead);
            this.gbEEPROM.Controls.Add(this.btnWrite);
            this.gbEEPROM.Controls.Add(this.numericUpDown3);
            this.gbEEPROM.Controls.Add(this.numericUpDown1);
            this.gbEEPROM.Enabled = false;
            this.gbEEPROM.Location = new System.Drawing.Point(7, 464);
            this.gbEEPROM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEEPROM.Name = "gbEEPROM";
            this.gbEEPROM.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEEPROM.Size = new System.Drawing.Size(571, 75);
            this.gbEEPROM.TabIndex = 6;
            this.gbEEPROM.TabStop = false;
            this.gbEEPROM.Text = "EEPROM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // txtReadData
            // 
            this.txtReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtReadData.Location = new System.Drawing.Point(380, 31);
            this.txtReadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReadData.MaxLength = 255;
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.ReadOnly = true;
            this.txtReadData.Size = new System.Drawing.Size(82, 30);
            this.txtReadData.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown2.Hexadecimal = true;
            this.numericUpDown2.Location = new System.Drawing.Point(78, 31);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 30);
            this.numericUpDown2.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(472, 29);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(90, 35);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "LEITURA";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(144, 29);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(90, 35);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "ESCREVER";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown3.Hexadecimal = true;
            this.numericUpDown3.Location = new System.Drawing.Point(323, 31);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(49, 30);
            this.numericUpDown3.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 31);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 30);
            this.numericUpDown1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(84, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Instantaneo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 546);
            this.Controls.Add(this.gbEEPROM);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbLEDs);
            this.Controls.Add(this.gbADC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FDS PIC18F4550";
            this.gbADC.ResumeLayout(false);
            this.gbADC.PerformLayout();
            this.gbLEDs.ResumeLayout(false);
            this.gbLEDs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbEEPROM.ResumeLayout(false);
            this.gbEEPROM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbADC;
        private System.Windows.Forms.GroupBox gbLEDs;
        private System.Windows.Forms.CheckBox LED7;
        private System.Windows.Forms.CheckBox LED6;
        private System.Windows.Forms.CheckBox LED5;
        private System.Windows.Forms.CheckBox LED4;
        private System.Windows.Forms.CheckBox LED3;
        private System.Windows.Forms.CheckBox LED2;
        private System.Windows.Forms.CheckBox LED1;
        private System.Windows.Forms.CheckBox LED0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox lstCOMPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbEEPROM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.AGauge AD0_MediaGauge;
        private System.Windows.Forms.AGauge AD1_InstGauge;
        private System.Windows.Forms.AGauge AD0_InstGauge;
        private System.Windows.Forms.AGauge AD1_MediaGauge;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAD0_instante;
        private System.Windows.Forms.Button btnAD1_instante;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.Button btnAD1_media;
        private System.Windows.Forms.Button btnAD0_media;
        private System.Windows.Forms.Label label6;
    }
}

