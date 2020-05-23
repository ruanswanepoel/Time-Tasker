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
			this.btnSubmit = new System.Windows.Forms.PictureBox();
			this.txtNewListName = new System.Windows.Forms.TextBox();
			this.pnlLists = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlHamMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHamMenu
			// 
			this.pnlHamMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.pnlHamMenu.Controls.Add(this.btnSubmit);
			this.pnlHamMenu.Controls.Add(this.txtNewListName);
			this.pnlHamMenu.Controls.Add(this.pnlLists);
			this.pnlHamMenu.Controls.Add(this.lblTitle);
			this.pnlHamMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlHamMenu.Name = "pnlHamMenu";
			this.pnlHamMenu.Size = new System.Drawing.Size(260, 650);
			this.pnlHamMenu.TabIndex = 0;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubmit.Image = global::TimeTasker.Properties.Resources.ButtonPlus;
			this.btnSubmit.Location = new System.Drawing.Point(223, 613);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(30, 30);
			this.btnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnSubmit.TabIndex = 3;
			this.btnSubmit.TabStop = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtNewListName
			// 
			this.txtNewListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNewListName.Location = new System.Drawing.Point(6, 615);
			this.txtNewListName.Name = "txtNewListName";
			this.txtNewListName.Size = new System.Drawing.Size(211, 26);
			this.txtNewListName.TabIndex = 2;
			// 
			// pnlLists
			// 
			this.pnlLists.Location = new System.Drawing.Point(3, 43);
			this.pnlLists.Name = "pnlLists";
			this.pnlLists.Size = new System.Drawing.Size(254, 562);
			this.pnlLists.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(3, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(254, 40);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Lists";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HamMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.pnlHamMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HamMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskListForm";
			this.Click += new System.EventHandler(this.TaskListForm_Click);
			this.pnlHamMenu.ResumeLayout(false);
			this.pnlHamMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHamMenu;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlLists;
		private System.Windows.Forms.PictureBox btnSubmit;
		private System.Windows.Forms.TextBox txtNewListName;
	}
}