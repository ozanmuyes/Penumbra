using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Penumbra.Classes
{

	class INI
	{

#region Consts

		private const int MAX_VALUE_LENGTH = 255;

#endregion

#region Imports
// ReSharper disable InconsistentNaming

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size,string filePath);

// ReSharper restore InconsistentNaming
#endregion

#region Variables

		private string m_Path;

#endregion

#region Ctors

		/// <summary>
		/// INIFile Constructor.
		/// </summary>
		/// <PARAM name="p_INIPath"></PARAM>
		public INI(string p_INIPath)
		{

			if (!Path.IsPathRooted(p_INIPath))
				m_Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar + p_INIPath;
			else
				m_Path = p_INIPath;

			if (!File.Exists(m_Path))
				Setup.ExtractResource(@"settings.ini", Directory.GetParent(m_Path).ToString());

		}

#endregion

#region Public Functions

		/// <summary>
		/// Write Data to the INI File
		/// </summary>
		/// <PARAM name="p_Section"></PARAM>
		/// Section name
		/// <PARAM name="p_Key"></PARAM>
		/// Key Name
		/// <PARAM name="p_Value"></PARAM>
		/// Value Name
		public void WriteValue(string p_Section, string p_Key, string p_Value)
		{

			WritePrivateProfileString(p_Section, p_Key, p_Value, m_Path);

		}
		
		/// <summary>
		/// Read Data Value From the Ini File
		/// </summary>
		/// <PARAM name="p_Section"></PARAM>
		/// <PARAM name="p_Key"></PARAM>
		/// <PARAM name="Path"></PARAM>
		/// <returns></returns>
		public string ReadString(string p_Section, string p_Key)
		{

			StringBuilder c_Temp = new StringBuilder(MAX_VALUE_LENGTH);

			GetPrivateProfileString(p_Section, p_Key, "", c_Temp, MAX_VALUE_LENGTH, m_Path);

			return c_Temp.ToString();

		}

		public bool ReadBoolean(string p_Section, string p_Key)
		{

			StringBuilder c_Temp = new StringBuilder(MAX_VALUE_LENGTH);

			GetPrivateProfileString(p_Section, p_Key, "", c_Temp, MAX_VALUE_LENGTH, m_Path);

			return (c_Temp.ToString() == "1");

		}

		public int ReadInteger(string p_Section, string p_Key)
		{

			StringBuilder c_Temp = new StringBuilder(MAX_VALUE_LENGTH);

			GetPrivateProfileString(p_Section, p_Key, "", c_Temp, MAX_VALUE_LENGTH, m_Path);

			return int.Parse(c_Temp.ToString());

		}

#endregion

	}

}
