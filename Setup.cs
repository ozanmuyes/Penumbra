using System.IO;
using System.Reflection;

namespace Penumbra
{

	static class Setup
	{

#region Consts

		private const string RESOURCE_FILE_NAME = @"Resources";

#endregion

#region Public Functions

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

	}

}
