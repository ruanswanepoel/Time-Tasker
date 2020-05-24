
using System.Drawing;
using System.Windows.Forms;


namespace TimeTasker {

	/// <summary>
	/// Manages the Application forms.
	/// </summary>
	public static class FormManager {

		/// <summary>
		/// Loads a new <c>Form</c>.
		/// </summary>
		/// <param name="form">The <c>Form</c> to load.</param>
		public static void LoadForm(Form form) {

			form.Show();

		}

		/// <summary>
		/// Loads a new <c>Form</c> and hides the current.
		/// </summary>
		/// <param name="current">The <c>Form</c> that called this method.</param>
		/// <param name="form">The <c>Form</c> to load.</param>
		/// <remarks>
		/// This is an extension method for the `Form` class.
		/// </remarks>
		public static void LoadForm(this Form current, Form form) {

			form.Show();
			current.Close();

		}

		/// <summary>
		/// Returns a slightly darkened <c>Bitmap</c> of the current <c>Form</c>
		/// </summary>
		/// <param name="current">The <c>Form</c> that called this method.</param>
		/// <returns>A slightly darkened <c>Bitmap</c> of the current <c>Form</c></returns>
		/// <remarks>
		/// This is an extension method for the `Form` class.
		/// </remarks>
		public static Bitmap DarkenedBitmapFromForm(this Form current) {

			Bitmap bitmap = new Bitmap(current.Width, current.Height);
			current.DrawToBitmap(bitmap, new Rectangle(0, 0, current.Width, current.Height));

			//for (int i = 0; i < bitmap.Width; i += 2) {
			//	for (int j = 0; j < bitmap.Height; j += 2) {
			//		bitmap.SetPixel(i, j, Color.Black);
			//	}
			//}

			for (int i = 0; i < bitmap.Width; i++) {
				for (int j = 0; j < bitmap.Height; j++) {
					Color color = bitmap.GetPixel(i, j);
					bitmap.SetPixel(i, j, Color.FromArgb((int)(color.R * 0.3), (int)(color.G * 0.3), (int)(color.B * 0.3)));
				}
			}

			return bitmap;

		}

	}

}
