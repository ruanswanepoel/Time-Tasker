
using System;
using System.Collections.Generic;


namespace TimeTasker {

	public static class Settings {


		private const string c_TASK_DATA_PATH = "";

		private static List<TaskListControl> lists;


		static Settings() {

			lists = LoadTaskLists();

		}

		private static List<TaskListControl> LoadTaskLists() {

			// TODO: Load lists and tasks from a file
			return null;

		}

		public static List<TaskListControl> GetTaskLists() {

			return lists;

		}

		public static TaskListControl GetStartupList() {

			return null;

		}

	}

}
