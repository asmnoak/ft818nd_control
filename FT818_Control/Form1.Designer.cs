namespace FT818_Control
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio144mhz = new System.Windows.Forms.RadioButton();
            this.radio50mhz = new System.Windows.Forms.RadioButton();
            this.radio14mhz = new System.Windows.Forms.RadioButton();
            this.radio7mhz = new System.Windows.Forms.RadioButton();
            this.radio15mhz = new System.Windows.Forms.RadioButton();
            this.label_start_freq = new System.Windows.Forms.Label();
            this.label_end_freq = new System.Windows.Forms.Label();
            this.start_freq = new System.Windows.Forms.TextBox();
            this.end_freq = new System.Windows.Forms.TextBox();
            this.sf_up = new System.Windows.Forms.Button();
            this.ef_down = new System.Windows.Forms.Button();
            this.start_scan = new System.Windows.Forms.Button();
            this.c_freq = new System.Windows.Forms.TextBox();
            this.ef_up = new System.Windows.Forms.Button();
            this.sf_down = new System.Windows.Forms.Button();
            this.sc_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioupd1k = new System.Windows.Forms.RadioButton();
            this.radioupd10k = new System.Windows.Forms.RadioButton();
            this.radioupdstep100k = new System.Windows.Forms.RadioButton();
            this.radioupdstep1m = new System.Windows.Forms.RadioButton();
            this.label_cur_freq = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiowfm = new System.Windows.Forms.RadioButton();
            this.radiodig = new System.Windows.Forms.RadioButton();
            this.radiofm = new System.Windows.Forms.RadioButton();
            this.radioam = new System.Windows.Forms.RadioButton();
            this.radiocw = new System.Windows.Forms.RadioButton();
            this.radiousb = new System.Windows.Forms.RadioButton();
            this.radiolsb = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radiopreset5 = new System.Windows.Forms.RadioButton();
            this.radiopreset4 = new System.Windows.Forms.RadioButton();
            this.radiopreset3 = new System.Windows.Forms.RadioButton();
            this.radiopreset2 = new System.Windows.Forms.RadioButton();
            this.radiopreset1 = new System.Windows.Forms.RadioButton();
            this.cf_down = new System.Windows.Forms.Button();
            this.cf_up = new System.Windows.Forms.Button();
            this.cf_set = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radiosinterval_s = new System.Windows.Forms.RadioButton();
            this.radiosinterval_l = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "ファイル";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "終了";
            this.toolStripTextBox1.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.cLOSEToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem2.Text = "COM選択";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.ToolStripComboBox1_Click);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.ToolStripComboBox1_TextChanged);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.CLOSEToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio144mhz);
            this.groupBox1.Controls.Add(this.radio50mhz);
            this.groupBox1.Controls.Add(this.radio14mhz);
            this.groupBox1.Controls.Add(this.radio7mhz);
            this.groupBox1.Controls.Add(this.radio15mhz);
            this.groupBox1.Location = new System.Drawing.Point(65, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAND";
            // 
            // radio144mhz
            // 
            this.radio144mhz.AutoSize = true;
            this.radio144mhz.Location = new System.Drawing.Point(334, 35);
            this.radio144mhz.Name = "radio144mhz";
            this.radio144mhz.Size = new System.Drawing.Size(63, 16);
            this.radio144mhz.TabIndex = 4;
            this.radio144mhz.TabStop = true;
            this.radio144mhz.Text = "144MHz";
            this.radio144mhz.UseVisualStyleBackColor = true;
            this.radio144mhz.Click += new System.EventHandler(this.Radio144mhz_Click);
            // 
            // radio50mhz
            // 
            this.radio50mhz.AutoSize = true;
            this.radio50mhz.Location = new System.Drawing.Point(254, 34);
            this.radio50mhz.Name = "radio50mhz";
            this.radio50mhz.Size = new System.Drawing.Size(57, 16);
            this.radio50mhz.TabIndex = 3;
            this.radio50mhz.TabStop = true;
            this.radio50mhz.Text = "50MHz";
            this.radio50mhz.UseVisualStyleBackColor = true;
            this.radio50mhz.Click += new System.EventHandler(this.Radio50mhz_Click);
            // 
            // radio14mhz
            // 
            this.radio14mhz.AutoSize = true;
            this.radio14mhz.Location = new System.Drawing.Point(98, 33);
            this.radio14mhz.Name = "radio14mhz";
            this.radio14mhz.Size = new System.Drawing.Size(57, 16);
            this.radio14mhz.TabIndex = 2;
            this.radio14mhz.TabStop = true;
            this.radio14mhz.Text = "14MHz";
            this.radio14mhz.UseVisualStyleBackColor = true;
            this.radio14mhz.Click += new System.EventHandler(this.Radio14mhz_Click);
            // 
            // radio7mhz
            // 
            this.radio7mhz.AutoSize = true;
            this.radio7mhz.Location = new System.Drawing.Point(27, 34);
            this.radio7mhz.Name = "radio7mhz";
            this.radio7mhz.Size = new System.Drawing.Size(51, 16);
            this.radio7mhz.TabIndex = 1;
            this.radio7mhz.TabStop = true;
            this.radio7mhz.Text = "7MHz";
            this.radio7mhz.UseVisualStyleBackColor = true;
            this.radio7mhz.Click += new System.EventHandler(this.Radio7mhz_CheckedChanged);
            // 
            // radio15mhz
            // 
            this.radio15mhz.AutoSize = true;
            this.radio15mhz.Location = new System.Drawing.Point(163, 34);
            this.radio15mhz.Name = "radio15mhz";
            this.radio15mhz.Size = new System.Drawing.Size(57, 16);
            this.radio15mhz.TabIndex = 0;
            this.radio15mhz.TabStop = true;
            this.radio15mhz.Text = "15MHz";
            this.radio15mhz.UseVisualStyleBackColor = true;
            this.radio15mhz.Click += new System.EventHandler(this.Radio15mhz_CheckedChanged);
            // 
            // label_start_freq
            // 
            this.label_start_freq.AutoSize = true;
            this.label_start_freq.Location = new System.Drawing.Point(63, 199);
            this.label_start_freq.Name = "label_start_freq";
            this.label_start_freq.Size = new System.Drawing.Size(30, 12);
            this.label_start_freq.TabIndex = 10;
            this.label_start_freq.Text = "Start";
            // 
            // label_end_freq
            // 
            this.label_end_freq.AutoSize = true;
            this.label_end_freq.Location = new System.Drawing.Point(336, 202);
            this.label_end_freq.Name = "label_end_freq";
            this.label_end_freq.Size = new System.Drawing.Size(24, 12);
            this.label_end_freq.TabIndex = 11;
            this.label_end_freq.Text = "End";
            // 
            // start_freq
            // 
            this.start_freq.Location = new System.Drawing.Point(99, 198);
            this.start_freq.Name = "start_freq";
            this.start_freq.Size = new System.Drawing.Size(123, 19);
            this.start_freq.TabIndex = 12;
            // 
            // end_freq
            // 
            this.end_freq.Location = new System.Drawing.Point(366, 199);
            this.end_freq.Name = "end_freq";
            this.end_freq.Size = new System.Drawing.Size(121, 19);
            this.end_freq.TabIndex = 13;
            // 
            // sf_up
            // 
            this.sf_up.Location = new System.Drawing.Point(275, 197);
            this.sf_up.Name = "sf_up";
            this.sf_up.Size = new System.Drawing.Size(44, 31);
            this.sf_up.TabIndex = 14;
            this.sf_up.Text = "up";
            this.sf_up.UseVisualStyleBackColor = true;
            this.sf_up.Click += new System.EventHandler(this.Sf_up_Click);
            // 
            // ef_down
            // 
            this.ef_down.Location = new System.Drawing.Point(495, 198);
            this.ef_down.Name = "ef_down";
            this.ef_down.Size = new System.Drawing.Size(43, 31);
            this.ef_down.TabIndex = 15;
            this.ef_down.Text = "down";
            this.ef_down.UseVisualStyleBackColor = true;
            this.ef_down.Click += new System.EventHandler(this.Ef_down_Click);
            // 
            // start_scan
            // 
            this.start_scan.Location = new System.Drawing.Point(621, 244);
            this.start_scan.Name = "start_scan";
            this.start_scan.Size = new System.Drawing.Size(88, 69);
            this.start_scan.TabIndex = 16;
            this.start_scan.Text = "scan";
            this.start_scan.UseVisualStyleBackColor = true;
            this.start_scan.Click += new System.EventHandler(this.Start_scan_Click);
            // 
            // c_freq
            // 
            this.c_freq.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_freq.Location = new System.Drawing.Point(100, 157);
            this.c_freq.Name = "c_freq";
            this.c_freq.Size = new System.Drawing.Size(122, 27);
            this.c_freq.TabIndex = 17;
            // 
            // ef_up
            // 
            this.ef_up.Location = new System.Drawing.Point(544, 198);
            this.ef_up.Name = "ef_up";
            this.ef_up.Size = new System.Drawing.Size(45, 30);
            this.ef_up.TabIndex = 18;
            this.ef_up.Text = "up";
            this.ef_up.UseVisualStyleBackColor = true;
            this.ef_up.Click += new System.EventHandler(this.Ef_up_Click);
            // 
            // sf_down
            // 
            this.sf_down.Location = new System.Drawing.Point(228, 198);
            this.sf_down.Name = "sf_down";
            this.sf_down.Size = new System.Drawing.Size(42, 30);
            this.sf_down.TabIndex = 19;
            this.sf_down.Text = "down";
            this.sf_down.UseVisualStyleBackColor = true;
            this.sf_down.Click += new System.EventHandler(this.Sf_down_Click);
            // 
            // sc_stop
            // 
            this.sc_stop.Location = new System.Drawing.Point(723, 245);
            this.sc_stop.Name = "sc_stop";
            this.sc_stop.Size = new System.Drawing.Size(84, 68);
            this.sc_stop.TabIndex = 20;
            this.sc_stop.Text = "stop";
            this.sc_stop.UseVisualStyleBackColor = true;
            this.sc_stop.Click += new System.EventHandler(this.Sc_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioupd1k);
            this.groupBox2.Controls.Add(this.radioupd10k);
            this.groupBox2.Controls.Add(this.radioupdstep100k);
            this.groupBox2.Controls.Add(this.radioupdstep1m);
            this.groupBox2.Location = new System.Drawing.Point(595, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 44);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STEP";
            // 
            // radioupd1k
            // 
            this.radioupd1k.AutoSize = true;
            this.radioupd1k.Location = new System.Drawing.Point(168, 20);
            this.radioupd1k.Name = "radioupd1k";
            this.radioupd1k.Size = new System.Drawing.Size(36, 16);
            this.radioupd1k.TabIndex = 3;
            this.radioupd1k.TabStop = true;
            this.radioupd1k.Text = "1K";
            this.radioupd1k.UseVisualStyleBackColor = true;
            this.radioupd1k.CheckedChanged += new System.EventHandler(this.Radioupd1k_CheckedChanged);
            // 
            // radioupd10k
            // 
            this.radioupd10k.AutoSize = true;
            this.radioupd10k.Location = new System.Drawing.Point(120, 20);
            this.radioupd10k.Name = "radioupd10k";
            this.radioupd10k.Size = new System.Drawing.Size(42, 16);
            this.radioupd10k.TabIndex = 2;
            this.radioupd10k.TabStop = true;
            this.radioupd10k.Text = "10K";
            this.radioupd10k.UseVisualStyleBackColor = true;
            this.radioupd10k.CheckedChanged += new System.EventHandler(this.Radioupd10k_CheckedChanged);
            // 
            // radioupdstep100k
            // 
            this.radioupdstep100k.AutoSize = true;
            this.radioupdstep100k.Location = new System.Drawing.Point(66, 20);
            this.radioupdstep100k.Name = "radioupdstep100k";
            this.radioupdstep100k.Size = new System.Drawing.Size(48, 16);
            this.radioupdstep100k.TabIndex = 1;
            this.radioupdstep100k.Text = "100K";
            this.radioupdstep100k.UseVisualStyleBackColor = true;
            this.radioupdstep100k.CheckedChanged += new System.EventHandler(this.Radioupdstep100k_CheckedChanged);
            // 
            // radioupdstep1m
            // 
            this.radioupdstep1m.AutoSize = true;
            this.radioupdstep1m.Checked = true;
            this.radioupdstep1m.Location = new System.Drawing.Point(14, 19);
            this.radioupdstep1m.Name = "radioupdstep1m";
            this.radioupdstep1m.Size = new System.Drawing.Size(38, 16);
            this.radioupdstep1m.TabIndex = 0;
            this.radioupdstep1m.TabStop = true;
            this.radioupdstep1m.Text = "1M";
            this.radioupdstep1m.UseVisualStyleBackColor = true;
            this.radioupdstep1m.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label_cur_freq
            // 
            this.label_cur_freq.AutoSize = true;
            this.label_cur_freq.Location = new System.Drawing.Point(36, 167);
            this.label_cur_freq.Name = "label_cur_freq";
            this.label_cur_freq.Size = new System.Drawing.Size(58, 12);
            this.label_cur_freq.TabIndex = 22;
            this.label_cur_freq.Text = "Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiowfm);
            this.groupBox3.Controls.Add(this.radiodig);
            this.groupBox3.Controls.Add(this.radiofm);
            this.groupBox3.Controls.Add(this.radioam);
            this.groupBox3.Controls.Add(this.radiocw);
            this.groupBox3.Controls.Add(this.radiousb);
            this.groupBox3.Controls.Add(this.radiolsb);
            this.groupBox3.Location = new System.Drawing.Point(65, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 80);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODE";
            // 
            // radiowfm
            // 
            this.radiowfm.AutoSize = true;
            this.radiowfm.Enabled = false;
            this.radiowfm.Location = new System.Drawing.Point(356, 33);
            this.radiowfm.Name = "radiowfm";
            this.radiowfm.Size = new System.Drawing.Size(48, 16);
            this.radiowfm.TabIndex = 6;
            this.radiowfm.TabStop = true;
            this.radiowfm.Text = "WFM";
            this.radiowfm.UseVisualStyleBackColor = true;
            // 
            // radiodig
            // 
            this.radiodig.AutoSize = true;
            this.radiodig.Location = new System.Drawing.Point(302, 33);
            this.radiodig.Name = "radiodig";
            this.radiodig.Size = new System.Drawing.Size(42, 16);
            this.radiodig.TabIndex = 5;
            this.radiodig.TabStop = true;
            this.radiodig.Text = "DIG";
            this.radiodig.UseVisualStyleBackColor = true;
            this.radiodig.Click += new System.EventHandler(this.Radiodig_CheckedChanged);
            // 
            // radiofm
            // 
            this.radiofm.AutoSize = true;
            this.radiofm.Location = new System.Drawing.Point(250, 33);
            this.radiofm.Name = "radiofm";
            this.radiofm.Size = new System.Drawing.Size(39, 16);
            this.radiofm.TabIndex = 4;
            this.radiofm.TabStop = true;
            this.radiofm.Text = "FM";
            this.radiofm.UseVisualStyleBackColor = true;
            this.radiofm.Click += new System.EventHandler(this.Radiofm_CheckedChanged);
            // 
            // radioam
            // 
            this.radioam.AutoSize = true;
            this.radioam.Location = new System.Drawing.Point(194, 33);
            this.radioam.Name = "radioam";
            this.radioam.Size = new System.Drawing.Size(40, 16);
            this.radioam.TabIndex = 3;
            this.radioam.TabStop = true;
            this.radioam.Text = "AM";
            this.radioam.UseVisualStyleBackColor = true;
            this.radioam.Click += new System.EventHandler(this.Radioam_CheckedChanged);
            // 
            // radiocw
            // 
            this.radiocw.AutoSize = true;
            this.radiocw.Location = new System.Drawing.Point(139, 33);
            this.radiocw.Name = "radiocw";
            this.radiocw.Size = new System.Drawing.Size(40, 16);
            this.radiocw.TabIndex = 2;
            this.radiocw.TabStop = true;
            this.radiocw.Text = "CW";
            this.radiocw.UseVisualStyleBackColor = true;
            this.radiocw.Click += new System.EventHandler(this.Radiocw_CheckedChanged);
            // 
            // radiousb
            // 
            this.radiousb.AutoSize = true;
            this.radiousb.Location = new System.Drawing.Point(87, 33);
            this.radiousb.Name = "radiousb";
            this.radiousb.Size = new System.Drawing.Size(46, 16);
            this.radiousb.TabIndex = 1;
            this.radiousb.TabStop = true;
            this.radiousb.Text = "USB";
            this.radiousb.UseVisualStyleBackColor = true;
            this.radiousb.Click += new System.EventHandler(this.Radiousb_CheckedChanged);
            // 
            // radiolsb
            // 
            this.radiolsb.AutoSize = true;
            this.radiolsb.Location = new System.Drawing.Point(27, 33);
            this.radiolsb.Name = "radiolsb";
            this.radiolsb.Size = new System.Drawing.Size(44, 16);
            this.radiolsb.TabIndex = 0;
            this.radiolsb.TabStop = true;
            this.radiolsb.Text = "LSB";
            this.radiolsb.UseVisualStyleBackColor = true;
            this.radiolsb.Click += new System.EventHandler(this.Radiolsb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radiopreset5);
            this.groupBox4.Controls.Add(this.radiopreset4);
            this.groupBox4.Controls.Add(this.radiopreset3);
            this.groupBox4.Controls.Add(this.radiopreset2);
            this.groupBox4.Controls.Add(this.radiopreset1);
            this.groupBox4.Location = new System.Drawing.Point(495, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 79);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRESET";
            // 
            // radiopreset5
            // 
            this.radiopreset5.AutoSize = true;
            this.radiopreset5.Location = new System.Drawing.Point(17, 40);
            this.radiopreset5.Name = "radiopreset5";
            this.radiopreset5.Size = new System.Drawing.Size(46, 16);
            this.radiopreset5.TabIndex = 4;
            this.radiopreset5.TabStop = true;
            this.radiopreset5.Text = "NHK";
            this.radiopreset5.UseVisualStyleBackColor = true;
            this.radiopreset5.Click += new System.EventHandler(this.Radiopreset5_Click);
            // 
            // radiopreset4
            // 
            this.radiopreset4.AutoSize = true;
            this.radiopreset4.Location = new System.Drawing.Point(213, 19);
            this.radiopreset4.Name = "radiopreset4";
            this.radiopreset4.Size = new System.Drawing.Size(47, 16);
            this.radiopreset4.TabIndex = 3;
            this.radiopreset4.TabStop = true;
            this.radiopreset4.Text = "HBC";
            this.radiopreset4.UseVisualStyleBackColor = true;
            this.radiopreset4.Click += new System.EventHandler(this.Radiopreset4_CheckedChanged);
            // 
            // radiopreset3
            // 
            this.radiopreset3.AutoSize = true;
            this.radiopreset3.Location = new System.Drawing.Point(152, 19);
            this.radiopreset3.Name = "radiopreset3";
            this.radiopreset3.Size = new System.Drawing.Size(40, 16);
            this.radiopreset3.TabIndex = 2;
            this.radiopreset3.TabStop = true;
            this.radiopreset3.Text = "NW";
            this.radiopreset3.UseVisualStyleBackColor = true;
            this.radiopreset3.Click += new System.EventHandler(this.Radiopreset3_CheckedChanged);
            // 
            // radiopreset2
            // 
            this.radiopreset2.AutoSize = true;
            this.radiopreset2.Location = new System.Drawing.Point(89, 18);
            this.radiopreset2.Name = "radiopreset2";
            this.radiopreset2.Size = new System.Drawing.Size(45, 16);
            this.radiopreset2.TabIndex = 1;
            this.radiopreset2.TabStop = true;
            this.radiopreset2.Text = "STV";
            this.radiopreset2.UseVisualStyleBackColor = true;
            this.radiopreset2.Click += new System.EventHandler(this.Radiopreset2_CheckedChanged);
            // 
            // radiopreset1
            // 
            this.radiopreset1.AutoSize = true;
            this.radiopreset1.Location = new System.Drawing.Point(16, 18);
            this.radiopreset1.Name = "radiopreset1";
            this.radiopreset1.Size = new System.Drawing.Size(54, 16);
            this.radiopreset1.TabIndex = 0;
            this.radiopreset1.TabStop = true;
            this.radiopreset1.Text = "AIR_G";
            this.radiopreset1.UseVisualStyleBackColor = true;
            this.radiopreset1.Click += new System.EventHandler(this.Radiopreset1_CheckedChanged);
            // 
            // cf_down
            // 
            this.cf_down.Location = new System.Drawing.Point(228, 157);
            this.cf_down.Name = "cf_down";
            this.cf_down.Size = new System.Drawing.Size(41, 32);
            this.cf_down.TabIndex = 25;
            this.cf_down.Text = "down";
            this.cf_down.UseVisualStyleBackColor = true;
            this.cf_down.Click += new System.EventHandler(this.Cf_down_Click);
            // 
            // cf_up
            // 
            this.cf_up.Location = new System.Drawing.Point(275, 157);
            this.cf_up.Name = "cf_up";
            this.cf_up.Size = new System.Drawing.Size(43, 31);
            this.cf_up.TabIndex = 26;
            this.cf_up.Text = "up";
            this.cf_up.UseVisualStyleBackColor = true;
            this.cf_up.Click += new System.EventHandler(this.Cf_up_Click);
            // 
            // cf_set
            // 
            this.cf_set.Location = new System.Drawing.Point(334, 157);
            this.cf_set.Name = "cf_set";
            this.cf_set.Size = new System.Drawing.Size(42, 31);
            this.cf_set.TabIndex = 27;
            this.cf_set.Text = "set";
            this.cf_set.UseVisualStyleBackColor = true;
            this.cf_set.Click += new System.EventHandler(this.Cf_set_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 79);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "SIGNAL REPORT";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "COM:None";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel2.Text = "To FT818:                ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel3.Text = "From FT818:        ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radiosinterval_s);
            this.groupBox5.Controls.Add(this.radiosinterval_l);
            this.groupBox5.Location = new System.Drawing.Point(495, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(114, 74);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SCAN INTERVAL";
            // 
            // radiosinterval_s
            // 
            this.radiosinterval_s.AutoSize = true;
            this.radiosinterval_s.Location = new System.Drawing.Point(14, 46);
            this.radiosinterval_s.Name = "radiosinterval_s";
            this.radiosinterval_s.Size = new System.Drawing.Size(61, 16);
            this.radiosinterval_s.TabIndex = 1;
            this.radiosinterval_s.Text = "SHORT";
            this.radiosinterval_s.UseVisualStyleBackColor = true;
            // 
            // radiosinterval_l
            // 
            this.radiosinterval_l.AutoSize = true;
            this.radiosinterval_l.Checked = true;
            this.radiosinterval_l.Location = new System.Drawing.Point(14, 23);
            this.radiosinterval_l.Name = "radiosinterval_l";
            this.radiosinterval_l.Size = new System.Drawing.Size(53, 16);
            this.radiosinterval_l.TabIndex = 0;
            this.radiosinterval_l.TabStop = true;
            this.radiosinterval_l.Text = "LONG";
            this.radiosinterval_l.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cf_set);
            this.Controls.Add(this.cf_up);
            this.Controls.Add(this.cf_down);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label_cur_freq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sc_stop);
            this.Controls.Add(this.sf_down);
            this.Controls.Add(this.ef_up);
            this.Controls.Add(this.c_freq);
            this.Controls.Add(this.start_scan);
            this.Controls.Add(this.ef_down);
            this.Controls.Add(this.sf_up);
            this.Controls.Add(this.end_freq);
            this.Controls.Add(this.start_freq);
            this.Controls.Add(this.label_end_freq);
            this.Controls.Add(this.label_start_freq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FT818ND";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio7mhz;
        private System.Windows.Forms.RadioButton radio15mhz;
        private System.Windows.Forms.Label label_start_freq;
        private System.Windows.Forms.Label label_end_freq;
        private System.Windows.Forms.TextBox start_freq;
        private System.Windows.Forms.TextBox end_freq;
        private System.Windows.Forms.Button sf_up;
        private System.Windows.Forms.Button ef_down;
        private System.Windows.Forms.Button start_scan;
        private System.Windows.Forms.TextBox c_freq;
        private System.Windows.Forms.Button ef_up;
        private System.Windows.Forms.Button sf_down;
        private System.Windows.Forms.Button sc_stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioupdstep100k;
        private System.Windows.Forms.RadioButton radioupdstep1m;
        private System.Windows.Forms.RadioButton radioupd10k;
        private System.Windows.Forms.Label label_cur_freq;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radiodig;
        private System.Windows.Forms.RadioButton radiofm;
        private System.Windows.Forms.RadioButton radioam;
        private System.Windows.Forms.RadioButton radiocw;
        private System.Windows.Forms.RadioButton radiousb;
        private System.Windows.Forms.RadioButton radiolsb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radiopreset2;
        private System.Windows.Forms.RadioButton radiopreset1;
        private System.Windows.Forms.RadioButton radiopreset4;
        private System.Windows.Forms.RadioButton radiopreset3;
        private System.Windows.Forms.RadioButton radioupd1k;
        private System.Windows.Forms.Button cf_down;
        private System.Windows.Forms.Button cf_up;
        private System.Windows.Forms.Button cf_set;
        private System.Windows.Forms.RadioButton radio14mhz;
        private System.Windows.Forms.RadioButton radio144mhz;
        private System.Windows.Forms.RadioButton radio50mhz;
        private System.Windows.Forms.RadioButton radiopreset5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radiosinterval_s;
        private System.Windows.Forms.RadioButton radiosinterval_l;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RadioButton radiowfm;
    }
}

