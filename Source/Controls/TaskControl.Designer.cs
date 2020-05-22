namespace TimeTasker {
	partial class TaskControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblText = new System.Windows.Forms.Label();
			this.btnCheckbox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.btnCheckbox)).BeginInit();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.Location = new System.Drawing.Point(0, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(280, 40);
			this.lblText.TabIndex = 2;
			this.lblText.Text = "My task to complete";
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblText.Click += new System.EventHandler(this.lblText_Click);
			// 
			// btnCheckbox
			// 
			this.btnCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCheckbox.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
			this.btnCheckbox.Location = new System.Drawing.Point(280, 0);
			this.btnCheckbox.Name = "btnCheckbox";
			this.btnCheckbox.Size = new System.Drawing.Size(40, 40);
			this.btnCheckbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnCheckbox.TabIndex = 3;
			this.btnCheckbox.TabStop = false;
			this.btnCheckbox.Click += new System.EventHandler(this.btnCheckbox_Click);
			// 
			// TaskControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Controls.Add(this.btnCheckbox);
			this.Controls.Add(this.lblText);
			this.Name = "TaskControl";
			this.Size = new System.Drawing.Size(320, 40);
			((System.ComponentModel.ISupportInitialize)(this.btnCheckbox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.PictureBox btnCheckbox;
	}
}
