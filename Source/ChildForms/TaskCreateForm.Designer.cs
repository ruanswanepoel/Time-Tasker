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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.containerBox = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drpPriority = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.containerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(200)))), ((int)(((byte)(62)))));
            this.btnCreate.Location = new System.Drawing.Point(25, 273);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(210, 40);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(25, 80);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(210, 48);
            this.txtMessage.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(59, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 26);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Create Task";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerBox
            // 
            this.containerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.containerBox.Controls.Add(this.label3);
            this.containerBox.Controls.Add(this.label2);
            this.containerBox.Controls.Add(this.label1);
            this.containerBox.Controls.Add(this.drpPriority);
            this.containerBox.Controls.Add(this.dtpDueDate);
            this.containerBox.Controls.Add(this.lblTitle);
            this.containerBox.Controls.Add(this.btnCreate);
            this.containerBox.Controls.Add(this.txtMessage);
            this.containerBox.Location = new System.Drawing.Point(49, 138);
            this.containerBox.Name = "containerBox";
            this.containerBox.Size = new System.Drawing.Size(260, 343);
            this.containerBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priority";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Due Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.drpPriority.Location = new System.Drawing.Point(172, 210);
            this.drpPriority.Name = "drpPriority";
            this.drpPriority.Size = new System.Drawing.Size(63, 21);
            this.drpPriority.TabIndex = 8;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.AllowDrop = true;
            this.dtpDueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpDueDate.CustomFormat = "ddd dd MMM yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(25, 165);
            this.dtpDueDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDueDate.Size = new System.Drawing.Size(210, 23);
            this.dtpDueDate.TabIndex = 7;
            // 
            // TaskCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 650);
            this.Controls.Add(this.containerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskCreateForm";
            this.Click += new System.EventHandler(this.TaskCreateForm_Click);
            this.containerBox.ResumeLayout(false);
            this.containerBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel containerBox;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
		private System.Windows.Forms.ComboBox drpPriority;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}