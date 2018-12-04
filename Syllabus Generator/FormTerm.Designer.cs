namespace Syllabus_Generator
{
    partial class FormTerm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTermName = new System.Windows.Forms.Label();
            this.textBoxTermName = new System.Windows.Forms.TextBox();
            this.listBoxTerm = new System.Windows.Forms.ListBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.monthCalendarTermStart = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarTermEnd = new System.Windows.Forms.MonthCalendar();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTermName
            // 
            this.labelTermName.AutoSize = true;
            this.labelTermName.Location = new System.Drawing.Point(49, 38);
            this.labelTermName.Name = "labelTermName";
            this.labelTermName.Size = new System.Drawing.Size(89, 20);
            this.labelTermName.TabIndex = 0;
            this.labelTermName.Text = "Term name";
            // 
            // textBoxTermName
            // 
            this.textBoxTermName.Location = new System.Drawing.Point(53, 61);
            this.textBoxTermName.Name = "textBoxTermName";
            this.textBoxTermName.Size = new System.Drawing.Size(311, 26);
            this.textBoxTermName.TabIndex = 1;
            // 
            // listBoxTerm
            // 
            this.listBoxTerm.FormattingEnabled = true;
            this.listBoxTerm.ItemHeight = 20;
            this.listBoxTerm.Location = new System.Drawing.Point(408, 61);
            this.listBoxTerm.Name = "listBoxTerm";
            this.listBoxTerm.Size = new System.Drawing.Size(727, 644);
            this.listBoxTerm.TabIndex = 2;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(49, 126);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(80, 20);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start date";
            // 
            // monthCalendarTermStart
            // 
            this.monthCalendarTermStart.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarTermStart.Location = new System.Drawing.Point(53, 155);
            this.monthCalendarTermStart.Name = "monthCalendarTermStart";
            this.monthCalendarTermStart.ShowTodayCircle = false;
            this.monthCalendarTermStart.TabIndex = 5;
            // 
            // monthCalendarTermEnd
            // 
            this.monthCalendarTermEnd.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarTermEnd.Location = new System.Drawing.Point(53, 460);
            this.monthCalendarTermEnd.Name = "monthCalendarTermEnd";
            this.monthCalendarTermEnd.ShowToday = false;
            this.monthCalendarTermEnd.ShowTodayCircle = false;
            this.monthCalendarTermEnd.TabIndex = 7;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(49, 431);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(74, 20);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "End date";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(53, 760);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 62);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(210, 760);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(139, 62);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(979, 760);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(156, 62);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "&OK";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(382, 760);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 62);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1205, 874);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.monthCalendarTermEnd);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.monthCalendarTermStart);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.listBoxTerm);
            this.Controls.Add(this.textBoxTermName);
            this.Controls.Add(this.labelTermName);
            this.Name = "FormTerm";
            this.Text = "Term";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTermName;
        private System.Windows.Forms.TextBox textBoxTermName;
        private System.Windows.Forms.ListBox listBoxTerm;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.MonthCalendar monthCalendarTermStart;
        private System.Windows.Forms.MonthCalendar monthCalendarTermEnd;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
    }
}