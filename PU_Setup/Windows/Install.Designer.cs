namespace PU_Setup.Windows
{
	partial class Install
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
			this.lb_Welcome = new System.Windows.Forms.Label();
			this.lb_Information = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_InstallPath = new System.Windows.Forms.TextBox();
			this.bt_InstallPath = new System.Windows.Forms.Button();
			this.cb_StartWindows = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bt_Install = new System.Windows.Forms.Button();
			this.bt_Exit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ds_InstallPath = new System.DirectoryServices.DirectorySearcher();
			this.cb_StartAfterSetupComplete = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lb_Welcome
			// 
			this.lb_Welcome.AutoSize = true;
			this.lb_Welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Welcome.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lb_Welcome.Location = new System.Drawing.Point(16, 14);
			this.lb_Welcome.Name = "lb_Welcome";
			this.lb_Welcome.Size = new System.Drawing.Size(323, 30);
			this.lb_Welcome.TabIndex = 0;
			this.lb_Welcome.Text = "Welcome to Penumbra Installer";
			// 
			// lb_Information
			// 
			this.lb_Information.AutoSize = true;
			this.lb_Information.Location = new System.Drawing.Point(18, 47);
			this.lb_Information.Name = "lb_Information";
			this.lb_Information.Size = new System.Drawing.Size(495, 17);
			this.lb_Information.TabIndex = 1;
			this.lb_Information.Text = "The screen filter software for protect your eyes while working on computer at nig" +
    "ht.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please choose install location:";
			// 
			// tb_InstallPath
			// 
			this.tb_InstallPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tb_InstallPath.Location = new System.Drawing.Point(21, 118);
			this.tb_InstallPath.Name = "tb_InstallPath";
			this.tb_InstallPath.Size = new System.Drawing.Size(380, 22);
			this.tb_InstallPath.TabIndex = 1;
			this.tb_InstallPath.TextChanged += new System.EventHandler(this.tb_InstallPath_TextChanged);
			// 
			// bt_InstallPath
			// 
			this.bt_InstallPath.Location = new System.Drawing.Point(407, 117);
			this.bt_InstallPath.Name = "bt_InstallPath";
			this.bt_InstallPath.Size = new System.Drawing.Size(33, 23);
			this.bt_InstallPath.TabIndex = 2;
			this.bt_InstallPath.Text = "...";
			this.bt_InstallPath.UseVisualStyleBackColor = true;
			// 
			// cb_StartWindows
			// 
			this.cb_StartWindows.AutoSize = true;
			this.cb_StartWindows.Checked = true;
			this.cb_StartWindows.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_StartWindows.Location = new System.Drawing.Point(21, 149);
			this.cb_StartWindows.Name = "cb_StartWindows";
			this.cb_StartWindows.Size = new System.Drawing.Size(138, 21);
			this.cb_StartWindows.TabIndex = 3;
			this.cb_StartWindows.Text = "Start with Windows";
			this.cb_StartWindows.UseVisualStyleBackColor = true;
			this.cb_StartWindows.CheckedChanged += new System.EventHandler(this.cb_StartWindows_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Location = new System.Drawing.Point(10, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(524, 1);
			this.panel1.TabIndex = 5;
			// 
			// bt_Install
			// 
			this.bt_Install.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Install.Location = new System.Drawing.Point(457, 283);
			this.bt_Install.Name = "bt_Install";
			this.bt_Install.Size = new System.Drawing.Size(75, 27);
			this.bt_Install.TabIndex = 0;
			this.bt_Install.Text = "&Install >>";
			this.bt_Install.UseVisualStyleBackColor = true;
			this.bt_Install.Click += new System.EventHandler(this.bt_Install_Click);
			// 
			// bt_Exit
			// 
			this.bt_Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Exit.Location = new System.Drawing.Point(376, 283);
			this.bt_Exit.Name = "bt_Exit";
			this.bt_Exit.Size = new System.Drawing.Size(75, 27);
			this.bt_Exit.TabIndex = 5;
			this.bt_Exit.Text = "&Exit";
			this.bt_Exit.UseVisualStyleBackColor = true;
			this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Location = new System.Drawing.Point(10, 269);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(524, 1);
			this.panel2.TabIndex = 6;
			// 
			// ds_InstallPath
			// 
			this.ds_InstallPath.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.ds_InstallPath.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.ds_InstallPath.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// cb_StartAfterSetupComplete
			// 
			this.cb_StartAfterSetupComplete.AutoSize = true;
			this.cb_StartAfterSetupComplete.Checked = true;
			this.cb_StartAfterSetupComplete.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_StartAfterSetupComplete.Location = new System.Drawing.Point(21, 176);
			this.cb_StartAfterSetupComplete.Name = "cb_StartAfterSetupComplete";
			this.cb_StartAfterSetupComplete.Size = new System.Drawing.Size(183, 21);
			this.cb_StartAfterSetupComplete.TabIndex = 4;
			this.cb_StartAfterSetupComplete.Text = "Start After Setup Complete";
			this.cb_StartAfterSetupComplete.UseVisualStyleBackColor = true;
			this.cb_StartAfterSetupComplete.CheckedChanged += new System.EventHandler(this.cb_StartAfterSetupComplete_CheckedChanged);
			// 
			// Install
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 322);
			this.Controls.Add(this.bt_Install);
			this.Controls.Add(this.bt_Exit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cb_StartAfterSetupComplete);
			this.Controls.Add(this.cb_StartWindows);
			this.Controls.Add(this.bt_InstallPath);
			this.Controls.Add(this.tb_InstallPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_Information);
			this.Controls.Add(this.lb_Welcome);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Install";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Penumbra Install";
			this.Load += new System.EventHandler(this.Install_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_Welcome;
		private System.Windows.Forms.Label lb_Information;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bt_InstallPath;
		private System.Windows.Forms.TextBox tb_InstallPath;
		private System.Windows.Forms.CheckBox cb_StartWindows;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bt_Exit;
		private System.Windows.Forms.Button bt_Install;
		private System.Windows.Forms.Panel panel2;
		private System.DirectoryServices.DirectorySearcher ds_InstallPath;
		private System.Windows.Forms.CheckBox cb_StartAfterSetupComplete;
	}
}