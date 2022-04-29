
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
            this.lbAD1_MediaGauge = new System.Windows.Forms.Label();
            this.btnAD1_media = new System.Windows.Forms.Button();
            this.btnAD1_instante = new System.Windows.Forms.Button();
            this.btnAD0_media = new System.Windows.Forms.Button();
            this.btnAD0_instante = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.gbSwiths = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStatusSW5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStatusSW4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStatusSW3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStatusSW2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnStatusSW6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnStatusSW8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnStatusSW7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStatusSW1 = new System.Windows.Forms.Button();
            this.btnReadSwitchs = new System.Windows.Forms.Button();
            this.AD1_InstGauge = new System.Windows.Forms.AGauge();
            this.AD0_InstGauge = new System.Windows.Forms.AGauge();
            this.AD0_MediaGauge = new System.Windows.Forms.AGauge();
            this.AD1_MediaGauge = new System.Windows.Forms.AGauge();
            this.lbAD0_MediaGauge = new System.Windows.Forms.Label();
            this.lbAD1_InstaGauge = new System.Windows.Forms.Label();
            this.lbAD0_InstaGauge = new System.Windows.Forms.Label();
            this.gbADC.SuspendLayout();
            this.gbLEDs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEEPROM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbSwiths.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbADC
            // 
            this.gbADC.Controls.Add(this.lbAD0_InstaGauge);
            this.gbADC.Controls.Add(this.lbAD0_MediaGauge);
            this.gbADC.Controls.Add(this.lbAD1_InstaGauge);
            this.gbADC.Controls.Add(this.lbAD1_MediaGauge);
            this.gbADC.Controls.Add(this.btnAD1_media);
            this.gbADC.Controls.Add(this.btnAD1_instante);
            this.gbADC.Controls.Add(this.btnAD0_media);
            this.gbADC.Controls.Add(this.btnAD0_instante);
            this.gbADC.Controls.Add(this.label6);
            this.gbADC.Controls.Add(this.label8);
            this.gbADC.Controls.Add(this.label7);
            this.gbADC.Controls.Add(this.label5);
            this.gbADC.Controls.Add(this.AD1_InstGauge);
            this.gbADC.Controls.Add(this.AD0_InstGauge);
            this.gbADC.Controls.Add(this.AD0_MediaGauge);
            this.gbADC.Controls.Add(this.AD1_MediaGauge);
            this.gbADC.Enabled = false;
            this.gbADC.Location = new System.Drawing.Point(7, 58);
            this.gbADC.Margin = new System.Windows.Forms.Padding(2);
            this.gbADC.Name = "gbADC";
            this.gbADC.Padding = new System.Windows.Forms.Padding(2);
            this.gbADC.Size = new System.Drawing.Size(458, 405);
            this.gbADC.TabIndex = 3;
            this.gbADC.TabStop = false;
            this.gbADC.Text = "ADC";
            // 
            // lbAD1_MediaGauge
            // 
            this.lbAD1_MediaGauge.AutoSize = true;
            this.lbAD1_MediaGauge.Location = new System.Drawing.Point(237, 18);
            this.lbAD1_MediaGauge.Name = "lbAD1_MediaGauge";
            this.lbAD1_MediaGauge.Size = new System.Drawing.Size(35, 13);
            this.lbAD1_MediaGauge.TabIndex = 10;
            this.lbAD1_MediaGauge.Tag = "";
            this.lbAD1_MediaGauge.Text = "XXXX";
            // 
            // btnAD1_media
            // 
            this.btnAD1_media.Location = new System.Drawing.Point(313, 179);
            this.btnAD1_media.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnAD1_instante.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnAD0_media.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnAD0_instante.Margin = new System.Windows.Forms.Padding(2);
            this.btnAD0_instante.Name = "btnAD0_instante";
            this.btnAD0_instante.Size = new System.Drawing.Size(56, 19);
            this.btnAD0_instante.TabIndex = 9;
            this.btnAD0_instante.Text = "AD0";
            this.btnAD0_instante.UseVisualStyleBackColor = true;
            this.btnAD0_instante.Click += new System.EventHandler(this.btnAD0_instante_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(84, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Instantaneo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(323, 161);
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
            this.label7.Location = new System.Drawing.Point(310, 357);
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
            this.label5.Location = new System.Drawing.Point(97, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Médio";
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
            this.gbLEDs.Margin = new System.Windows.Forms.Padding(2);
            this.gbLEDs.Name = "gbLEDs";
            this.gbLEDs.Padding = new System.Windows.Forms.Padding(2);
            this.gbLEDs.Size = new System.Drawing.Size(109, 214);
            this.gbLEDs.TabIndex = 4;
            this.gbLEDs.TabStop = false;
            this.gbLEDs.Text = "LEDs";
            // 
            // LED7
            // 
            this.LED7.AutoSize = true;
            this.LED7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED7.Location = new System.Drawing.Point(18, 185);
            this.LED7.Margin = new System.Windows.Forms.Padding(2);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(73, 24);
            this.LED7.TabIndex = 0;
            this.LED7.Text = "LED 7";
            this.LED7.UseVisualStyleBackColor = true;
            // 
            // LED6
            // 
            this.LED6.AutoSize = true;
            this.LED6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED6.Location = new System.Drawing.Point(18, 161);
            this.LED6.Margin = new System.Windows.Forms.Padding(2);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(73, 24);
            this.LED6.TabIndex = 0;
            this.LED6.Text = "LED 6";
            this.LED6.UseVisualStyleBackColor = true;
            // 
            // LED5
            // 
            this.LED5.AutoSize = true;
            this.LED5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED5.Location = new System.Drawing.Point(18, 137);
            this.LED5.Margin = new System.Windows.Forms.Padding(2);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(73, 24);
            this.LED5.TabIndex = 0;
            this.LED5.Text = "LED 5";
            this.LED5.UseVisualStyleBackColor = true;
            // 
            // LED4
            // 
            this.LED4.AutoSize = true;
            this.LED4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED4.Location = new System.Drawing.Point(18, 113);
            this.LED4.Margin = new System.Windows.Forms.Padding(2);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(73, 24);
            this.LED4.TabIndex = 0;
            this.LED4.Text = "LED 4";
            this.LED4.UseVisualStyleBackColor = true;
            // 
            // LED3
            // 
            this.LED3.AutoSize = true;
            this.LED3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED3.Location = new System.Drawing.Point(18, 89);
            this.LED3.Margin = new System.Windows.Forms.Padding(2);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(73, 24);
            this.LED3.TabIndex = 0;
            this.LED3.Text = "LED 3";
            this.LED3.UseVisualStyleBackColor = true;
            // 
            // LED2
            // 
            this.LED2.AutoSize = true;
            this.LED2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED2.Location = new System.Drawing.Point(18, 65);
            this.LED2.Margin = new System.Windows.Forms.Padding(2);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(73, 24);
            this.LED2.TabIndex = 0;
            this.LED2.Text = "LED 2";
            this.LED2.UseVisualStyleBackColor = true;
            // 
            // LED1
            // 
            this.LED1.AutoSize = true;
            this.LED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED1.Location = new System.Drawing.Point(18, 41);
            this.LED1.Margin = new System.Windows.Forms.Padding(2);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(73, 24);
            this.LED1.TabIndex = 0;
            this.LED1.Text = "LED 1";
            this.LED1.UseVisualStyleBackColor = true;
            // 
            // LED0
            // 
            this.LED0.AutoSize = true;
            this.LED0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LED0.Location = new System.Drawing.Point(18, 17);
            this.LED0.Margin = new System.Windows.Forms.Padding(2);
            this.LED0.Name = "LED0";
            this.LED0.Size = new System.Drawing.Size(73, 24);
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
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
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
            this.lstCOMPorts.Margin = new System.Windows.Forms.Padding(2);
            this.lstCOMPorts.Name = "lstCOMPorts";
            this.lstCOMPorts.Size = new System.Drawing.Size(138, 24);
            this.lstCOMPorts.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(454, 16);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
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
            this.gbEEPROM.Margin = new System.Windows.Forms.Padding(2);
            this.gbEEPROM.Name = "gbEEPROM";
            this.gbEEPROM.Padding = new System.Windows.Forms.Padding(2);
            this.gbEEPROM.Size = new System.Drawing.Size(458, 75);
            this.gbEEPROM.TabIndex = 6;
            this.gbEEPROM.TabStop = false;
            this.gbEEPROM.Text = "EEPROM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // txtReadData
            // 
            this.txtReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtReadData.Location = new System.Drawing.Point(297, 31);
            this.txtReadData.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadData.MaxLength = 255;
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.ReadOnly = true;
            this.txtReadData.Size = new System.Drawing.Size(55, 30);
            this.txtReadData.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown2.Hexadecimal = true;
            this.numericUpDown2.Location = new System.Drawing.Point(61, 31);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnRead.Location = new System.Drawing.Point(357, 31);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(90, 30);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "LEITURA";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(115, 31);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(90, 30);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "ESCREVER";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown3.Hexadecimal = true;
            this.numericUpDown3.Location = new System.Drawing.Point(243, 31);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDown1.Location = new System.Drawing.Point(7, 31);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
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
            // gbSwiths
            // 
            this.gbSwiths.Controls.Add(this.label13);
            this.gbSwiths.Controls.Add(this.btnStatusSW5);
            this.gbSwiths.Controls.Add(this.label12);
            this.gbSwiths.Controls.Add(this.btnStatusSW4);
            this.gbSwiths.Controls.Add(this.label11);
            this.gbSwiths.Controls.Add(this.btnStatusSW3);
            this.gbSwiths.Controls.Add(this.label10);
            this.gbSwiths.Controls.Add(this.btnStatusSW2);
            this.gbSwiths.Controls.Add(this.label14);
            this.gbSwiths.Controls.Add(this.btnStatusSW6);
            this.gbSwiths.Controls.Add(this.label16);
            this.gbSwiths.Controls.Add(this.btnStatusSW8);
            this.gbSwiths.Controls.Add(this.label15);
            this.gbSwiths.Controls.Add(this.btnStatusSW7);
            this.gbSwiths.Controls.Add(this.label9);
            this.gbSwiths.Controls.Add(this.btnStatusSW1);
            this.gbSwiths.Controls.Add(this.btnReadSwitchs);
            this.gbSwiths.Enabled = false;
            this.gbSwiths.Location = new System.Drawing.Point(469, 275);
            this.gbSwiths.Margin = new System.Windows.Forms.Padding(2);
            this.gbSwiths.Name = "gbSwiths";
            this.gbSwiths.Padding = new System.Windows.Forms.Padding(2);
            this.gbSwiths.Size = new System.Drawing.Size(109, 264);
            this.gbSwiths.TabIndex = 4;
            this.gbSwiths.TabStop = false;
            this.gbSwiths.Text = "SWITCHs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(51, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "SW 5";
            // 
            // btnStatusSW5
            // 
            this.btnStatusSW5.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW5.Enabled = false;
            this.btnStatusSW5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW5.Location = new System.Drawing.Point(7, 116);
            this.btnStatusSW5.Name = "btnStatusSW5";
            this.btnStatusSW5.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW5.TabIndex = 1;
            this.btnStatusSW5.Text = "OFF";
            this.btnStatusSW5.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(51, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "SW 4";
            // 
            // btnStatusSW4
            // 
            this.btnStatusSW4.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW4.Enabled = false;
            this.btnStatusSW4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW4.Location = new System.Drawing.Point(7, 91);
            this.btnStatusSW4.Name = "btnStatusSW4";
            this.btnStatusSW4.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW4.TabIndex = 1;
            this.btnStatusSW4.Text = "OFF";
            this.btnStatusSW4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(51, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "SW 3";
            // 
            // btnStatusSW3
            // 
            this.btnStatusSW3.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW3.Enabled = false;
            this.btnStatusSW3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW3.Location = new System.Drawing.Point(7, 66);
            this.btnStatusSW3.Name = "btnStatusSW3";
            this.btnStatusSW3.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW3.TabIndex = 1;
            this.btnStatusSW3.Text = "OFF";
            this.btnStatusSW3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(51, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "SW 2";
            // 
            // btnStatusSW2
            // 
            this.btnStatusSW2.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW2.Enabled = false;
            this.btnStatusSW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW2.Location = new System.Drawing.Point(7, 41);
            this.btnStatusSW2.Name = "btnStatusSW2";
            this.btnStatusSW2.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW2.TabIndex = 1;
            this.btnStatusSW2.Text = "OFF";
            this.btnStatusSW2.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(51, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "SW 6";
            // 
            // btnStatusSW6
            // 
            this.btnStatusSW6.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW6.Enabled = false;
            this.btnStatusSW6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW6.Location = new System.Drawing.Point(7, 141);
            this.btnStatusSW6.Name = "btnStatusSW6";
            this.btnStatusSW6.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW6.TabIndex = 1;
            this.btnStatusSW6.Text = "OFF";
            this.btnStatusSW6.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(51, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "SW 8";
            // 
            // btnStatusSW8
            // 
            this.btnStatusSW8.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW8.Enabled = false;
            this.btnStatusSW8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW8.Location = new System.Drawing.Point(7, 191);
            this.btnStatusSW8.Name = "btnStatusSW8";
            this.btnStatusSW8.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW8.TabIndex = 1;
            this.btnStatusSW8.Text = "OFF";
            this.btnStatusSW8.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(51, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "SW 7";
            // 
            // btnStatusSW7
            // 
            this.btnStatusSW7.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW7.Enabled = false;
            this.btnStatusSW7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW7.Location = new System.Drawing.Point(7, 166);
            this.btnStatusSW7.Name = "btnStatusSW7";
            this.btnStatusSW7.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW7.TabIndex = 1;
            this.btnStatusSW7.Text = "OFF";
            this.btnStatusSW7.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(51, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "SW 1";
            // 
            // btnStatusSW1
            // 
            this.btnStatusSW1.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStatusSW1.Enabled = false;
            this.btnStatusSW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnStatusSW1.Location = new System.Drawing.Point(7, 16);
            this.btnStatusSW1.Name = "btnStatusSW1";
            this.btnStatusSW1.Size = new System.Drawing.Size(43, 23);
            this.btnStatusSW1.TabIndex = 1;
            this.btnStatusSW1.Text = "OFF";
            this.btnStatusSW1.UseVisualStyleBackColor = false;
            // 
            // btnReadSwitchs
            // 
            this.btnReadSwitchs.Location = new System.Drawing.Point(7, 224);
            this.btnReadSwitchs.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadSwitchs.Name = "btnReadSwitchs";
            this.btnReadSwitchs.Size = new System.Drawing.Size(92, 30);
            this.btnReadSwitchs.TabIndex = 0;
            this.btnReadSwitchs.Text = "SW LEITURA ";
            this.btnReadSwitchs.UseVisualStyleBackColor = true;
            this.btnReadSwitchs.Click += new System.EventHandler(this.btnReadSwitchs_Click);
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
            this.AD0_MediaGauge.ScaleNumbersFormat = "";
            this.AD0_MediaGauge.ScaleNumbersRadius = 95;
            this.AD0_MediaGauge.ScaleNumbersRotation = 0;
            this.AD0_MediaGauge.ScaleNumbersStartScaleLine = 0;
            this.AD0_MediaGauge.ScaleNumbersStepScaleLines = 1;
            this.AD0_MediaGauge.Size = new System.Drawing.Size(220, 190);
            this.AD0_MediaGauge.TabIndex = 7;
            this.AD0_MediaGauge.Text = "AD0_MediaGauge";
            this.AD0_MediaGauge.Value = 0F;
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
            // lbAD0_MediaGauge
            // 
            this.lbAD0_MediaGauge.AutoSize = true;
            this.lbAD0_MediaGauge.Location = new System.Drawing.Point(9, 18);
            this.lbAD0_MediaGauge.Name = "lbAD0_MediaGauge";
            this.lbAD0_MediaGauge.Size = new System.Drawing.Size(35, 13);
            this.lbAD0_MediaGauge.TabIndex = 10;
            this.lbAD0_MediaGauge.Tag = "";
            this.lbAD0_MediaGauge.Text = "XXXX";
            // 
            // lbAD1_InstaGauge
            // 
            this.lbAD1_InstaGauge.AutoSize = true;
            this.lbAD1_InstaGauge.Location = new System.Drawing.Point(237, 217);
            this.lbAD1_InstaGauge.Name = "lbAD1_InstaGauge";
            this.lbAD1_InstaGauge.Size = new System.Drawing.Size(35, 13);
            this.lbAD1_InstaGauge.TabIndex = 10;
            this.lbAD1_InstaGauge.Tag = "";
            this.lbAD1_InstaGauge.Text = "XXXX";
            // 
            // lbAD0_InstaGauge
            // 
            this.lbAD0_InstaGauge.AutoSize = true;
            this.lbAD0_InstaGauge.Location = new System.Drawing.Point(9, 217);
            this.lbAD0_InstaGauge.Name = "lbAD0_InstaGauge";
            this.lbAD0_InstaGauge.Size = new System.Drawing.Size(35, 13);
            this.lbAD0_InstaGauge.TabIndex = 10;
            this.lbAD0_InstaGauge.Tag = "";
            this.lbAD0_InstaGauge.Text = "XXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 546);
            this.Controls.Add(this.gbEEPROM);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbSwiths);
            this.Controls.Add(this.gbLEDs);
            this.Controls.Add(this.gbADC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.gbSwiths.ResumeLayout(false);
            this.gbSwiths.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbSwiths;
        private System.Windows.Forms.Button btnReadSwitchs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStatusSW5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStatusSW4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStatusSW3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStatusSW2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnStatusSW6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStatusSW8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnStatusSW7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStatusSW1;
        private System.Windows.Forms.Label lbAD1_MediaGauge;
        private System.Windows.Forms.Label lbAD0_InstaGauge;
        private System.Windows.Forms.Label lbAD0_MediaGauge;
        private System.Windows.Forms.Label lbAD1_InstaGauge;
    }
}

