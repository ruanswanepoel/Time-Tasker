namespace TimeTasker {

	partial class TasksForm {
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
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.pnlNav = new System.Windows.Forms.Panel();
			this.btnUserSettings = new System.Windows.Forms.Button();
			this.btnCalendar = new System.Windows.Forms.Button();
			this.btnTasks = new System.Windows.Forms.Button();
			this.btnHamMenu = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnAddTask = new System.Windows.Forms.Button();
			this.pnlTitle.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.pnlNav.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Controls.Add(this.btnHamMenu);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(480, 70);
			this.pnlTitle.TabIndex = 0;
			// 
			// pnlContent
			// 
			this.pnlContent.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlContent.Controls.Add(this.btnAddTask);
			this.pnlContent.Location = new System.Drawing.Point(0, 70);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(480, 660);
			this.pnlContent.TabIndex = 1;
			// 
			// pnlNav
			// 
			this.pnlNav.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlNav.Controls.Add(this.btnUserSettings);
			this.pnlNav.Controls.Add(this.btnCalendar);
			this.pnlNav.Controls.Add(this.btnTasks);
			this.pnlNav.Location = new System.Drawing.Point(0, 730);
			this.pnlNav.Name = "pnlNav";
			this.pnlNav.Size = new System.Drawing.Size(480, 70);
			this.pnlNav.TabIndex = 2;
			// 
			// btnUserSettings
			// 
			this.btnUserSettings.Location = new System.Drawing.Point(320, 0);
			this.btnUserSettings.Name = "btnUserSettings";
			this.btnUserSettings.Size = new System.Drawing.Size(160, 70);
			this.btnUserSettings.TabIndex = 2;
			this.btnUserSettings.Text = "button3";
			this.btnUserSettings.UseVisualStyleBackColor = true;
			// 
			// btnCalendar
			// 
			this.btnCalendar.Location = new System.Drawing.Point(160, 0);
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.Size = new System.Drawing.Size(160, 70);
			this.btnCalendar.TabIndex = 1;
			this.btnCalendar.Text = "button2";
			this.btnCalendar.UseVisualStyleBackColor = true;
			// 
			// btnTasks
			// 
			this.btnTasks.Location = new System.Drawing.Point(0, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(160, 70);
			this.btnTasks.TabIndex = 0;
			this.btnTasks.Text = "button1";
			this.btnTasks.UseVisualStyleBackColor = true;
			// 
			// btnHamMenu
			// 
			this.btnHamMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHamMenu.ForeColor = System.Drawing.Color.White;
			this.btnHamMenu.Location = new System.Drawing.Point(0, 0);
			this.btnHamMenu.Name = "btnHamMenu";
			this.btnHamMenu.Size = new System.Drawing.Size(70, 70);
			this.btnHamMenu.TabIndex = 0;
			this.btnHamMenu.Text = "button4";
			this.btnHamMenu.UseVisualStyleBackColor = true;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(76, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(392, 70);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Tasks";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddTask
			// 
			this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddTask.Location = new System.Drawing.Point(383, 576);
			this.btnAddTask.Name = "btnAddTask";
			this.btnAddTask.Size = new System.Drawing.Size(85, 78);
			this.btnAddTask.TabIndex = 0;
			this.btnAddTask.Text = "+";
			this.btnAddTask.UseVisualStyleBackColor = true;
			// 
			// TasksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 800);
			this.Controls.Add(this.pnlNav);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TasksForm";
			this.Text = "Time Tasker";
			this.pnlTitle.ResumeLayout(false);
			this.pnlContent.ResumeLayout(false);
			this.pnlNav.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Panel pnlNav;
		private System.Windows.Forms.Button btnUserSettings;
		private System.Windows.Forms.Button btnCalendar;
		private System.Windows.Forms.Button btnTasks;
		private System.Windows.Forms.Button btnHamMenu;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnAddTask;
	}
}

