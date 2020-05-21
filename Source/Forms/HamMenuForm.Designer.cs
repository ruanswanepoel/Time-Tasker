namespace TimeTasker {
	partial class HamMenuForm {
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
			this.pnlHamMenu = new System.Windows.Forms.Panel();
			this.pnlLists = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlHamMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHamMenu
			// 
			this.pnlHamMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.pnlHamMenu.Controls.Add(this.pnlLists);
			this.pnlHamMenu.Controls.Add(this.lblTitle);
			this.pnlHamMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlHamMenu.Name = "pnlHamMenu";
			this.pnlHamMenu.Size = new System.Drawing.Size(260, 650);
			this.pnlHamMenu.TabIndex = 0;
			// 
			// pnlLists
			// 
			this.pnlLists.Location = new System.Drawing.Point(3, 35);
			this.pnlLists.Name = "pnlLists";
			this.pnlLists.Size = new System.Drawing.Size(254, 612);
			this.pnlLists.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(3, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(254, 32);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Lists";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TaskListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.pnlHamMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TaskListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskListForm";
			this.Click += new System.EventHandler(this.TaskListForm_Click);
			this.pnlHamMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHamMenu;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlLists;
	}
}