namespace Penumbra.Windows
{
	partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.gb_Hotkeys = new System.Windows.Forms.GroupBox();
            this.cb_QuitKey = new System.Windows.Forms.ComboBox();
            this.cb_SettingsKey = new System.Windows.Forms.ComboBox();
            this.cb_ToggleKey = new System.Windows.Forms.ComboBox();
            this.cb_DecreaseKey = new System.Windows.Forms.ComboBox();
            this.cb_IncreaseKey = new System.Windows.Forms.ComboBox();
            this.cb_QuitAlt = new System.Windows.Forms.CheckBox();
            this.cb_SettingsAlt = new System.Windows.Forms.CheckBox();
            this.cb_ToggleAlt = new System.Windows.Forms.CheckBox();
            this.cb_DecreaseAlt = new System.Windows.Forms.CheckBox();
            this.cb_IncreaseAlt = new System.Windows.Forms.CheckBox();
            this.cb_QuitShift = new System.Windows.Forms.CheckBox();
            this.cb_SettingsShift = new System.Windows.Forms.CheckBox();
            this.cb_ToggleShift = new System.Windows.Forms.CheckBox();
            this.cb_DecreaseShift = new System.Windows.Forms.CheckBox();
            this.cb_QuitCtrl = new System.Windows.Forms.CheckBox();
            this.cb_SettingsCtrl = new System.Windows.Forms.CheckBox();
            this.cb_ToggleCtrl = new System.Windows.Forms.CheckBox();
            this.cb_DecreaseCtrl = new System.Windows.Forms.CheckBox();
            this.cb_IncreaseShift = new System.Windows.Forms.CheckBox();
            this.cb_IncreaseCtrl = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Key = new System.Windows.Forms.Label();
            this.lb_Alt = new System.Windows.Forms.Label();
            this.lb_Shift = new System.Windows.Forms.Label();
            this.lb_Ctrl = new System.Windows.Forms.Label();
            this.lb_Increase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_General = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_BrightnessLevel = new System.Windows.Forms.Label();
            this.tb_BrightnessLevel = new System.Windows.Forms.TrackBar();
            this.lb_FilterLevelMax = new System.Windows.Forms.Label();
            this.lb_FilterLevelMin = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_FilterLevel = new System.Windows.Forms.Label();
            this.tb_FilterLevel = new System.Windows.Forms.TrackBar();
            this.gb_Hotkeys.SuspendLayout();
            this.gb_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BrightnessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FilterLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Hotkeys
            // 
            this.gb_Hotkeys.Controls.Add(this.cb_QuitKey);
            this.gb_Hotkeys.Controls.Add(this.cb_SettingsKey);
            this.gb_Hotkeys.Controls.Add(this.cb_ToggleKey);
            this.gb_Hotkeys.Controls.Add(this.cb_DecreaseKey);
            this.gb_Hotkeys.Controls.Add(this.cb_IncreaseKey);
            this.gb_Hotkeys.Controls.Add(this.cb_QuitAlt);
            this.gb_Hotkeys.Controls.Add(this.cb_SettingsAlt);
            this.gb_Hotkeys.Controls.Add(this.cb_ToggleAlt);
            this.gb_Hotkeys.Controls.Add(this.cb_DecreaseAlt);
            this.gb_Hotkeys.Controls.Add(this.cb_IncreaseAlt);
            this.gb_Hotkeys.Controls.Add(this.cb_QuitShift);
            this.gb_Hotkeys.Controls.Add(this.cb_SettingsShift);
            this.gb_Hotkeys.Controls.Add(this.cb_ToggleShift);
            this.gb_Hotkeys.Controls.Add(this.cb_DecreaseShift);
            this.gb_Hotkeys.Controls.Add(this.cb_QuitCtrl);
            this.gb_Hotkeys.Controls.Add(this.cb_SettingsCtrl);
            this.gb_Hotkeys.Controls.Add(this.cb_ToggleCtrl);
            this.gb_Hotkeys.Controls.Add(this.cb_DecreaseCtrl);
            this.gb_Hotkeys.Controls.Add(this.cb_IncreaseShift);
            this.gb_Hotkeys.Controls.Add(this.cb_IncreaseCtrl);
            this.gb_Hotkeys.Controls.Add(this.label4);
            this.gb_Hotkeys.Controls.Add(this.label3);
            this.gb_Hotkeys.Controls.Add(this.label2);
            this.gb_Hotkeys.Controls.Add(this.label1);
            this.gb_Hotkeys.Controls.Add(this.lb_Key);
            this.gb_Hotkeys.Controls.Add(this.lb_Alt);
            this.gb_Hotkeys.Controls.Add(this.lb_Shift);
            this.gb_Hotkeys.Controls.Add(this.lb_Ctrl);
            this.gb_Hotkeys.Controls.Add(this.lb_Increase);
            this.gb_Hotkeys.Controls.Add(this.label5);
            this.gb_Hotkeys.Location = new System.Drawing.Point(12, 180);
            this.gb_Hotkeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Hotkeys.Name = "gb_Hotkeys";
            this.gb_Hotkeys.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Hotkeys.Size = new System.Drawing.Size(330, 237);
            this.gb_Hotkeys.TabIndex = 1;
            this.gb_Hotkeys.TabStop = false;
            this.gb_Hotkeys.Text = "Hotkeys";
            // 
            // cb_QuitKey
            // 
            this.cb_QuitKey.DropDownHeight = 138;
            this.cb_QuitKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QuitKey.FormattingEnabled = true;
            this.cb_QuitKey.IntegralHeight = false;
            this.cb_QuitKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Up",
            "Down"});
            this.cb_QuitKey.Location = new System.Drawing.Point(250, 192);
            this.cb_QuitKey.Name = "cb_QuitKey";
            this.cb_QuitKey.Size = new System.Drawing.Size(61, 29);
            this.cb_QuitKey.TabIndex = 19;
            this.cb_QuitKey.SelectedIndexChanged += new System.EventHandler(this.QuitModifierChanged);
            // 
            // cb_SettingsKey
            // 
            this.cb_SettingsKey.DropDownHeight = 138;
            this.cb_SettingsKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SettingsKey.FormattingEnabled = true;
            this.cb_SettingsKey.IntegralHeight = false;
            this.cb_SettingsKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Up",
            "Down"});
            this.cb_SettingsKey.Location = new System.Drawing.Point(250, 161);
            this.cb_SettingsKey.Name = "cb_SettingsKey";
            this.cb_SettingsKey.Size = new System.Drawing.Size(61, 29);
            this.cb_SettingsKey.TabIndex = 15;
            this.cb_SettingsKey.SelectedIndexChanged += new System.EventHandler(this.SettingsModifierChanged);
            // 
            // cb_ToggleKey
            // 
            this.cb_ToggleKey.DropDownHeight = 138;
            this.cb_ToggleKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ToggleKey.FormattingEnabled = true;
            this.cb_ToggleKey.IntegralHeight = false;
            this.cb_ToggleKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Up",
            "Down"});
            this.cb_ToggleKey.Location = new System.Drawing.Point(250, 130);
            this.cb_ToggleKey.Name = "cb_ToggleKey";
            this.cb_ToggleKey.Size = new System.Drawing.Size(61, 29);
            this.cb_ToggleKey.TabIndex = 11;
            this.cb_ToggleKey.SelectedIndexChanged += new System.EventHandler(this.ToggleModifierChanged);
            // 
            // cb_DecreaseKey
            // 
            this.cb_DecreaseKey.DropDownHeight = 138;
            this.cb_DecreaseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DecreaseKey.FormattingEnabled = true;
            this.cb_DecreaseKey.IntegralHeight = false;
            this.cb_DecreaseKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Up",
            "Down"});
            this.cb_DecreaseKey.Location = new System.Drawing.Point(250, 99);
            this.cb_DecreaseKey.Name = "cb_DecreaseKey";
            this.cb_DecreaseKey.Size = new System.Drawing.Size(61, 29);
            this.cb_DecreaseKey.TabIndex = 7;
            this.cb_DecreaseKey.SelectedIndexChanged += new System.EventHandler(this.DecreaseModifierChanged);
            // 
            // cb_IncreaseKey
            // 
            this.cb_IncreaseKey.DropDownHeight = 138;
            this.cb_IncreaseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IncreaseKey.FormattingEnabled = true;
            this.cb_IncreaseKey.IntegralHeight = false;
            this.cb_IncreaseKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Up",
            "Down"});
            this.cb_IncreaseKey.Location = new System.Drawing.Point(250, 68);
            this.cb_IncreaseKey.Name = "cb_IncreaseKey";
            this.cb_IncreaseKey.Size = new System.Drawing.Size(61, 29);
            this.cb_IncreaseKey.TabIndex = 3;
            this.cb_IncreaseKey.SelectedIndexChanged += new System.EventHandler(this.IncreaseModifierChanged);
            // 
            // cb_QuitAlt
            // 
            this.cb_QuitAlt.AutoSize = true;
            this.cb_QuitAlt.Location = new System.Drawing.Point(221, 197);
            this.cb_QuitAlt.Name = "cb_QuitAlt";
            this.cb_QuitAlt.Size = new System.Drawing.Size(18, 17);
            this.cb_QuitAlt.TabIndex = 18;
            this.cb_QuitAlt.UseVisualStyleBackColor = true;
            this.cb_QuitAlt.CheckedChanged += new System.EventHandler(this.QuitModifierChanged);
            // 
            // cb_SettingsAlt
            // 
            this.cb_SettingsAlt.AutoSize = true;
            this.cb_SettingsAlt.Location = new System.Drawing.Point(221, 166);
            this.cb_SettingsAlt.Name = "cb_SettingsAlt";
            this.cb_SettingsAlt.Size = new System.Drawing.Size(18, 17);
            this.cb_SettingsAlt.TabIndex = 14;
            this.cb_SettingsAlt.UseVisualStyleBackColor = true;
            this.cb_SettingsAlt.CheckedChanged += new System.EventHandler(this.SettingsModifierChanged);
            // 
            // cb_ToggleAlt
            // 
            this.cb_ToggleAlt.AutoSize = true;
            this.cb_ToggleAlt.Location = new System.Drawing.Point(221, 135);
            this.cb_ToggleAlt.Name = "cb_ToggleAlt";
            this.cb_ToggleAlt.Size = new System.Drawing.Size(18, 17);
            this.cb_ToggleAlt.TabIndex = 10;
            this.cb_ToggleAlt.UseVisualStyleBackColor = true;
            this.cb_ToggleAlt.CheckedChanged += new System.EventHandler(this.ToggleModifierChanged);
            // 
            // cb_DecreaseAlt
            // 
            this.cb_DecreaseAlt.AutoSize = true;
            this.cb_DecreaseAlt.Location = new System.Drawing.Point(221, 104);
            this.cb_DecreaseAlt.Name = "cb_DecreaseAlt";
            this.cb_DecreaseAlt.Size = new System.Drawing.Size(18, 17);
            this.cb_DecreaseAlt.TabIndex = 6;
            this.cb_DecreaseAlt.UseVisualStyleBackColor = true;
            this.cb_DecreaseAlt.CheckedChanged += new System.EventHandler(this.DecreaseModifierChanged);
            // 
            // cb_IncreaseAlt
            // 
            this.cb_IncreaseAlt.AutoSize = true;
            this.cb_IncreaseAlt.Location = new System.Drawing.Point(221, 73);
            this.cb_IncreaseAlt.Name = "cb_IncreaseAlt";
            this.cb_IncreaseAlt.Size = new System.Drawing.Size(18, 17);
            this.cb_IncreaseAlt.TabIndex = 2;
            this.cb_IncreaseAlt.UseVisualStyleBackColor = true;
            this.cb_IncreaseAlt.CheckedChanged += new System.EventHandler(this.IncreaseModifierChanged);
            // 
            // cb_QuitShift
            // 
            this.cb_QuitShift.AutoSize = true;
            this.cb_QuitShift.Location = new System.Drawing.Point(186, 197);
            this.cb_QuitShift.Name = "cb_QuitShift";
            this.cb_QuitShift.Size = new System.Drawing.Size(18, 17);
            this.cb_QuitShift.TabIndex = 17;
            this.cb_QuitShift.UseVisualStyleBackColor = true;
            this.cb_QuitShift.CheckedChanged += new System.EventHandler(this.QuitModifierChanged);
            // 
            // cb_SettingsShift
            // 
            this.cb_SettingsShift.AutoSize = true;
            this.cb_SettingsShift.Location = new System.Drawing.Point(186, 166);
            this.cb_SettingsShift.Name = "cb_SettingsShift";
            this.cb_SettingsShift.Size = new System.Drawing.Size(18, 17);
            this.cb_SettingsShift.TabIndex = 13;
            this.cb_SettingsShift.UseVisualStyleBackColor = true;
            this.cb_SettingsShift.CheckedChanged += new System.EventHandler(this.SettingsModifierChanged);
            // 
            // cb_ToggleShift
            // 
            this.cb_ToggleShift.AutoSize = true;
            this.cb_ToggleShift.Location = new System.Drawing.Point(186, 135);
            this.cb_ToggleShift.Name = "cb_ToggleShift";
            this.cb_ToggleShift.Size = new System.Drawing.Size(18, 17);
            this.cb_ToggleShift.TabIndex = 9;
            this.cb_ToggleShift.UseVisualStyleBackColor = true;
            this.cb_ToggleShift.CheckedChanged += new System.EventHandler(this.ToggleModifierChanged);
            // 
            // cb_DecreaseShift
            // 
            this.cb_DecreaseShift.AutoSize = true;
            this.cb_DecreaseShift.Location = new System.Drawing.Point(186, 104);
            this.cb_DecreaseShift.Name = "cb_DecreaseShift";
            this.cb_DecreaseShift.Size = new System.Drawing.Size(18, 17);
            this.cb_DecreaseShift.TabIndex = 5;
            this.cb_DecreaseShift.UseVisualStyleBackColor = true;
            this.cb_DecreaseShift.CheckedChanged += new System.EventHandler(this.DecreaseModifierChanged);
            // 
            // cb_QuitCtrl
            // 
            this.cb_QuitCtrl.AutoSize = true;
            this.cb_QuitCtrl.Location = new System.Drawing.Point(151, 197);
            this.cb_QuitCtrl.Name = "cb_QuitCtrl";
            this.cb_QuitCtrl.Size = new System.Drawing.Size(18, 17);
            this.cb_QuitCtrl.TabIndex = 16;
            this.cb_QuitCtrl.UseVisualStyleBackColor = true;
            this.cb_QuitCtrl.CheckedChanged += new System.EventHandler(this.QuitModifierChanged);
            // 
            // cb_SettingsCtrl
            // 
            this.cb_SettingsCtrl.AutoSize = true;
            this.cb_SettingsCtrl.Location = new System.Drawing.Point(151, 166);
            this.cb_SettingsCtrl.Name = "cb_SettingsCtrl";
            this.cb_SettingsCtrl.Size = new System.Drawing.Size(18, 17);
            this.cb_SettingsCtrl.TabIndex = 12;
            this.cb_SettingsCtrl.UseVisualStyleBackColor = true;
            this.cb_SettingsCtrl.CheckedChanged += new System.EventHandler(this.SettingsModifierChanged);
            // 
            // cb_ToggleCtrl
            // 
            this.cb_ToggleCtrl.AutoSize = true;
            this.cb_ToggleCtrl.Location = new System.Drawing.Point(151, 135);
            this.cb_ToggleCtrl.Name = "cb_ToggleCtrl";
            this.cb_ToggleCtrl.Size = new System.Drawing.Size(18, 17);
            this.cb_ToggleCtrl.TabIndex = 8;
            this.cb_ToggleCtrl.UseVisualStyleBackColor = true;
            this.cb_ToggleCtrl.CheckedChanged += new System.EventHandler(this.ToggleModifierChanged);
            // 
            // cb_DecreaseCtrl
            // 
            this.cb_DecreaseCtrl.AutoSize = true;
            this.cb_DecreaseCtrl.Location = new System.Drawing.Point(151, 104);
            this.cb_DecreaseCtrl.Name = "cb_DecreaseCtrl";
            this.cb_DecreaseCtrl.Size = new System.Drawing.Size(18, 17);
            this.cb_DecreaseCtrl.TabIndex = 4;
            this.cb_DecreaseCtrl.UseVisualStyleBackColor = true;
            this.cb_DecreaseCtrl.CheckedChanged += new System.EventHandler(this.DecreaseModifierChanged);
            // 
            // cb_IncreaseShift
            // 
            this.cb_IncreaseShift.AutoSize = true;
            this.cb_IncreaseShift.Location = new System.Drawing.Point(186, 73);
            this.cb_IncreaseShift.Name = "cb_IncreaseShift";
            this.cb_IncreaseShift.Size = new System.Drawing.Size(18, 17);
            this.cb_IncreaseShift.TabIndex = 1;
            this.cb_IncreaseShift.UseVisualStyleBackColor = true;
            this.cb_IncreaseShift.CheckedChanged += new System.EventHandler(this.IncreaseModifierChanged);
            // 
            // cb_IncreaseCtrl
            // 
            this.cb_IncreaseCtrl.AutoSize = true;
            this.cb_IncreaseCtrl.Location = new System.Drawing.Point(151, 73);
            this.cb_IncreaseCtrl.Name = "cb_IncreaseCtrl";
            this.cb_IncreaseCtrl.Size = new System.Drawing.Size(18, 17);
            this.cb_IncreaseCtrl.TabIndex = 0;
            this.cb_IncreaseCtrl.UseVisualStyleBackColor = true;
            this.cb_IncreaseCtrl.CheckedChanged += new System.EventHandler(this.IncreaseModifierChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = ":Quit from Penumbra";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = ":Show/Hide Settings";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = ":Toggle Filter";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = ":Decrease Filter Level";
            // 
            // lb_Key
            // 
            this.lb_Key.AutoSize = true;
            this.lb_Key.Location = new System.Drawing.Point(266, 27);
            this.lb_Key.Name = "lb_Key";
            this.lb_Key.Size = new System.Drawing.Size(37, 23);
            this.lb_Key.TabIndex = 0;
            this.lb_Key.Text = "Key";
            // 
            // lb_Alt
            // 
            this.lb_Alt.AutoSize = true;
            this.lb_Alt.Location = new System.Drawing.Point(217, 27);
            this.lb_Alt.Name = "lb_Alt";
            this.lb_Alt.Size = new System.Drawing.Size(31, 23);
            this.lb_Alt.TabIndex = 0;
            this.lb_Alt.Text = "Alt";
            // 
            // lb_Shift
            // 
            this.lb_Shift.AutoSize = true;
            this.lb_Shift.Location = new System.Drawing.Point(177, 27);
            this.lb_Shift.Name = "lb_Shift";
            this.lb_Shift.Size = new System.Drawing.Size(44, 23);
            this.lb_Shift.TabIndex = 0;
            this.lb_Shift.Text = "Shift";
            // 
            // lb_Ctrl
            // 
            this.lb_Ctrl.AutoSize = true;
            this.lb_Ctrl.Location = new System.Drawing.Point(143, 27);
            this.lb_Ctrl.Name = "lb_Ctrl";
            this.lb_Ctrl.Size = new System.Drawing.Size(37, 23);
            this.lb_Ctrl.TabIndex = 0;
            this.lb_Ctrl.Text = "Ctrl";
            // 
            // lb_Increase
            // 
            this.lb_Increase.Location = new System.Drawing.Point(6, 71);
            this.lb_Increase.Name = "lb_Increase";
            this.lb_Increase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Increase.Size = new System.Drawing.Size(134, 17);
            this.lb_Increase.TabIndex = 0;
            this.lb_Increase.Text = ":Increase Filter Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "____________________________________________________________";
            // 
            // gb_General
            // 
            this.gb_General.Controls.Add(this.label8);
            this.gb_General.Controls.Add(this.label9);
            this.gb_General.Controls.Add(this.lb_BrightnessLevel);
            this.gb_General.Controls.Add(this.tb_BrightnessLevel);
            this.gb_General.Controls.Add(this.lb_FilterLevelMax);
            this.gb_General.Controls.Add(this.lb_FilterLevelMin);
            this.gb_General.Controls.Add(this.cb_Filter);
            this.gb_General.Controls.Add(this.label6);
            this.gb_General.Controls.Add(this.lb_FilterLevel);
            this.gb_General.Controls.Add(this.tb_FilterLevel);
            this.gb_General.Location = new System.Drawing.Point(12, 12);
            this.gb_General.Name = "gb_General";
            this.gb_General.Size = new System.Drawing.Size(330, 161);
            this.gb_General.TabIndex = 0;
            this.gb_General.TabStop = false;
            this.gb_General.Text = "General";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(276, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "100%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(146, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "0%";
            // 
            // lb_BrightnessLevel
            // 
            this.lb_BrightnessLevel.Location = new System.Drawing.Point(0, 98);
            this.lb_BrightnessLevel.Name = "lb_BrightnessLevel";
            this.lb_BrightnessLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_BrightnessLevel.Size = new System.Drawing.Size(134, 17);
            this.lb_BrightnessLevel.TabIndex = 3;
            this.lb_BrightnessLevel.Text = ":Brightness";
            // 
            // tb_BrightnessLevel
            // 
            this.tb_BrightnessLevel.LargeChange = 0;
            this.tb_BrightnessLevel.Location = new System.Drawing.Point(143, 98);
            this.tb_BrightnessLevel.Maximum = 100;
            this.tb_BrightnessLevel.Name = "tb_BrightnessLevel";
            this.tb_BrightnessLevel.Size = new System.Drawing.Size(177, 56);
            this.tb_BrightnessLevel.TabIndex = 2;
            this.tb_BrightnessLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_BrightnessLevel.Scroll += new System.EventHandler(this.tb_Brightness_Scroll);
            // 
            // lb_FilterLevelMax
            // 
            this.lb_FilterLevelMax.AutoSize = true;
            this.lb_FilterLevelMax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_FilterLevelMax.Location = new System.Drawing.Point(276, 76);
            this.lb_FilterLevelMax.Name = "lb_FilterLevelMax";
            this.lb_FilterLevelMax.Size = new System.Drawing.Size(44, 19);
            this.lb_FilterLevelMax.TabIndex = 2;
            this.lb_FilterLevelMax.Text = "100%";
            // 
            // lb_FilterLevelMin
            // 
            this.lb_FilterLevelMin.AutoSize = true;
            this.lb_FilterLevelMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_FilterLevelMin.Location = new System.Drawing.Point(146, 76);
            this.lb_FilterLevelMin.Name = "lb_FilterLevelMin";
            this.lb_FilterLevelMin.Size = new System.Drawing.Size(28, 19);
            this.lb_FilterLevelMin.TabIndex = 2;
            this.lb_FilterLevelMin.Text = "0%";
            // 
            // cb_Filter
            // 
            this.cb_Filter.AutoSize = true;
            this.cb_Filter.Location = new System.Drawing.Point(149, 28);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(18, 17);
            this.cb_Filter.TabIndex = 0;
            this.cb_Filter.UseVisualStyleBackColor = true;
            this.cb_Filter.CheckedChanged += new System.EventHandler(this.cb_Filter_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = ":Filter Enable";
            // 
            // lb_FilterLevel
            // 
            this.lb_FilterLevel.Location = new System.Drawing.Point(9, 53);
            this.lb_FilterLevel.Name = "lb_FilterLevel";
            this.lb_FilterLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_FilterLevel.Size = new System.Drawing.Size(134, 17);
            this.lb_FilterLevel.TabIndex = 0;
            this.lb_FilterLevel.Text = ":Filter Level";
            // 
            // tb_FilterLevel
            // 
            this.tb_FilterLevel.LargeChange = 10;
            this.tb_FilterLevel.Location = new System.Drawing.Point(143, 53);
            this.tb_FilterLevel.Maximum = 100;
            this.tb_FilterLevel.Name = "tb_FilterLevel";
            this.tb_FilterLevel.Size = new System.Drawing.Size(177, 56);
            this.tb_FilterLevel.TabIndex = 1;
            this.tb_FilterLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_FilterLevel.Scroll += new System.EventHandler(this.tb_FilterLevel_Scroll);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 430);
            this.Controls.Add(this.gb_General);
            this.Controls.Add(this.gb_Hotkeys);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penumbra Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.gb_Hotkeys.ResumeLayout(false);
            this.gb_Hotkeys.PerformLayout();
            this.gb_General.ResumeLayout(false);
            this.gb_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BrightnessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FilterLevel)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_Hotkeys;
		private System.Windows.Forms.Label lb_Increase;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cb_QuitAlt;
		private System.Windows.Forms.CheckBox cb_SettingsAlt;
		private System.Windows.Forms.CheckBox cb_ToggleAlt;
		private System.Windows.Forms.CheckBox cb_DecreaseAlt;
		private System.Windows.Forms.CheckBox cb_IncreaseAlt;
		private System.Windows.Forms.CheckBox cb_QuitShift;
		private System.Windows.Forms.CheckBox cb_SettingsShift;
		private System.Windows.Forms.CheckBox cb_ToggleShift;
		private System.Windows.Forms.CheckBox cb_DecreaseShift;
		private System.Windows.Forms.CheckBox cb_QuitCtrl;
		private System.Windows.Forms.CheckBox cb_SettingsCtrl;
		private System.Windows.Forms.CheckBox cb_ToggleCtrl;
		private System.Windows.Forms.CheckBox cb_DecreaseCtrl;
		private System.Windows.Forms.CheckBox cb_IncreaseShift;
		private System.Windows.Forms.CheckBox cb_IncreaseCtrl;
		private System.Windows.Forms.Label lb_Key;
		private System.Windows.Forms.Label lb_Alt;
		private System.Windows.Forms.Label lb_Shift;
		private System.Windows.Forms.Label lb_Ctrl;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_General;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TrackBar tb_FilterLevel;
		public System.Windows.Forms.CheckBox cb_Filter;
		private System.Windows.Forms.ComboBox cb_IncreaseKey;
		private System.Windows.Forms.ComboBox cb_QuitKey;
		private System.Windows.Forms.ComboBox cb_SettingsKey;
		private System.Windows.Forms.ComboBox cb_ToggleKey;
		private System.Windows.Forms.ComboBox cb_DecreaseKey;
		private System.Windows.Forms.Label lb_FilterLevelMax;
		private System.Windows.Forms.Label lb_FilterLevelMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TrackBar tb_BrightnessLevel;
        public System.Windows.Forms.Label lb_FilterLevel;
        public System.Windows.Forms.Label lb_BrightnessLevel;



	}
}