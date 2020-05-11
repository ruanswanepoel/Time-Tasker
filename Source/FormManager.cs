
using System;
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

	}

}
