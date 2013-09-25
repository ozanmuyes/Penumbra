using System;
using System.Windows.Forms;

namespace Penumbra.Windows
{

	public partial class SettingsWindow : Form
	{

#region Properties

		// If InternalChangeInProgress is set to True immediately ignore all on-change-save events
		public bool InternalChangeInProgress { get; set; }

#endregion

#region Ctors

		public SettingsWindow()
		{

			InitializeComponent();

		}

#endregion

#region Private Functions

		private void LoadSettings()
		{

			InternalChangeInProgress = true;

			cb_Filter.Checked = tb_FilterLevel.Enabled = Program.Filtering;
			tb_FilterLevel.Value = Program.m_INI.ReadInteger(@"Filter", @"level");
			
			cb_IncreaseCtrl.Checked = (Program.m_HotkeyIncrease.Control);
			cb_IncreaseShift.Checked = (Program.m_HotkeyIncrease.Shift);
			cb_IncreaseAlt.Checked = (Program.m_HotkeyIncrease.Alt);
			cb_IncreaseKey.Text = Program.m_HotkeyIncrease.Key.ToString();

			cb_DecreaseCtrl.Checked = (Program.m_HotkeyDecrease.Control);
			cb_DecreaseShift.Checked = (Program.m_HotkeyDecrease.Shift);
			cb_DecreaseAlt.Checked = (Program.m_HotkeyDecrease.Alt);
			cb_DecreaseKey.Text = Program.m_HotkeyDecrease.Key.ToString();

			cb_ToggleCtrl.Checked = (Program.m_HotkeyToggle.Control);
			cb_ToggleShift.Checked = (Program.m_HotkeyToggle.Shift);
			cb_ToggleAlt.Checked = (Program.m_HotkeyToggle.Alt);
			cb_ToggleKey.Text = Program.m_HotkeyToggle.Key.ToString();

			cb_SettingsCtrl.Checked = (Program.m_HotkeySettings.Control);
			cb_SettingsShift.Checked = (Program.m_HotkeySettings.Shift);
			cb_SettingsAlt.Checked = (Program.m_HotkeySettings.Alt);
			cb_SettingsKey.Text = Program.m_HotkeySettings.Key.ToString();

			cb_QuitCtrl.Checked = (Program.m_HotkeyQuit.Control);
			cb_QuitShift.Checked = (Program.m_HotkeyQuit.Shift);
			cb_QuitAlt.Checked = (Program.m_HotkeyQuit.Alt);
			cb_QuitKey.Text = Program.m_HotkeyQuit.Key.ToString();

			InternalChangeInProgress = false;

		}

#endregion

#region Overrides

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			
			base.OnClosing(e);

			e.Cancel = true;

			Visible = false;

		}

#endregion

#region Class Functions

		private void SettingsWindow_Load(object sender, EventArgs e)
		{

			LoadSettings();

		}

		// On-change-save Events
		//
		private void cb_Filter_CheckedChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			Program.ToggleFilter();

			tb_FilterLevel.Enabled = Program.Filtering;

		}

		private void tb_FilterLevel_Scroll(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			Program.SetBrightness(tb_FilterLevel.Value);

		}

		private void IncreaseModifierChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			string c_Key = cb_DecreaseKey.Text;
			int c_NumericKey;

			if (int.TryParse(c_Key, out c_NumericKey))
				c_Key = "D" + c_NumericKey;

			string c_HotkeyString = (cb_IncreaseCtrl.Checked ? "1" : "0") + "|" +
							  (cb_IncreaseShift.Checked ? "1" : "0") + "|" +
							  (cb_IncreaseAlt.Checked ? "1" : "0") + "|" +
							  c_Key;

			Program.m_HotkeyIncrease.Alter(c_HotkeyString);

			Program.m_INI.WriteValue(@"Hotkeys", @"increase", c_HotkeyString);

		}

		private void DecreaseModifierChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			string c_Key = cb_DecreaseKey.Text;
			int c_NumericKey;

			if (int.TryParse(c_Key, out c_NumericKey))
				c_Key = "D" + c_NumericKey;

			string c_HotkeyString = (cb_DecreaseCtrl.Checked ? "1" : "0") + "|" +
							  (cb_DecreaseShift.Checked ? "1" : "0") + "|" +
							  (cb_DecreaseAlt.Checked ? "1" : "0") + "|" +
							  c_Key;

			Program.m_HotkeyDecrease.Alter(c_HotkeyString);

			Program.m_INI.WriteValue(@"Hotkeys", @"decrease", c_HotkeyString);

		}

		private void ToggleModifierChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			string c_Key = cb_DecreaseKey.Text;
			int c_NumericKey;

			if (int.TryParse(c_Key, out c_NumericKey))
				c_Key = "D" + c_NumericKey;

			string c_HotkeyString = (cb_ToggleCtrl.Checked ? "1" : "0") + "|" +
							  (cb_ToggleShift.Checked ? "1" : "0") + "|" +
							  (cb_ToggleAlt.Checked ? "1" : "0") + "|" +
							  c_Key;

			Program.m_HotkeyToggle.Alter(c_HotkeyString);

			Program.m_INI.WriteValue(@"Hotkeys", @"toggle", c_HotkeyString);

		}

		private void SettingsModifierChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			string c_Key = cb_DecreaseKey.Text;
			int c_NumericKey;

			if (int.TryParse(c_Key, out c_NumericKey))
				c_Key = "D" + c_NumericKey;

			string c_HotkeyString = (cb_SettingsCtrl.Checked ? "1" : "0") + "|" +
							  (cb_SettingsShift.Checked ? "1" : "0") + "|" +
							  (cb_SettingsAlt.Checked ? "1" : "0") + "|" +
							  c_Key;

			Program.m_HotkeySettings.Alter(c_HotkeyString);

			Program.m_INI.WriteValue(@"Hotkeys", @"settings", c_HotkeyString);

		}

		private void QuitModifierChanged(object sender, EventArgs e)
		{

			if (InternalChangeInProgress)
				return;

			string c_Key = cb_DecreaseKey.Text;
			int c_NumericKey;

			if (int.TryParse(c_Key, out c_NumericKey))
				c_Key = "D" + c_NumericKey;

			string c_HotkeyString = (cb_QuitCtrl.Checked ? "1" : "0") + "|" +
							  (cb_QuitShift.Checked ? "1" : "0") + "|" +
							  (cb_QuitAlt.Checked ? "1" : "0") + "|" +
							  c_Key;

			Program.m_HotkeyQuit.Alter(c_HotkeyString);

			Program.m_INI.WriteValue(@"Hotkeys", @"quit", c_HotkeyString);

		}

#endregion

	}

}
