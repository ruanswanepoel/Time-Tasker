
namespace TimeTasker {
	partial class NotificationForm {
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
			this.pnlNavbar = new System.Windows.Forms.Panel();
			this.btnUserSettings = new System.Windows.Forms.PictureBox();
			this.btnCalendar = new System.Windows.Forms.PictureBox();
			this.btnTasks = new System.Windows.Forms.PictureBox();
			this.pnlNavbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlNavbar
			// 
			this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			this.pnlNavbar.Controls.Add(this.btnUserSettings);
			this.pnlNavbar.Controls.Add(this.btnCalendar);
			this.pnlNavbar.Controls.Add(this.btnTasks);
			this.pnlNavbar.Location = new System.Drawing.Point(0, 600);
			this.pnlNavbar.Name = "pnlNavbar";
			this.pnlNavbar.Size = new System.Drawing.Size(360, 50);
			this.pnlNavbar.TabIndex = 5;
			// 
			// btnUserSettings
			// 
			this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUserSettings.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
			this.btnUserSettings.Location = new System.Drawing.Point(240, 0);
			this.btnUserSettings.Name = "btnUserSettings";
			this.btnUserSettings.Size = new System.Drawing.Size(120, 50);
			this.btnUserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnUserSettings.TabIndex = 2;
			this.btnUserSettings.TabStop = false;
			this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
			// 
			// btnCalendar
			// 
			this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCalendar.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
			this.btnCalendar.Location = new System.Drawing.Point(120, 0);
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.Size = new System.Drawing.Size(120, 50);
			this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnCalendar.TabIndex = 1;
			this.btnCalendar.TabStop = false;
			// 
			// btnTasks
			// 
			this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTasks.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
			this.btnTasks.Location = new System.Drawing.Point(0, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(120, 50);
			this.btnTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnTasks.TabIndex = 0;
			this.btnTasks.TabStop = false;
			this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
			// 
			// NotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.pnlNavbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NotificationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CalendarForm";
			this.pnlNavbar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.PictureBox btnUserSettings;
		private System.Windows.Forms.PictureBox btnCalendar;
		private System.Windows.Forms.PictureBox btnTasks;
	}
}