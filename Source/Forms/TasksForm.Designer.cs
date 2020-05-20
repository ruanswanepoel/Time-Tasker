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
			this.lblList = new System.Windows.Forms.Label();
			this.btnMenu = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlTasks = new System.Windows.Forms.Panel();
			this.pnlNavbar = new System.Windows.Forms.Panel();
			this.btnUserSettings = new System.Windows.Forms.Button();
			this.btnCalendar = new System.Windows.Forms.Button();
			this.btnTasks = new System.Windows.Forms.Button();
			this.pnlTitle.SuspendLayout();
			this.pnlNavbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.Controls.Add(this.lblList);
			this.pnlTitle.Controls.Add(this.btnMenu);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(360, 50);
			this.pnlTitle.TabIndex = 0;
			// 
			// lblList
			// 
			this.lblList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblList.Location = new System.Drawing.Point(50, 0);
			this.lblList.Name = "lblList";
			this.lblList.Size = new System.Drawing.Size(307, 50);
			this.lblList.TabIndex = 4;
			this.lblList.Text = "Tasks";
			this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(0, 0);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(50, 50);
			this.btnMenu.TabIndex = 3;
			this.btnMenu.Text = "=";
			this.btnMenu.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(297, 535);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(60, 60);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlTasks
			// 
			this.pnlTasks.AutoScroll = true;
			this.pnlTasks.Location = new System.Drawing.Point(0, 50);
			this.pnlTasks.Name = "pnlTasks";
			this.pnlTasks.Size = new System.Drawing.Size(360, 550);
			this.pnlTasks.TabIndex = 3;
			// 
			// pnlNavbar
			// 
			this.pnlNavbar.Controls.Add(this.btnUserSettings);
			this.pnlNavbar.Controls.Add(this.btnCalendar);
			this.pnlNavbar.Controls.Add(this.btnTasks);
			this.pnlNavbar.Location = new System.Drawing.Point(0, 600);
			this.pnlNavbar.Name = "pnlNavbar";
			this.pnlNavbar.Size = new System.Drawing.Size(360, 50);
			this.pnlNavbar.TabIndex = 4;
			// 
			// btnUserSettings
			// 
			this.btnUserSettings.Location = new System.Drawing.Point(240, 0);
			this.btnUserSettings.Name = "btnUserSettings";
			this.btnUserSettings.Size = new System.Drawing.Size(117, 50);
			this.btnUserSettings.TabIndex = 2;
			this.btnUserSettings.Text = "User Settings";
			this.btnUserSettings.UseVisualStyleBackColor = true;
			// 
			// btnCalendar
			// 
			this.btnCalendar.Location = new System.Drawing.Point(120, 0);
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.Size = new System.Drawing.Size(120, 50);
			this.btnCalendar.TabIndex = 1;
			this.btnCalendar.Text = "Calendar";
			this.btnCalendar.UseVisualStyleBackColor = true;
			// 
			// btnTasks
			// 
			this.btnTasks.Location = new System.Drawing.Point(3, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(117, 50);
			this.btnTasks.TabIndex = 0;
			this.btnTasks.Text = "Tasks";
			this.btnTasks.UseVisualStyleBackColor = true;
			// 
			// TasksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 660);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlNavbar);
			this.Controls.Add(this.pnlTasks);
			this.Controls.Add(this.pnlTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TasksForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Time Tasker";
			this.pnlTitle.ResumeLayout(false);
			this.pnlNavbar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnlTasks;
		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.Button btnUserSettings;
		private System.Windows.Forms.Button btnCalendar;
		private System.Windows.Forms.Button btnTasks;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Label lblList;
	}
}

