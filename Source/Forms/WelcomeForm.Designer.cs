namespace TimeTasker {
	partial class WelcomeForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.chkShowWelcome = new System.Windows.Forms.CheckBox();
            this.lblAppname = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnProceed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(110, 236);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // chkShowWelcome
            // 
            this.chkShowWelcome.AutoSize = true;
            this.chkShowWelcome.Checked = true;
            this.chkShowWelcome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowWelcome.ForeColor = System.Drawing.Color.White;
            this.chkShowWelcome.Location = new System.Drawing.Point(12, 618);
            this.chkShowWelcome.Name = "chkShowWelcome";
            this.chkShowWelcome.Size = new System.Drawing.Size(121, 20);
            this.chkShowWelcome.TabIndex = 2;
            this.chkShowWelcome.Text = "Show on startup";
            this.chkShowWelcome.UseVisualStyleBackColor = true;
            this.chkShowWelcome.CheckedChanged += new System.EventHandler(this.chkShowWelcome_CheckedChanged);
            // 
            // lblAppname
            // 
            this.lblAppname.AutoSize = true;
            this.lblAppname.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppname.ForeColor = System.Drawing.Color.White;
            this.lblAppname.Location = new System.Drawing.Point(75, 134);
            this.lblAppname.Name = "lblAppname";
            this.lblAppname.Size = new System.Drawing.Size(201, 40);
            this.lblAppname.TabIndex = 3;
            this.lblAppname.Text = "Time Tasker";
            // 
            // btnProceed
            // 
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.Image = global::TimeTasker.Properties.Resources.ProceedIconDefault;
            this.btnProceed.Location = new System.Drawing.Point(289, 583);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(50, 50);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.TabStop = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(360, 650);
            this.Controls.Add(this.lblAppname);
            this.Controls.Add(this.chkShowWelcome);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnProceed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.PictureBox btnProceed;
		private System.Windows.Forms.CheckBox chkShowWelcome;
		private System.Windows.Forms.Label lblAppname;
	}
}