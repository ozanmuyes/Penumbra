using System;
using System.Windows.Forms;
using PU_Setup.Classes;

namespace PU_Setup.Windows
{

	public partial class Install : Form
	{

#region Variables

		private bool m_LoadComplete;

#endregion

#region Ctors

		public Install()
		{

			InitializeComponent();

		}

#endregion

#region Class Functions

		private void Install_Load(object sender, EventArgs e)
		{

			Setup.Initialize();

			tb_InstallPath.Text = Setup.InstallPath;
			cb_StartWindows.Checked = Setup.StartWithWindows;
			cb_StartAfterSetupComplete.Checked = Setup.StartAfterSetupComplete;

			m_LoadComplete = true;

		}

		private void tb_InstallPath_TextChanged(object sender, EventArgs e)
		{

			if (!m_LoadComplete)
				return;

			Setup.InstallPath = tb_InstallPath.Text;

		}

		private void cb_StartWindows_CheckedChanged(object sender, EventArgs e)
		{

			if (!m_LoadComplete)
				return;

			Setup.StartWithWindows = cb_StartWindows.Checked;

		}

		private void cb_StartAfterSetupComplete_CheckedChanged(object sender, EventArgs e)
		{

			if (!m_LoadComplete)
				return;

			Setup.StartAfterSetupComplete = cb_StartAfterSetupComplete.Checked;

		}

		private void bt_Exit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show(@"Are you sure you want to cancel the installation?", @"Cancel Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();

		}

		private void bt_Install_Click(object sender, EventArgs e)
		{

			Setup.Install();

		}

#endregion

	}

}
