
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TimeTasker {

	public static class Colors {
		
		public static Color Light => Color.FromArgb(255, 255, 255);
		public static Color Dark => Color.FromArgb(50, 50, 50);
		public static Color Blue => Color.FromArgb(70, 125, 176);
		public static Color Red => Color.FromArgb(145, 49, 49);
		public static Color Yellow => Color.FromArgb(255, 255, 136);

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

		public static LinearGradientBrush GetTitleGradient() {

			Point startPoint = new Point(50, 10);
			Point endPoint = new Point(360, 10);
			Color colour1 = Color.FromArgb(255, 0, 126, 230);  // #007EE6
			Color colour2 = Color.FromArgb(255, 35, 146, 236); // #2392EC
			Color colour3 = Color.FromArgb(255, 85, 174, 246); // #55AEF6

			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(startPoint, endPoint, colour1, colour2);

			ColorBlend colourBlend = new ColorBlend(3);
			colourBlend.Colors = new Color[3] { colour1, colour2, colour3 };
			colourBlend.Positions = new float[3] { 0f, 0.5f, 1f };

			linearGradientBrush.InterpolationColors = colourBlend;

			return linearGradientBrush;

			//e.Graphics.FillRectangle(linearGradientBrush, 0, 0, 360, 50);

		}

	}

}
