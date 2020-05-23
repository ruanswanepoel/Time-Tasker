
using System.Drawing;

namespace TimeTasker {

	public static class Colors {

		private const int c_BLUE = 0x785781ad;
		private const int c_RED = 0x78ad4b4b;

		
		public static Color Light => Color.FromArgb(255, 255, 255);
		public static Color Dark => Color.FromArgb(50, 50, 50);
		public static Color Blue => Color.FromArgb(70, 125, 176);
		public static Color Red => Color.FromArgb(145, 49, 49);

		public static Color TextColor {
			get {
				if (Settings.Darkmode)
					return Color.White;
				else
					return Color.Black;
			}
		}


		public static Color FromName(string name) {

			Color color = Blue;

			switch (name) {
				case "Blue": {
					color = Blue;
					break;
				}
				case "Red": {
					color = Red;
					break;
				}
			}

			return color;

		}

	}

}
