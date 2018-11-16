namespace Syllabus_Generator
{
    partial class FormName
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
            this.labelShortname = new System.Windows.Forms.Label();
            this.textShortName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelSectionNumber = new System.Windows.Forms.Label();
            this.textSectionNumber = new System.Windows.Forms.TextBox();
            this.textCourseCode = new System.Windows.Forms.TextBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.textTeacherName = new System.Windows.Forms.TextBox();
            this.labelTeacherEmail = new System.Windows.Forms.Label();
            this.textTeacherEmail = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDue = new System.Windows.Forms.Label();
            this.listBoxGrid = new System.Windows.Forms.ListBox();
            this.textAssignmentDueDate = new System.Windows.Forms.TextBox();
            this.buttonTermAdd = new System.Windows.Forms.Button();
            this.buttonTermEdit = new System.Windows.Forms.Button();
            this.listBoxTerm = new System.Windows.Forms.ListBox();
            this.groupBoxTerm = new System.Windows.Forms.GroupBox();
            this.buttonOpenTemplate = new System.Windows.Forms.Button();
            this.btnAssignmentGrid = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.groupBoxTerm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelShortname
            // 
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(24, 29);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(68, 13);
            this.labelShortname.TabIndex = 5;
            this.labelShortname.Text = "Course Code";
            // 
            // textShortName
            // 
            this.textShortName.Location = new System.Drawing.Point(28, 129);
            this.textShortName.Name = "textShortName";
            this.textShortName.ReadOnly = true;
            this.textShortName.Size = new System.Drawing.Size(236, 20);
            this.textShortName.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 37);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textTarget
            // 
            this.textTarget.Location = new System.Drawing.Point(19, 100);
            this.textTarget.Name = "textTarget";
            this.textTarget.ReadOnly = true;
            this.textTarget.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTarget.Size = new System.Drawing.Size(309, 20);
            this.textTarget.TabIndex = 10;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(16, 84);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(87, 13);
            this.labelTarget.TabIndex = 11;
            this.labelTarget.Text = "Copy Path to File";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.comboBoxDay);
            this.groupBoxInfo.Controls.Add(this.lblDay);
            this.groupBoxInfo.Controls.Add(this.labelSectionNumber);
            this.groupBoxInfo.Controls.Add(this.textSectionNumber);
            this.groupBoxInfo.Controls.Add(this.textCourseCode);
            this.groupBoxInfo.Controls.Add(this.labelTeacherName);
            this.groupBoxInfo.Controls.Add(this.textTeacherName);
            this.groupBoxInfo.Controls.Add(this.labelTeacherEmail);
            this.groupBoxInfo.Controls.Add(this.textTeacherEmail);
            this.groupBoxInfo.Controls.Add(this.labelShortname);
            this.groupBoxInfo.Controls.Add(this.textShortName);
            this.groupBoxInfo.Location = new System.Drawing.Point(25, 93);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(364, 350);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Basic Information";
            // 
            // labelSectionNumber
            // 
            this.labelSectionNumber.AutoSize = true;
            this.labelSectionNumber.Location = new System.Drawing.Point(25, 78);
            this.labelSectionNumber.Name = "labelSectionNumber";
            this.labelSectionNumber.Size = new System.Drawing.Size(83, 13);
            this.labelSectionNumber.TabIndex = 20;
            this.labelSectionNumber.Text = "Section Number";
            // 
            // textSectionNumber
            // 
            this.textSectionNumber.Location = new System.Drawing.Point(27, 93);
            this.textSectionNumber.Name = "textSectionNumber";
            this.textSectionNumber.Size = new System.Drawing.Size(39, 20);
            this.textSectionNumber.TabIndex = 19;
            // 
            // textCourseCode
            // 
            this.textCourseCode.Location = new System.Drawing.Point(27, 45);
            this.textCourseCode.Name = "textCourseCode";
            this.textCourseCode.Size = new System.Drawing.Size(236, 20);
            this.textCourseCode.TabIndex = 18;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(25, 168);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(78, 13);
            this.labelTeacherName.TabIndex = 13;
            this.labelTeacherName.Text = "Teacher Name";
            // 
            // textTeacherName
            // 
            this.textTeacherName.Location = new System.Drawing.Point(28, 184);
            this.textTeacherName.Name = "textTeacherName";
            this.textTeacherName.Size = new System.Drawing.Size(236, 20);
            this.textTeacherName.TabIndex = 14;
            // 
            // labelTeacherEmail
            // 
            this.labelTeacherEmail.AutoSize = true;
            this.labelTeacherEmail.Location = new System.Drawing.Point(24, 217);
            this.labelTeacherEmail.Name = "labelTeacherEmail";
            this.labelTeacherEmail.Size = new System.Drawing.Size(75, 13);
            this.labelTeacherEmail.TabIndex = 15;
            this.labelTeacherEmail.Text = "Teacher Email";
            // 
            // textTeacherEmail
            // 
            this.textTeacherEmail.Location = new System.Drawing.Point(27, 233);
            this.textTeacherEmail.Name = "textTeacherEmail";
            this.textTeacherEmail.Size = new System.Drawing.Size(236, 20);
            this.textTeacherEmail.TabIndex = 16;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(183, 137);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 37);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.buttonImport);
            this.groupBoxFile.Controls.Add(this.buttonBackup);
            this.groupBoxFile.Controls.Add(this.buttonExit);
            this.groupBoxFile.Controls.Add(this.labelTarget);
            this.groupBoxFile.Controls.Add(this.textTarget);
            this.groupBoxFile.Controls.Add(this.buttonSave);
            this.groupBoxFile.Location = new System.Drawing.Point(811, 420);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(353, 189);
            this.groupBoxFile.TabIndex = 16;
            this.groupBoxFile.TabStop = false;
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(185, 31);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(145, 37);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "&Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Enabled = false;
            this.buttonBackup.Location = new System.Drawing.Point(19, 31);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(145, 37);
            this.buttonBackup.TabIndex = 16;
            this.buttonBackup.Text = "&Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.buttonRemove);
            this.groupBoxGrid.Controls.Add(this.buttonUpdate);
            this.groupBoxGrid.Controls.Add(this.buttonAdd);
            this.groupBoxGrid.Controls.Add(this.labelDue);
            this.groupBoxGrid.Controls.Add(this.listBoxGrid);
            this.groupBoxGrid.Controls.Add(this.textAssignmentDueDate);
            this.groupBoxGrid.Location = new System.Drawing.Point(416, 196);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(361, 247);
            this.groupBoxGrid.TabIndex = 18;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Assignment Grid";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(27, 183);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 26);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(27, 139);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(92, 26);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 26);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(24, 42);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(53, 13);
            this.labelDue.TabIndex = 7;
            this.labelDue.Text = "Due Date";
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.Location = new System.Drawing.Point(159, 42);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.Size = new System.Drawing.Size(175, 173);
            this.listBoxGrid.TabIndex = 4;
            // 
            // textAssignmentDueDate
            // 
            this.textAssignmentDueDate.Location = new System.Drawing.Point(27, 58);
            this.textAssignmentDueDate.Name = "textAssignmentDueDate";
            this.textAssignmentDueDate.Size = new System.Drawing.Size(102, 20);
            this.textAssignmentDueDate.TabIndex = 2;
            // 
            // buttonTermAdd
            // 
            this.buttonTermAdd.Location = new System.Drawing.Point(16, 85);
            this.buttonTermAdd.Name = "buttonTermAdd";
            this.buttonTermAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonTermAdd.TabIndex = 21;
            this.buttonTermAdd.Text = "Add";
            this.buttonTermAdd.UseVisualStyleBackColor = true;
            // 
            // buttonTermEdit
            // 
            this.buttonTermEdit.Location = new System.Drawing.Point(16, 134);
            this.buttonTermEdit.Name = "buttonTermEdit";
            this.buttonTermEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonTermEdit.TabIndex = 22;
            this.buttonTermEdit.Text = "Edit";
            this.buttonTermEdit.UseVisualStyleBackColor = true;
            // 
            // listBoxTerm
            // 
            this.listBoxTerm.FormattingEnabled = true;
            this.listBoxTerm.Location = new System.Drawing.Point(16, 26);
            this.listBoxTerm.Name = "listBoxTerm";
            this.listBoxTerm.Size = new System.Drawing.Size(116, 43);
            this.listBoxTerm.TabIndex = 23;
            // 
            // groupBoxTerm
            // 
            this.groupBoxTerm.Controls.Add(this.listBoxTerm);
            this.groupBoxTerm.Controls.Add(this.buttonTermEdit);
            this.groupBoxTerm.Controls.Add(this.buttonTermAdd);
            this.groupBoxTerm.Location = new System.Drawing.Point(811, 225);
            this.groupBoxTerm.Name = "groupBoxTerm";
            this.groupBoxTerm.Size = new System.Drawing.Size(153, 189);
            this.groupBoxTerm.TabIndex = 24;
            this.groupBoxTerm.TabStop = false;
            this.groupBoxTerm.Text = "Select Term";
            // 
            // buttonOpenTemplate
            // 
            this.buttonOpenTemplate.Location = new System.Drawing.Point(25, 32);
            this.buttonOpenTemplate.Name = "buttonOpenTemplate";
            this.buttonOpenTemplate.Size = new System.Drawing.Size(145, 37);
            this.buttonOpenTemplate.TabIndex = 18;
            this.buttonOpenTemplate.Text = "&Open Template";
            this.buttonOpenTemplate.UseVisualStyleBackColor = true;
            this.buttonOpenTemplate.Click += new System.EventHandler(this.buttonOpenTemplate_Click);
            // 
            // btnAssignmentGrid
            // 
            this.btnAssignmentGrid.Location = new System.Drawing.Point(182, 34);
            this.btnAssignmentGrid.Name = "btnAssignmentGrid";
            this.btnAssignmentGrid.Size = new System.Drawing.Size(181, 34);
            this.btnAssignmentGrid.TabIndex = 25;
            this.btnAssignmentGrid.Text = "Assignment &Grid";
            this.btnAssignmentGrid.UseVisualStyleBackColor = true;
            this.btnAssignmentGrid.Click += new System.EventHandler(this.btnAssignmentGrid_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(25, 278);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(70, 13);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "Day of Week";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(27, 294);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(53, 21);
            this.comboBoxDay.TabIndex = 23;
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 630);
            this.Controls.Add(this.btnAssignmentGrid);
            this.Controls.Add(this.buttonOpenTemplate);
            this.Controls.Add(this.groupBoxTerm);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "FormName";
            this.Text = "Syllabus Generator";
            this.Load += new System.EventHandler(this.formName_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.groupBoxTerm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelShortname;
        private System.Windows.Forms.TextBox textShortName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDue;
        private System.Windows.Forms.ListBox listBoxGrid;
        private System.Windows.Forms.TextBox textAssignmentDueDate;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.TextBox textTeacherName;
        private System.Windows.Forms.Label labelTeacherEmail;
        private System.Windows.Forms.TextBox textTeacherEmail;
        private System.Windows.Forms.Button buttonTermAdd;
        private System.Windows.Forms.Button buttonTermEdit;
        private System.Windows.Forms.ListBox listBoxTerm;
        private System.Windows.Forms.GroupBox groupBoxTerm;
        private System.Windows.Forms.Button buttonOpenTemplate;
        private System.Windows.Forms.Label labelSectionNumber;
        private System.Windows.Forms.TextBox textSectionNumber;
        private System.Windows.Forms.TextBox textCourseCode;
        private System.Windows.Forms.Button btnAssignmentGrid;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox comboBoxDay;
    }
}

