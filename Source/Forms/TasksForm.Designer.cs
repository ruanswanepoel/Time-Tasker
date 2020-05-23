using System.Drawing;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.btnMenu = new System.Windows.Forms.PictureBox();
			this.lblList = new System.Windows.Forms.Label();
			this.pnlNavbar = new System.Windows.Forms.Panel();
			this.btnUserSettings = new System.Windows.Forms.PictureBox();
			this.btnCalendar = new System.Windows.Forms.PictureBox();
			this.btnTasks = new System.Windows.Forms.PictureBox();
			this.pnlTasks = new System.Windows.Forms.Panel();
			this.pnlSortSettings = new System.Windows.Forms.Panel();
			this.lblSortOrder = new System.Windows.Forms.Label();
			this.btnSortOrder = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.PictureBox();
			this.pnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			this.pnlNavbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).BeginInit();
			this.pnlSortSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
			this.pnlTitle.Controls.Add(this.btnMenu);
			this.pnlTitle.Controls.Add(this.lblList);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(360, 50);
			this.pnlTitle.TabIndex = 0;
			// 
			// btnMenu
			// 
			this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
			this.btnMenu.Location = new System.Drawing.Point(0, 0);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(50, 50);
			this.btnMenu.TabIndex = 5;
			this.btnMenu.TabStop = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// lblList
			// 
			this.lblList.BackColor = System.Drawing.Color.Transparent;
			this.lblList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblList.ForeColor = System.Drawing.Color.White;
			this.lblList.Location = new System.Drawing.Point(50, 0);
			this.lblList.Name = "lblList";
			this.lblList.Size = new System.Drawing.Size(260, 50);
			this.lblList.TabIndex = 4;
			this.lblList.Text = "Tasks";
			this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.pnlNavbar.TabIndex = 4;
			// 
			// btnUserSettings
			// 
			this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUserSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSettings.Image")));
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
			this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
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
			this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
			this.btnTasks.Location = new System.Drawing.Point(0, 0);
			this.btnTasks.Name = "btnTasks";
			this.btnTasks.Size = new System.Drawing.Size(120, 50);
			this.btnTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnTasks.TabIndex = 0;
			this.btnTasks.TabStop = false;
			// 
			// pnlTasks
			// 
			this.pnlTasks.AutoScroll = true;
			this.pnlTasks.Location = new System.Drawing.Point(0, 80);
			this.pnlTasks.Name = "pnlTasks";
			this.pnlTasks.Size = new System.Drawing.Size(360, 464);
			this.pnlTasks.TabIndex = 5;
			// 
			// pnlSortSettings
			// 
			this.pnlSortSettings.Controls.Add(this.lblSortOrder);
			this.pnlSortSettings.Controls.Add(this.btnSortOrder);
			this.pnlSortSettings.Location = new System.Drawing.Point(20, 52);
			this.pnlSortSettings.Name = "pnlSortSettings";
			this.pnlSortSettings.Size = new System.Drawing.Size(320, 25);
			this.pnlSortSettings.TabIndex = 6;
			// 
			// lblSortOrder
			// 
			this.lblSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSortOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSortOrder.ForeColor = System.Drawing.Color.White;
			this.lblSortOrder.Location = new System.Drawing.Point(0, 0);
			this.lblSortOrder.Name = "lblSortOrder";
			this.lblSortOrder.Size = new System.Drawing.Size(60, 25);
			this.lblSortOrder.TabIndex = 1;
			this.lblSortOrder.Text = "Sort by:";
			this.lblSortOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSortOrder
			// 
			this.btnSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSortOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSortOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSortOrder.ForeColor = System.Drawing.Color.White;
			this.btnSortOrder.Location = new System.Drawing.Point(209, 0);
			this.btnSortOrder.Name = "btnSortOrder";
			this.btnSortOrder.Size = new System.Drawing.Size(111, 25);
			this.btnSortOrder.TabIndex = 0;
			this.btnSortOrder.Text = "Date Created";
			this.btnSortOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSortOrder.Click += new System.EventHandler(this.btnSortOrder_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(306, 545);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(50, 50);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.TabStop = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// TasksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.pnlSortSettings);
			this.Controls.Add(this.pnlTasks);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlNavbar);
			this.Controls.Add(this.pnlTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TasksForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Time Tasker";
			this.pnlTitle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			this.pnlNavbar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnUserSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTasks)).EndInit();
			this.pnlSortSettings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Panel pnlNavbar;
		private System.Windows.Forms.Label lblList;
		private System.Windows.Forms.PictureBox btnMenu;
		private System.Windows.Forms.PictureBox btnAdd;
		private System.Windows.Forms.PictureBox btnUserSettings;
		private System.Windows.Forms.PictureBox btnCalendar;
		private System.Windows.Forms.PictureBox btnTasks;
		private System.Windows.Forms.Panel pnlTasks;
		private System.Windows.Forms.Panel pnlSortSettings;
		private System.Windows.Forms.Label btnSortOrder;
		private System.Windows.Forms.Label lblSortOrder;
	}
}

