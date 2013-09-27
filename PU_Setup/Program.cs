using System;
using System.Windows.Forms;
using PU_Setup.Windows;

namespace PU_Setup
{

	static class Program
	{

#region Ctors

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new Install());

		}

#endregion

	}

}
