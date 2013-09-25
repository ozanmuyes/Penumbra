using System.Reflection;

namespace PU_Keyboard
{

	public static class Plugin
	{

		public static string GetVersion()
		{

			return Assembly.GetExecutingAssembly().GetName().Version.ToString();

		}

	}

}
