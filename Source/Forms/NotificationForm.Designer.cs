
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
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlNavbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).BeginInit();
			this.pnlTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlNavbar
			// 
			this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
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
			this.btnUserSettings.BackColor = System.Drawing.Color.Transparent;
			this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUserSettings.Image = global::TimeTasker.Properties.Resources.SettingsIconDefault;
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
			this.btnCalendar.BackColor = System.Drawing.Color.White;
			this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCalendar.Image = global::TimeTasker.Properties.Resources.BellIconSelected;
			this.btnCalendar.Location = new System.Drawing.Point(120, 0);
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.Size = new System.Drawing.Size(120, 50);
			this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnCalendar.TabIndex = 1;
			this.btnCalendar.TabStop = false;
			// 
			// btnTasks
			// 
			this.btnTasks.BackColor = System.Drawing.Color.Transparent;
			this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTasks.Image = global::TimeTasker.Properties.Resources.TasksIconDefault;
			this.btnTasks.Location = new System.Drawing.Point(0, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(120, 50);
			this.btnTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnTasks.TabIndex = 0;
			this.btnTasks.TabStop = false;
			this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(360, 50);
			this.pnlTitle.TabIndex = 6;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(50, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(260, 50);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Notifications";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(50, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 50);
			this.label1.TabIndex = 5;
			this.label1.Text = "There are no notifications";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnlTitle);
			this.Controls.Add(this.pnlNavbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NotificationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CalendarForm";
			this.pnlNavbar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
			this.pnlTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.PictureBox btnUserSettings;
		private System.Windows.Forms.PictureBox btnCalendar;
		private System.Windows.Forms.PictureBox btnTasks;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label1;
	}
}