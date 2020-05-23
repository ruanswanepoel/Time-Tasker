
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;


namespace TimeTasker {

	/// <summary>
	/// Handles all the AppData for the Application.
	/// </summary>
	public static class Settings {

		private static readonly string dir = Directory.GetCurrentDirectory() + "\\";
		public static readonly string resources = dir + "Resources\\";
		public static readonly string appdata = resources + "Appdata\\";
		public static readonly string taskDataFile = appdata + "taskdata.json";
		public static readonly string userDataFile = appdata + "userdata.json";

		private static int startupListIndex = -1;


		public static bool ShowWelcome {
			// TODO:
			get { return true; }
			set { }
		}

		public static Type StartupFormType {
			// TODO:
			get { return typeof(WelcomeForm); }
		}

		public static TaskList StartupList {
			get => (startupListIndex == -1) ? null : Lists[startupListIndex];
		}

		public static List<TaskList> Lists { get; private set; }


		/// <summary>
		/// Initializes, verifies and loads all Appdata
		/// </summary>
		public static void Initialize() {

			VerifyAppdata();
			LoadTaskData();
			LoadUserData();

		}

		private static void VerifyAppdata() {

			// TODO: Check data integrity properly

			Directory.CreateDirectory(appdata);

		}

		private static void LoadTaskData() {

			string raw_data = File.ReadAllText(taskDataFile);
			JObject json = JObject.Parse(raw_data);

			startupListIndex = json["StartupList"].ToObject<int>();

			Lists = new List<TaskList>();
			foreach (JToken token in json["Tasklists"])
				Lists.Add(new TaskList(token));

		}

		private static void LoadUserData() {

			// TODO:

		}

	}

}
