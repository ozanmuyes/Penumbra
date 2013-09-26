namespace PU_Bridge
{

	/// <summary>
	/// This class will use for Penumbra and Windows communication.
	/// </summary>
	public static class Bridge
	{

#region Variables

		private static Window m_Window;

#endregion

#region Public Functions

		public static bool Initialize()
		{

			m_Window = new Window();

			return true;

		}

#endregion
	}

}
