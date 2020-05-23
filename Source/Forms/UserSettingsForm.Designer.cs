namespace TimeTasker {
	partial class UserSettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
            this.lblColorTheme = new System.Windows.Forms.Label();
            this.lblHideCompleted = new System.Windows.Forms.Label();
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnUserSettings = new System.Windows.Forms.PictureBox();
            this.btnCalendar = new System.Windows.Forms.PictureBox();
            this.btnTasks = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShowWelcome = new System.Windows.Forms.Label();
            this.lblDarkmode = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTasks)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColorTheme
            // 
            this.lblColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorTheme.ForeColor = System.Drawing.Color.White;
            this.lblColorTheme.Location = new System.Drawing.Point(31, 75);
            this.lblColorTheme.Name = "lblColorTheme";
            this.lblColorTheme.Size = new System.Drawing.Size(237, 24);
            this.lblColorTheme.TabIndex = 0;
            this.lblColorTheme.Text = "Colour theme";
            // 
            // lblHideCompleted
            // 
            this.lblHideCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideCompleted.ForeColor = System.Drawing.Color.White;
            this.lblHideCompleted.Location = new System.Drawing.Point(31, 441);
            this.lblHideCompleted.Name = "lblHideCompleted";
            this.lblHideCompleted.Size = new System.Drawing.Size(237, 24);
            this.lblHideCompleted.TabIndex = 3;
            this.lblHideCompleted.Text = "Hide completed tasks";
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
            this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUserSettings.Image = global::TimeTasker.Properties.Resources.SettingsIconSelected;
            this.btnUserSettings.Location = new System.Drawing.Point(240, 0);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(120, 50);
            this.btnUserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnUserSettings.TabIndex = 2;
            this.btnUserSettings.TabStop = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Image = global::TimeTasker.Properties.Resources.BellIconDefault;
            this.btnCalendar.Location = new System.Drawing.Point(120, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(120, 50);
            this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.Image = global::TimeTasker.Properties.Resources.UserIconDefault;
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
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(360, 50);
            this.pnlTitle.TabIndex = 7;
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
            this.lblTitle.Text = "Preferences";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowWelcome
            // 
            this.lblShowWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWelcome.ForeColor = System.Drawing.Color.White;
            this.lblShowWelcome.Location = new System.Drawing.Point(31, 330);
            this.lblShowWelcome.Name = "lblShowWelcome";
            this.lblShowWelcome.Size = new System.Drawing.Size(237, 24);
            this.lblShowWelcome.TabIndex = 12;
            this.lblShowWelcome.Text = "Show welcome screen";
            // 
            // lblDarkmode
            // 
            this.lblDarkmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarkmode.ForeColor = System.Drawing.Color.White;
            this.lblDarkmode.Location = new System.Drawing.Point(31, 218);
            this.lblDarkmode.Name = "lblDarkmode";
            this.lblDarkmode.Size = new System.Drawing.Size(237, 24);
            this.lblDarkmode.TabIndex = 14;
            this.lblDarkmode.Text = "Dark mode";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(274, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(274, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(274, 426);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(360, 650);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblDarkmode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblShowWelcome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlNavbar);
            this.Controls.Add(this.lblHideCompleted);
            this.Controls.Add(this.lblColorTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSettingsForm";
            this.pnlNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblColorTheme;
		private System.Windows.Forms.Label lblHideCompleted;
		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.PictureBox btnUserSettings;
		private System.Windows.Forms.PictureBox btnCalendar;
		private System.Windows.Forms.PictureBox btnTasks;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblShowWelcome;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label lblDarkmode;
	}
}