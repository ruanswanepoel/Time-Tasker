
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;


namespace TimeTasker {

	/// <summary>
	/// Handles all the AppData for the Application.
	/// </summary>
	public static class Settings {

		private const string c_RESOURCES_FOLDER = "Resources\\";
		private const string c_APPDATA_FOLDER = "Appdata\\";
		private const string c_TASK_DATA_FILE = "taskdata.json";

		private static int startupListIndex = -1;


		public static string Dir => Directory.GetCurrentDirectory() + "\\";
		public static string Resources => Dir + c_RESOURCES_FOLDER;
		public static string Appdata => Resources + c_APPDATA_FOLDER;
		public static string TaskDataFile => Appdata + c_TASK_DATA_FILE;

		public static List<TaskList> Lists { get; private set; }


		/// <summary>
		/// Initializes, verifies and loads all Appdata
		/// </summary>
		public static void Initialize() {

			VerifyAppdata();
			LoadTaskData();

		}

		/// <summary>
		/// Gets the last <see cref="TaskList"/> that was open in the previous session.
		/// </summary>
		/// <returns>The startup <see cref="TaskList"/>.</returns>
		public static TaskList GetStartupList() {

			if (startupListIndex == -1)
				return null;

			return Lists[startupListIndex];

		}

		private static void VerifyAppdata() {

			// TODO: Check data integrity properly

			Directory.CreateDirectory(Appdata);

		}

		private static void LoadTaskData() {

			string raw_data = File.ReadAllText(TaskDataFile);
			JObject json = JObject.Parse(raw_data);

			startupListIndex = json["StartupList"].ToObject<int>();

			Lists = new List<TaskList>();
			foreach (JToken token in json["Tasklists"])
				Lists.Add(new TaskList(token));

		}

	}

}
