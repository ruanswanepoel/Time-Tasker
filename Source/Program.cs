
using System;
using System.Windows.Forms;


namespace TimeTasker {

	static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Settings.Initialize();

			Form startForm = (Form)Activator.CreateInstance(Settings.StartupFormType);
			FormManager.LoadForm(startForm);

			Application.Run();

		}

	}

}
