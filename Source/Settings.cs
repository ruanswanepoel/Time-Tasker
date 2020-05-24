
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace TimeTasker {

	/// <summary>
	/// Handles all the AppData for the Application.
	/// </summary>
	public static class Settings {

		private static readonly string dir = Directory.GetCurrentDirectory() + "\\";
		private static readonly string resources = dir + "Resources\\";
		private static readonly string appdata = resources + "Appdata\\";
		private static readonly string taskDataFile = appdata + "taskdata.json";
		private static readonly string userDataFile = appdata + "userdata.json";

		private static bool showWelcome = true;
		private static bool hideCompletedTasks = false;
		private static bool darkmode = false;
		private static string colorThemeName = "Blue";
		//private static Color colorTheme = default;
		
		private static int startupListIndex = -1;


		public static bool ShowWelcome {
			get => showWelcome;
			set {
				showWelcome = value;
				SaveUserData();
			}
		}

		public static bool HideCompletedTasks {
			get => hideCompletedTasks;
			set {
				hideCompletedTasks = value;
				SaveUserData();
			}
		}

		public static bool Darkmode {
			get => darkmode;
			set {
				darkmode = value;
				SaveUserData();
			}
		}

		public static Color MainColor {
			get => (darkmode) ? Colors.Dark : Colors.Light;
		}

		public static Color ColorTheme {
			get => Colors.FromName(colorThemeName);
		}

		public static Color TextColor {
			get => Colors.TextColor;
		}

		public static Type StartupFormType {
			get => (ShowWelcome) ? typeof(WelcomeForm) : typeof(TasksForm);
		}

		public static TaskList StartupList {
			get => Lists[startupListIndex];
		}

		public static List<TaskList> Lists { get; private set; }


		/// <summary>
		/// Initializes, verifies and loads all Appdata
		/// </summary>
		public static void Initialize() {

			VerifyAppdata();
			LoadTaskData();
			LoadUserData();

			SaveTaskData();

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

			string raw_data = File.ReadAllText(userDataFile);
			JObject json = JObject.Parse(raw_data);

			showWelcome = json["ShowWelcome"].ToObject<bool>();
			hideCompletedTasks = json["HideCompletedTasks"].ToObject<bool>();
			darkmode = json["Darkmode"].ToObject<bool>();
			colorThemeName = json["ColorTheme"].ToString();

		}

		public static void SaveTaskData() {

			string result = "{\n";
			result += "\"StartupList\": " + startupListIndex.ToString() + ",\n";
			result += "\"Tasklists\": [\n";

			for (int i = 0; i < Lists.Count; i++) {
				result += Lists[i].ToJson();
				if (i != Lists.Count - 1)
					result += ",";
				result += "\n";
			}

			result += "]\n}";

			File.WriteAllText(taskDataFile, result);

		}

		private static void SaveUserData() {

			string str1 = (ShowWelcome) ? "true" : "false";
			string str2 = (HideCompletedTasks) ? "true" : "false";
			string str3 = (Darkmode) ? "true" : "false";

			string result = "{\n";
			result += "\"ShowWelcome\": " + str1 + ",\n";
			result += "\"HideCompletedTasks\": " + str2 + ",\n";
			result += "\"Darkmode\": " + str3 + ",\n";
			result += "\"ColorTheme\": " + colorThemeName + ",\n";
			result += "}";

			File.WriteAllText(userDataFile, result);

		}

	}

}
