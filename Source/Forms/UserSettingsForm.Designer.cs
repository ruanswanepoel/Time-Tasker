﻿namespace TimeTasker {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(41, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Colour theme";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(41, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Show welcome screen";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(119, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Preferences";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(41, 290);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hide completed tasks";
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
			this.btnUserSettings.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
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
			this.btnCalendar.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
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
			this.btnTasks.Image = global::TimeTasker.Properties.Resources.ButtonHamMenu;
			this.btnTasks.Location = new System.Drawing.Point(0, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(120, 50);
			this.btnTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnTasks.TabIndex = 0;
			this.btnTasks.TabStop = false;
			this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
			// 
			// UserSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.pnlNavbar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserSettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserSettingsForm";
			this.pnlNavbar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.PictureBox btnUserSettings;
		private System.Windows.Forms.PictureBox btnCalendar;
		private System.Windows.Forms.PictureBox btnTasks;
	}
}