using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PU_Setup.Classes
{

	static class Setup
	{

#region Consts

		private const string RESOURCE_FILE_NAME = @"Resources";

#endregion

#region Variables

		private static string m_InstallPath;

#endregion

#region Properties

		public static string InstallPath
		{

			get { return m_InstallPath; }

			set
			{

				m_InstallPath = value;

				if (!m_InstallPath.EndsWith(Path.DirectorySeparatorChar.ToString(CultureInfo.InvariantCulture)))
					m_InstallPath += Path.DirectorySeparatorChar;

			}

		}

		public static bool StartWithWindows { get; set; }

		public static bool StartAfterSetupComplete { get; set; }

#endregion

#region Public Functions

		public static void Initialize()
		{

			InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar +
			             "Penumbra";

			StartWithWindows = true;

			StartAfterSetupComplete = true;

		}

		public static void Install()
		{

			if (!Directory.Exists(InstallPath))
				Directory.CreateDirectory(InstallPath);

			ExtractExecutable(@"Penumbra.exe", InstallPath);
			ExtractExecutable(@"PU_Keyboard.dll", InstallPath);
			ExtractExecutable(@"PU_Bridge.dll", InstallPath);
			ExtractResource(@"settings.ini", InstallPath);

			if (StartWithWindows)
				SetStartup();
				
			MessageBox.Show(@"Installation is complete.", @"Penumbra Install", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if (StartAfterSetupComplete)
			{

				ProcessStartInfo c_Penumbra = new ProcessStartInfo(InstallPath + @"Penumbra.exe");
				Process.Start(c_Penumbra);

			}

			Application.Exit();

		}

		/// <summary>
		/// Search for the specified executable name and extracts it to the specified path when found on resource.
		/// </summary>
		/// <param name="p_ResourceName">Name of the file that will be extracted (extension included).</param>
		/// <param name="p_ExtractionPath">Extract destination path (file name excluded).</param>
		/// <returns>Size of the executable that extracted.</returns>
		public static int ExtractResource(string p_ResourceName, string p_ExtractionPath)
		{

			Assembly c_ThisAssembly = Assembly.GetExecutingAssembly();

			Stream c_ExecutableStream =
				c_ThisAssembly.GetManifestResourceStream(c_ThisAssembly.GetName().Name + @"." + RESOURCE_FILE_NAME + @"." +
				                                         p_ResourceName);

			if (c_ExecutableStream == null)
				return 0;

			byte[] c_ExecutableBytes = new byte[c_ExecutableStream.Length];
			c_ExecutableStream.Read(c_ExecutableBytes, 0, c_ExecutableBytes.Length);
			c_ExecutableStream.Close();

			File.WriteAllBytes(
				p_ExtractionPath.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar + p_ResourceName,
				c_ExecutableBytes);

			return c_ExecutableBytes.Length;

		}

#endregion

#region Private Functions

		/// <summary>
		/// Search for the specified executable name and extracts it to the specified path when found on resource.
		/// </summary>
		/// <param name="p_ExecutableName">Name of the file that will be extracted (extension included).</param>
		/// <param name="p_ExtractionPath">Extract destination path (file name excluded).</param>
		/// <returns>Size of the executable that extracted.</returns>
		private static int ExtractExecutable(string p_ExecutableName, string p_ExtractionPath)
		{

			Assembly c_ThisAssembly = Assembly.GetExecutingAssembly();

			Stream c_ExecutableStream =
				c_ThisAssembly.GetManifestResourceStream(c_ThisAssembly.GetName().Name + @"." + RESOURCE_FILE_NAME + @"." +
														 p_ExecutableName);

			if (c_ExecutableStream == null)
				return 0;

			byte[] c_ExecutableBytes = new byte[c_ExecutableStream.Length];
			c_ExecutableStream.Read(c_ExecutableBytes, 0, c_ExecutableBytes.Length);
			c_ExecutableStream.Close();

			File.WriteAllBytes(
				p_ExtractionPath.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar + p_ExecutableName,
				c_ExecutableBytes);

			return c_ExecutableBytes.Length;

		}

		private static void SetStartup()
		{

			RegistryKey c_RegistryKey = Registry.CurrentUser.OpenSubKey
				("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (c_RegistryKey != null)
				c_RegistryKey.SetValue(@"Penumbra", InstallPath + @"Penumbra.exe");

		}

#endregion

	}

}
