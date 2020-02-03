namespace SpeedAndDistance
{
    partial class SetDistancePerRev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDistancePerRev));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrakeCirc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCdA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxStageTime = new System.Windows.Forms.TextBox();
            this.radioButtonModeNHRA = new System.Windows.Forms.RadioButton();
            this.radioButtonModeStd = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonRaceMode5 = new System.Windows.Forms.RadioButton();
            this.radioButtonRaceMode4 = new System.Windows.Forms.RadioButton();
            this.radioButtonRaceMode3 = new System.Windows.Forms.RadioButton();
            this.radioButtonRaceMode1 = new System.Windows.Forms.RadioButton();
            this.radioButtonRaceMode2 = new System.Windows.Forms.RadioButton();
            this.R8 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.R7 = new System.Windows.Forms.Button();
            this.R6 = new System.Windows.Forms.Button();
            this.R5 = new System.Windows.Forms.Button();
            this.R4 = new System.Windows.Forms.Button();
            this.R3 = new System.Windows.Forms.Button();
            this.R2 = new System.Windows.Forms.Button();
            this.RSerial = new System.Windows.Forms.Label();
            this.R1 = new System.Windows.Forms.Button();
            this.timer500 = new System.Windows.Forms.Timer(this.components);
            this.timer2000 = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelRace = new System.Windows.Forms.Button();
            this.timerRedraw = new System.Windows.Forms.Timer(this.components);
            this.labelRacetime = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBrakeCirc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "meters";
            // 
            // textBoxBrakeCirc
            // 
            this.textBoxBrakeCirc.DecimalPlaces = 3;
            this.textBoxBrakeCirc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.textBoxBrakeCirc.Location = new System.Drawing.Point(412, 194);
            this.textBoxBrakeCirc.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxBrakeCirc.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxBrakeCirc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.textBoxBrakeCirc.Name = "textBoxBrakeCirc";
            this.textBoxBrakeCirc.Size = new System.Drawing.Size(187, 44);
            this.textBoxBrakeCirc.TabIndex = 5;
            this.textBoxBrakeCirc.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(89, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 brake revolution = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxBrakeCirc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCdA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxWeight);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxStageTime);
            this.groupBox2.Controls.Add(this.radioButtonModeNHRA);
            this.groupBox2.Controls.Add(this.radioButtonModeStd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(38, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Size = new System.Drawing.Size(773, 421);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(317, 361);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "d";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "m²";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "kg";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "C    A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCdA
            // 
            this.textBoxCdA.Location = new System.Drawing.Point(412, 342);
            this.textBoxCdA.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCdA.Name = "textBoxCdA";
            this.textBoxCdA.Size = new System.Drawing.Size(181, 44);
            this.textBoxCdA.TabIndex = 12;
            this.textBoxCdA.Text = "0,629";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicle Weight:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(412, 268);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(181, 44);
            this.textBoxWeight.TabIndex = 10;
            this.textBoxWeight.Text = "1250";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 37);
            this.label11.TabIndex = 6;
            this.label11.Text = "ms";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxStageTime
            // 
            this.textBoxStageTime.Location = new System.Drawing.Point(409, 54);
            this.textBoxStageTime.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxStageTime.MaxLength = 4;
            this.textBoxStageTime.Name = "textBoxStageTime";
            this.textBoxStageTime.Size = new System.Drawing.Size(181, 44);
            this.textBoxStageTime.TabIndex = 5;
            this.textBoxStageTime.Text = "2000";
            // 
            // radioButtonModeNHRA
            // 
            this.radioButtonModeNHRA.AutoSize = true;
            this.radioButtonModeNHRA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonModeNHRA.Location = new System.Drawing.Point(380, 128);
            this.radioButtonModeNHRA.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonModeNHRA.Name = "radioButtonModeNHRA";
            this.radioButtonModeNHRA.Size = new System.Drawing.Size(339, 41);
            this.radioButtonModeNHRA.TabIndex = 4;
            this.radioButtonModeNHRA.TabStop = true;
            this.radioButtonModeNHRA.Text = "NHRA Pro (400ms)";
            this.radioButtonModeNHRA.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeStd
            // 
            this.radioButtonModeStd.AutoSize = true;
            this.radioButtonModeStd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonModeStd.Location = new System.Drawing.Point(19, 128);
            this.radioButtonModeStd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonModeStd.Name = "radioButtonModeStd";
            this.radioButtonModeStd.Size = new System.Drawing.Size(320, 41);
            this.radioButtonModeStd.TabIndex = 3;
            this.radioButtonModeStd.TabStop = true;
            this.radioButtonModeStd.Text = "Standard (500ms)";
            this.radioButtonModeStd.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(340, 37);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pre-Stage/Stage Time:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonRaceMode5);
            this.groupBox3.Controls.Add(this.radioButtonRaceMode4);
            this.groupBox3.Controls.Add(this.radioButtonRaceMode3);
            this.groupBox3.Controls.Add(this.radioButtonRaceMode1);
            this.groupBox3.Controls.Add(this.radioButtonRaceMode2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(830, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox3.Size = new System.Drawing.Size(320, 421);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Race Mode";
            // 
            // radioButtonRaceMode5
            // 
            this.radioButtonRaceMode5.AutoSize = true;
            this.radioButtonRaceMode5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRaceMode5.Location = new System.Drawing.Point(57, 330);
            this.radioButtonRaceMode5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonRaceMode5.Name = "radioButtonRaceMode5";
            this.radioButtonRaceMode5.Size = new System.Drawing.Size(213, 41);
            this.radioButtonRaceMode5.TabIndex = 21;
            this.radioButtonRaceMode5.TabStop = true;
            this.radioButtonRaceMode5.Text = "0-200km/h";
            this.radioButtonRaceMode5.UseVisualStyleBackColor = true;
            // 
            // radioButtonRaceMode4
            // 
            this.radioButtonRaceMode4.AutoSize = true;
            this.radioButtonRaceMode4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRaceMode4.Location = new System.Drawing.Point(57, 265);
            this.radioButtonRaceMode4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonRaceMode4.Name = "radioButtonRaceMode4";
            this.radioButtonRaceMode4.Size = new System.Drawing.Size(211, 41);
            this.radioButtonRaceMode4.TabIndex = 21;
            this.radioButtonRaceMode4.TabStop = true;
            this.radioButtonRaceMode4.Text = "0-100km/h";
            this.radioButtonRaceMode4.UseVisualStyleBackColor = true;
            // 
            // radioButtonRaceMode3
            // 
            this.radioButtonRaceMode3.AutoSize = true;
            this.radioButtonRaceMode3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRaceMode3.Location = new System.Drawing.Point(98, 199);
            this.radioButtonRaceMode3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonRaceMode3.Name = "radioButtonRaceMode3";
            this.radioButtonRaceMode3.Size = new System.Drawing.Size(170, 41);
            this.radioButtonRaceMode3.TabIndex = 20;
            this.radioButtonRaceMode3.TabStop = true;
            this.radioButtonRaceMode3.Text = "1/2 Mile";
            this.radioButtonRaceMode3.UseVisualStyleBackColor = true;
            // 
            // radioButtonRaceMode1
            // 
            this.radioButtonRaceMode1.AutoSize = true;
            this.radioButtonRaceMode1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRaceMode1.Location = new System.Drawing.Point(98, 68);
            this.radioButtonRaceMode1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonRaceMode1.Name = "radioButtonRaceMode1";
            this.radioButtonRaceMode1.Size = new System.Drawing.Size(170, 41);
            this.radioButtonRaceMode1.TabIndex = 18;
            this.radioButtonRaceMode1.TabStop = true;
            this.radioButtonRaceMode1.Text = "1/8 Mile";
            this.radioButtonRaceMode1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRaceMode2
            // 
            this.radioButtonRaceMode2.AutoSize = true;
            this.radioButtonRaceMode2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRaceMode2.Location = new System.Drawing.Point(98, 134);
            this.radioButtonRaceMode2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButtonRaceMode2.Name = "radioButtonRaceMode2";
            this.radioButtonRaceMode2.Size = new System.Drawing.Size(170, 41);
            this.radioButtonRaceMode2.TabIndex = 19;
            this.radioButtonRaceMode2.TabStop = true;
            this.radioButtonRaceMode2.Text = "1/4 Mile";
            this.radioButtonRaceMode2.UseVisualStyleBackColor = true;
            // 
            // R8
            // 
            this.R8.BackColor = System.Drawing.SystemColors.Control;
            this.R8.ContextMenuStrip = this.contextMenuStrip1;
            this.R8.Location = new System.Drawing.Point(38, 688);
            this.R8.Margin = new System.Windows.Forms.Padding(6);
            this.R8.Name = "R8";
            this.R8.Size = new System.Drawing.Size(304, 97);
            this.R8.TabIndex = 31;
            this.R8.Text = "Relay 8";
            this.R8.UseVisualStyleBackColor = false;
            this.R8.Click += new System.EventHandler(this.R8_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 60);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(228, 56);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // R7
            // 
            this.R7.BackColor = System.Drawing.SystemColors.Control;
            this.R7.ContextMenuStrip = this.contextMenuStrip1;
            this.R7.Location = new System.Drawing.Point(38, 579);
            this.R7.Margin = new System.Windows.Forms.Padding(6);
            this.R7.Name = "R7";
            this.R7.Size = new System.Drawing.Size(304, 97);
            this.R7.TabIndex = 30;
            this.R7.Text = "Relay 7";
            this.R7.UseVisualStyleBackColor = false;
            this.R7.Click += new System.EventHandler(this.R7_Click);
            // 
            // R6
            // 
            this.R6.BackColor = System.Drawing.SystemColors.Control;
            this.R6.ContextMenuStrip = this.contextMenuStrip1;
            this.R6.Location = new System.Drawing.Point(35, 470);
            this.R6.Margin = new System.Windows.Forms.Padding(6);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(304, 97);
            this.R6.TabIndex = 29;
            this.R6.Text = "Relay 6";
            this.R6.UseVisualStyleBackColor = false;
            this.R6.Click += new System.EventHandler(this.R6_Click);
            // 
            // R5
            // 
            this.R5.BackColor = System.Drawing.SystemColors.Control;
            this.R5.Location = new System.Drawing.Point(972, 845);
            this.R5.Margin = new System.Windows.Forms.Padding(6);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(181, 65);
            this.R5.TabIndex = 28;
            this.R5.UseVisualStyleBackColor = false;
            this.R5.Click += new System.EventHandler(this.R5_Click);
            // 
            // R4
            // 
            this.R4.BackColor = System.Drawing.SystemColors.Control;
            this.R4.Location = new System.Drawing.Point(969, 768);
            this.R4.Margin = new System.Windows.Forms.Padding(6);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(181, 65);
            this.R4.TabIndex = 27;
            this.R4.UseVisualStyleBackColor = false;
            this.R4.Click += new System.EventHandler(this.R4_Click);
            // 
            // R3
            // 
            this.R3.BackColor = System.Drawing.SystemColors.Control;
            this.R3.Location = new System.Drawing.Point(969, 692);
            this.R3.Margin = new System.Windows.Forms.Padding(6);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(181, 65);
            this.R3.TabIndex = 26;
            this.R3.UseVisualStyleBackColor = false;
            this.R3.Click += new System.EventHandler(this.R3_Click);
            // 
            // R2
            // 
            this.R2.BackColor = System.Drawing.SystemColors.Control;
            this.R2.Location = new System.Drawing.Point(969, 615);
            this.R2.Margin = new System.Windows.Forms.Padding(6);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(181, 65);
            this.R2.TabIndex = 25;
            this.R2.UseVisualStyleBackColor = false;
            this.R2.Click += new System.EventHandler(this.R2_Click);
            // 
            // RSerial
            // 
            this.RSerial.AutoSize = true;
            this.RSerial.Location = new System.Drawing.Point(26, 1093);
            this.RSerial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RSerial.Name = "RSerial";
            this.RSerial.Size = new System.Drawing.Size(278, 37);
            this.RSerial.TabIndex = 23;
            this.RSerial.Text = "USB Relay Serial: ";
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(969, 470);
            this.R1.Margin = new System.Windows.Forms.Padding(6);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(181, 134);
            this.R1.TabIndex = 24;
            this.R1.UseVisualStyleBackColor = false;
            this.R1.Click += new System.EventHandler(this.R1_Click);
            // 
            // timer500
            // 
            this.timer500.Interval = 500;
            this.timer500.Tick += new System.EventHandler(this.timer500_Tick);
            // 
            // timer2000
            // 
            this.timer2000.Interval = 2000;
            this.timer2000.Tick += new System.EventHandler(this.timer2000_Tick);
            // 
            // buttonCancelRace
            // 
            this.buttonCancelRace.Location = new System.Drawing.Point(36, 1019);
            this.buttonCancelRace.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonCancelRace.Name = "buttonCancelRace";
            this.buttonCancelRace.Size = new System.Drawing.Size(238, 65);
            this.buttonCancelRace.TabIndex = 35;
            this.buttonCancelRace.Text = "cancel";
            this.buttonCancelRace.UseVisualStyleBackColor = true;
            this.buttonCancelRace.Visible = false;
            this.buttonCancelRace.Click += new System.EventHandler(this.buttonCancelRace_Click);
            // 
            // timerRedraw
            // 
            this.timerRedraw.Enabled = true;
            this.timerRedraw.Interval = 10;
            this.timerRedraw.Tick += new System.EventHandler(this.timerRedraw_Tick);
            // 
            // labelRacetime
            // 
            this.labelRacetime.AutoSize = true;
            this.labelRacetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRacetime.Location = new System.Drawing.Point(106, 834);
            this.labelRacetime.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelRacetime.Name = "labelRacetime";
            this.labelRacetime.Size = new System.Drawing.Size(429, 163);
            this.labelRacetime.TabIndex = 36;
            this.labelRacetime.Text = "0.000";
            this.labelRacetime.Click += new System.EventHandler(this.labelRacetime_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSettings.Image = global::SpeedAndDistance.Properties.Resources.Windows_Settings_app_icon;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(355, 579);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(295, 101);
            this.buttonSettings.TabIndex = 37;
            this.buttonSettings.Text = "Relay Setup";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(355, 470);
            this.startButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(295, 97);
            this.startButton.TabIndex = 34;
            this.startButton.Text = "      Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SpeedAndDistance.Properties.Resources.e9d72b7fb88b68f92ccc721e0a3148b2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(671, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 527);
            this.panel1.TabIndex = 33;
            // 
            // SetDistancePerRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 1146);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelRacetime);
            this.Controls.Add(this.buttonCancelRace);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.R8);
            this.Controls.Add(this.R7);
            this.Controls.Add(this.R6);
            this.Controls.Add(this.R5);
            this.Controls.Add(this.R4);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.RSerial);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetDistancePerRev";
            this.Text = "Drag Racing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetDistancePerRev_FormClosing);
            this.Load += new System.EventHandler(this.SetDistancePerRev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBrakeCirc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textBoxBrakeCirc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCdA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxStageTime;
        private System.Windows.Forms.RadioButton radioButtonModeNHRA;
        private System.Windows.Forms.RadioButton radioButtonModeStd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonRaceMode3;
        private System.Windows.Forms.RadioButton radioButtonRaceMode1;
        private System.Windows.Forms.RadioButton radioButtonRaceMode2;
        private System.Windows.Forms.RadioButton radioButtonRaceMode5;
        private System.Windows.Forms.RadioButton radioButtonRaceMode4;
        private System.Windows.Forms.Button R8;
        private System.Windows.Forms.Button R7;
        private System.Windows.Forms.Button R6;
        private System.Windows.Forms.Button R5;
        private System.Windows.Forms.Button R4;
        private System.Windows.Forms.Button R3;
        private System.Windows.Forms.Button R2;
        private System.Windows.Forms.Button R1;
        private System.Windows.Forms.Label RSerial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer500;
        private System.Windows.Forms.Timer timer2000;
        private System.Windows.Forms.Button buttonCancelRace;
        private System.Windows.Forms.Timer timerRedraw;
        private System.Windows.Forms.Label labelRacetime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        public System.Windows.Forms.Button buttonSettings;
    }
}