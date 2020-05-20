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
			this.chkComplete = new System.Windows.Forms.CheckBox();
			this.lblText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkComplete
			// 
			this.chkComplete.BackColor = System.Drawing.Color.Transparent;
			this.chkComplete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkComplete.Location = new System.Drawing.Point(314, 0);
			this.chkComplete.Name = "chkComplete";
			this.chkComplete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkComplete.Size = new System.Drawing.Size(26, 40);
			this.chkComplete.TabIndex = 1;
			this.chkComplete.UseVisualStyleBackColor = false;
			// 
			// lblText
			// 
			this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.Location = new System.Drawing.Point(0, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(308, 40);
			this.lblText.TabIndex = 2;
			this.lblText.Text = "My task to complete";
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblText.Click += new System.EventHandler(this.lblText_Click);
			// 
			// TaskControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.chkComplete);
			this.Name = "TaskControl";
			this.Size = new System.Drawing.Size(340, 40);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox chkComplete;
		private System.Windows.Forms.Label lblText;
	}
}
