using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Media_Player
{
	static class Program
	{
		public static bool IsElevated
		{
			get
			{
				return WindowsIdentity.GetCurrent().Owner.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid);
			}
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string fileName = null;

			if (args != null && args.Length > 0)
			{
				if (args[0] == "fileassoc")
				{
					//using (var hkcr = Registry.ClassesRoot)

				}
				else
				{
					fileName = args[0];
				}
			}
			Application.Run(new Form1(fileName));
		}
	}
}
