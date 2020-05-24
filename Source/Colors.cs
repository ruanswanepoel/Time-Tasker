
using System.Drawing;


namespace TimeTasker {

	public static class Colors {
		
		public static Color Light => Color.FromArgb(200, 200, 200);
		public static Color Dark => Color.FromArgb(50, 50, 50);
		public static Color Blue => Color.FromArgb(70, 125, 176);
		public static Color Red => Color.FromArgb(145, 49, 49);
		public static Color Yellow => Color.FromArgb(189, 191, 63);

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
				case "Yellow": {
					color = Yellow;
					break;
				}
			}

			return color;

		}

	}

}
