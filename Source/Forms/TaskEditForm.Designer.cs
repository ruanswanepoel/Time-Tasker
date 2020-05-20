namespace TimeTasker {
	partial class TaskEditForm {
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
			this.btnSave = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(11, 207);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(243, 37);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMessage.Location = new System.Drawing.Point(12, 40);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(243, 119);
			this.txtMessage.TabIndex = 6;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(12, 165);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(243, 36);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete Task";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(93, 11);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(75, 20);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Edit Task";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.txtMessage);
			this.panel1.Location = new System.Drawing.Point(45, 187);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 255);
			this.panel1.TabIndex = 8;
			// 
			// TaskEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TaskEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskEditForm";
			this.Click += new System.EventHandler(this.TaskEditForm_Click);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panel1;
	}
}