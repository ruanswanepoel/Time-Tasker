namespace TimeTasker {
	partial class TaskCreateForm {
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.drpPriority = new System.Windows.Forms.ComboBox();
			this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
			this.pnl1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.pnl2 = new System.Windows.Forms.Panel();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pnl4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pnl3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnl1.SuspendLayout();
			this.pnl2.SuspendLayout();
			this.pnl4.SuspendLayout();
			this.pnl3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.White;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(200)))), ((int)(((byte)(62)))));
			this.btnCreate.Location = new System.Drawing.Point(7, 214);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(246, 40);
			this.btnCreate.TabIndex = 6;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// drpPriority
			// 
			this.drpPriority.BackColor = System.Drawing.Color.WhiteSmoke;
			this.drpPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drpPriority.FormattingEnabled = true;
			this.drpPriority.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.drpPriority.Location = new System.Drawing.Point(195, 3);
			this.drpPriority.Name = "drpPriority";
			this.drpPriority.Size = new System.Drawing.Size(48, 21);
			this.drpPriority.TabIndex = 8;
			// 
			// dtpDueDate
			// 
			this.dtpDueDate.AllowDrop = true;
			this.dtpDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
			this.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
			this.dtpDueDate.CustomFormat = "ddd dd MMM";
			this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDueDate.Location = new System.Drawing.Point(95, 3);
			this.dtpDueDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dtpDueDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
			this.dtpDueDate.Name = "dtpDueDate";
			this.dtpDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpDueDate.Size = new System.Drawing.Size(148, 23);
			this.dtpDueDate.TabIndex = 7;
			// 
			// pnl1
			// 
			this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
			this.pnl1.Controls.Add(this.label7);
			this.pnl1.Location = new System.Drawing.Point(7, 6);
			this.pnl1.Name = "pnl1";
			this.pnl1.Size = new System.Drawing.Size(246, 52);
			this.pnl1.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(59, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 26);
			this.label7.TabIndex = 4;
			this.label7.Text = "Create Task";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl2
			// 
			this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
			this.pnl2.Controls.Add(this.txtMessage);
			this.pnl2.Controls.Add(this.label4);
			this.pnl2.Location = new System.Drawing.Point(7, 64);
			this.pnl2.Name = "pnl2";
			this.pnl2.Size = new System.Drawing.Size(246, 76);
			this.pnl2.TabIndex = 13;
			// 
			// txtMessage
			// 
			this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMessage.Location = new System.Drawing.Point(3, 26);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(240, 47);
			this.txtMessage.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Description";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl4
			// 
			this.pnl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
			this.pnl4.Controls.Add(this.label2);
			this.pnl4.Controls.Add(this.dtpDueDate);
			this.pnl4.Location = new System.Drawing.Point(7, 179);
			this.pnl4.Name = "pnl4";
			this.pnl4.Size = new System.Drawing.Size(246, 29);
			this.pnl4.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Due Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl3
			// 
			this.pnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(230)))));
			this.pnl3.Controls.Add(this.drpPriority);
			this.pnl3.Controls.Add(this.label1);
			this.pnl3.Location = new System.Drawing.Point(7, 146);
			this.pnl3.Name = "pnl3";
			this.pnl3.Size = new System.Drawing.Size(246, 27);
			this.pnl3.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Priority";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Controls.Add(this.pnl1);
			this.panel1.Controls.Add(this.pnl3);
			this.panel1.Controls.Add(this.btnCreate);
			this.panel1.Controls.Add(this.pnl4);
			this.panel1.Controls.Add(this.pnl2);
			this.panel1.Location = new System.Drawing.Point(49, 180);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(260, 262);
			this.panel1.TabIndex = 13;
			// 
			// TaskCreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(360, 650);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TaskCreateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskCreateForm";
			this.Click += new System.EventHandler(this.TaskCreateForm_Click);
			this.pnl1.ResumeLayout(false);
			this.pnl1.PerformLayout();
			this.pnl2.ResumeLayout(false);
			this.pnl2.PerformLayout();
			this.pnl4.ResumeLayout(false);
			this.pnl4.PerformLayout();
			this.pnl3.ResumeLayout(false);
			this.pnl3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
		private System.Windows.Forms.ComboBox drpPriority;
		private System.Windows.Forms.Panel pnl1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnl2;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnl4;
		private System.Windows.Forms.Panel pnl3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
	}
}