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
            this.textClassTime = new System.Windows.Forms.TextBox();
            this.labelClassTime = new System.Windows.Forms.Label();
            this.textClassDayOfWeek = new System.Windows.Forms.TextBox();
            this.textClassDate = new System.Windows.Forms.TextBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
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
            this.comboBoxDueWeek = new System.Windows.Forms.ComboBox();
            this.labelDueWeek = new System.Windows.Forms.Label();
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
            this.labelTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDueDay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDueMinus = new System.Windows.Forms.Button();
            this.buttonDueDayOfClass = new System.Windows.Forms.Button();
            this.buttonDuePlus = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.groupBoxTerm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelShortname
            // 
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(36, 45);
            this.labelShortname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(102, 20);
            this.labelShortname.TabIndex = 5;
            this.labelShortname.Text = "Course Code";
            // 
            // textShortName
            // 
            this.textShortName.Location = new System.Drawing.Point(40, 196);
            this.textShortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textShortName.Name = "textShortName";
            this.textShortName.ReadOnly = true;
            this.textShortName.Size = new System.Drawing.Size(154, 26);
            this.textShortName.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 204);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(218, 57);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textTarget
            // 
            this.textTarget.Location = new System.Drawing.Point(28, 147);
            this.textTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTarget.Name = "textTarget";
            this.textTarget.ReadOnly = true;
            this.textTarget.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTarget.Size = new System.Drawing.Size(462, 26);
            this.textTarget.TabIndex = 10;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(24, 122);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(129, 20);
            this.labelTarget.TabIndex = 11;
            this.labelTarget.Text = "Copy Path to File";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelDate);
            this.groupBoxInfo.Controls.Add(this.textClassTime);
            this.groupBoxInfo.Controls.Add(this.labelClassTime);
            this.groupBoxInfo.Controls.Add(this.textClassDayOfWeek);
            this.groupBoxInfo.Controls.Add(this.textClassDate);
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
            this.groupBoxInfo.Location = new System.Drawing.Point(33, 123);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfo.Size = new System.Drawing.Size(236, 723);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Basic Information";
            // 
            // textClassTime
            // 
            this.textClassTime.Location = new System.Drawing.Point(40, 616);
            this.textClassTime.Name = "textClassTime";
            this.textClassTime.Size = new System.Drawing.Size(156, 26);
            this.textClassTime.TabIndex = 7;
            // 
            // labelClassTime
            // 
            this.labelClassTime.AutoSize = true;
            this.labelClassTime.Location = new System.Drawing.Point(36, 593);
            this.labelClassTime.Name = "labelClassTime";
            this.labelClassTime.Size = new System.Drawing.Size(86, 20);
            this.labelClassTime.TabIndex = 26;
            this.labelClassTime.Text = "Class Time";
            // 
            // textClassDayOfWeek
            // 
            this.textClassDayOfWeek.Location = new System.Drawing.Point(125, 454);
            this.textClassDayOfWeek.Name = "textClassDayOfWeek";
            this.textClassDayOfWeek.Size = new System.Drawing.Size(69, 26);
            this.textClassDayOfWeek.TabIndex = 5;
            // 
            // textClassDate
            // 
            this.textClassDate.Location = new System.Drawing.Point(40, 531);
            this.textClassDate.Name = "textClassDate";
            this.textClassDate.Size = new System.Drawing.Size(156, 26);
            this.textClassDate.TabIndex = 6;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(40, 452);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(78, 28);
            this.comboBoxDay.TabIndex = 4;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(38, 428);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(100, 20);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "Day of Week";
            // 
            // labelSectionNumber
            // 
            this.labelSectionNumber.AutoSize = true;
            this.labelSectionNumber.Location = new System.Drawing.Point(38, 120);
            this.labelSectionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSectionNumber.Name = "labelSectionNumber";
            this.labelSectionNumber.Size = new System.Drawing.Size(123, 20);
            this.labelSectionNumber.TabIndex = 20;
            this.labelSectionNumber.Text = "Section Number";
            // 
            // textSectionNumber
            // 
            this.textSectionNumber.Location = new System.Drawing.Point(40, 143);
            this.textSectionNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSectionNumber.Name = "textSectionNumber";
            this.textSectionNumber.Size = new System.Drawing.Size(56, 26);
            this.textSectionNumber.TabIndex = 1;
            this.textSectionNumber.TextChanged += new System.EventHandler(this.textSectionNumber_TextChanged);
            // 
            // textCourseCode
            // 
            this.textCourseCode.Location = new System.Drawing.Point(40, 69);
            this.textCourseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCourseCode.Name = "textCourseCode";
            this.textCourseCode.Size = new System.Drawing.Size(156, 26);
            this.textCourseCode.TabIndex = 0;
            this.textCourseCode.TextChanged += new System.EventHandler(this.textCourseCode_TextChanged);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(38, 258);
            this.labelTeacherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(113, 20);
            this.labelTeacherName.TabIndex = 13;
            this.labelTeacherName.Text = "Teacher Name";
            // 
            // textTeacherName
            // 
            this.textTeacherName.Location = new System.Drawing.Point(42, 283);
            this.textTeacherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTeacherName.Name = "textTeacherName";
            this.textTeacherName.Size = new System.Drawing.Size(154, 26);
            this.textTeacherName.TabIndex = 2;
            // 
            // labelTeacherEmail
            // 
            this.labelTeacherEmail.AutoSize = true;
            this.labelTeacherEmail.Location = new System.Drawing.Point(36, 334);
            this.labelTeacherEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeacherEmail.Name = "labelTeacherEmail";
            this.labelTeacherEmail.Size = new System.Drawing.Size(110, 20);
            this.labelTeacherEmail.TabIndex = 15;
            this.labelTeacherEmail.Text = "Teacher Email";
            // 
            // textTeacherEmail
            // 
            this.textTeacherEmail.Location = new System.Drawing.Point(40, 358);
            this.textTeacherEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTeacherEmail.Name = "textTeacherEmail";
            this.textTeacherEmail.Size = new System.Drawing.Size(156, 26);
            this.textTeacherEmail.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(274, 204);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(218, 57);
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
            this.groupBoxFile.Location = new System.Drawing.Point(302, 555);
            this.groupBoxFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFile.Size = new System.Drawing.Size(549, 291);
            this.groupBoxFile.TabIndex = 16;
            this.groupBoxFile.TabStop = false;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(278, 41);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(218, 57);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "&Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(28, 41);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(218, 57);
            this.buttonBackup.TabIndex = 16;
            this.buttonBackup.Text = "&Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.buttonDuePlus);
            this.groupBoxGrid.Controls.Add(this.buttonDueDayOfClass);
            this.groupBoxGrid.Controls.Add(this.buttonDueMinus);
            this.groupBoxGrid.Controls.Add(this.comboBox1);
            this.groupBoxGrid.Controls.Add(this.labelDueDay);
            this.groupBoxGrid.Controls.Add(this.textBox1);
            this.groupBoxGrid.Controls.Add(this.labelTime);
            this.groupBoxGrid.Controls.Add(this.comboBoxDueWeek);
            this.groupBoxGrid.Controls.Add(this.labelDueWeek);
            this.groupBoxGrid.Controls.Add(this.buttonRemove);
            this.groupBoxGrid.Controls.Add(this.buttonUpdate);
            this.groupBoxGrid.Controls.Add(this.buttonAdd);
            this.groupBoxGrid.Controls.Add(this.labelDue);
            this.groupBoxGrid.Controls.Add(this.listBoxGrid);
            this.groupBoxGrid.Controls.Add(this.textAssignmentDueDate);
            this.groupBoxGrid.Location = new System.Drawing.Point(302, 123);
            this.groupBoxGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGrid.Size = new System.Drawing.Size(291, 422);
            this.groupBoxGrid.TabIndex = 18;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Due Dates";
            // 
            // comboBoxDueWeek
            // 
            this.comboBoxDueWeek.FormattingEnabled = true;
            this.comboBoxDueWeek.Location = new System.Drawing.Point(81, 45);
            this.comboBoxDueWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDueWeek.Name = "comboBoxDueWeek";
            this.comboBoxDueWeek.Size = new System.Drawing.Size(46, 28);
            this.comboBoxDueWeek.TabIndex = 8;
            // 
            // labelDueWeek
            // 
            this.labelDueWeek.AutoSize = true;
            this.labelDueWeek.Location = new System.Drawing.Point(24, 53);
            this.labelDueWeek.Name = "labelDueWeek";
            this.labelDueWeek.Size = new System.Drawing.Size(50, 20);
            this.labelDueWeek.TabIndex = 11;
            this.labelDueWeek.Text = "Week";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(212, 354);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(50, 40);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "&Del";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(106, 354);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 40);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 354);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 40);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(146, 139);
            this.labelDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(44, 20);
            this.labelDue.TabIndex = 7;
            this.labelDue.Text = "Date";
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.ItemHeight = 20;
            this.listBoxGrid.Location = new System.Drawing.Point(28, 214);
            this.listBoxGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.Size = new System.Drawing.Size(234, 124);
            this.listBoxGrid.TabIndex = 4;
            // 
            // textAssignmentDueDate
            // 
            this.textAssignmentDueDate.Location = new System.Drawing.Point(150, 162);
            this.textAssignmentDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAssignmentDueDate.Name = "textAssignmentDueDate";
            this.textAssignmentDueDate.Size = new System.Drawing.Size(112, 26);
            this.textAssignmentDueDate.TabIndex = 9;
            // 
            // buttonTermAdd
            // 
            this.buttonTermAdd.Location = new System.Drawing.Point(24, 308);
            this.buttonTermAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTermAdd.Name = "buttonTermAdd";
            this.buttonTermAdd.Size = new System.Drawing.Size(176, 42);
            this.buttonTermAdd.TabIndex = 21;
            this.buttonTermAdd.Text = "Add";
            this.buttonTermAdd.UseVisualStyleBackColor = true;
            this.buttonTermAdd.Click += new System.EventHandler(this.buttonTermAdd_Click);
            // 
            // buttonTermEdit
            // 
            this.buttonTermEdit.Location = new System.Drawing.Point(24, 363);
            this.buttonTermEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTermEdit.Name = "buttonTermEdit";
            this.buttonTermEdit.Size = new System.Drawing.Size(176, 40);
            this.buttonTermEdit.TabIndex = 22;
            this.buttonTermEdit.Text = "Edit";
            this.buttonTermEdit.UseVisualStyleBackColor = true;
            // 
            // listBoxTerm
            // 
            this.listBoxTerm.FormattingEnabled = true;
            this.listBoxTerm.ItemHeight = 20;
            this.listBoxTerm.Location = new System.Drawing.Point(24, 40);
            this.listBoxTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTerm.Name = "listBoxTerm";
            this.listBoxTerm.Size = new System.Drawing.Size(172, 244);
            this.listBoxTerm.TabIndex = 23;
            // 
            // groupBoxTerm
            // 
            this.groupBoxTerm.Controls.Add(this.listBoxTerm);
            this.groupBoxTerm.Controls.Add(this.buttonTermEdit);
            this.groupBoxTerm.Controls.Add(this.buttonTermAdd);
            this.groupBoxTerm.Location = new System.Drawing.Point(624, 123);
            this.groupBoxTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTerm.Name = "groupBoxTerm";
            this.groupBoxTerm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTerm.Size = new System.Drawing.Size(227, 422);
            this.groupBoxTerm.TabIndex = 24;
            this.groupBoxTerm.TabStop = false;
            this.groupBoxTerm.Text = "Select Term";
            // 
            // buttonOpenTemplate
            // 
            this.buttonOpenTemplate.Location = new System.Drawing.Point(33, 29);
            this.buttonOpenTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenTemplate.Name = "buttonOpenTemplate";
            this.buttonOpenTemplate.Size = new System.Drawing.Size(218, 57);
            this.buttonOpenTemplate.TabIndex = 18;
            this.buttonOpenTemplate.Text = "&Open Template";
            this.buttonOpenTemplate.UseVisualStyleBackColor = true;
            this.buttonOpenTemplate.Click += new System.EventHandler(this.buttonOpenTemplate_Click);
            // 
            // btnAssignmentGrid
            // 
            this.btnAssignmentGrid.Location = new System.Drawing.Point(268, 32);
            this.btnAssignmentGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignmentGrid.Name = "btnAssignmentGrid";
            this.btnAssignmentGrid.Size = new System.Drawing.Size(272, 52);
            this.btnAssignmentGrid.TabIndex = 25;
            this.btnAssignmentGrid.Text = "Assignment &Grid";
            this.btnAssignmentGrid.UseVisualStyleBackColor = true;
            this.btnAssignmentGrid.Click += new System.EventHandler(this.btnAssignmentGrid_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(24, 139);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 20);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 14;
            // 
            // labelDueDay
            // 
            this.labelDueDay.AutoSize = true;
            this.labelDueDay.Location = new System.Drawing.Point(169, 53);
            this.labelDueDay.Name = "labelDueDay";
            this.labelDueDay.Size = new System.Drawing.Size(37, 20);
            this.labelDueDay.TabIndex = 15;
            this.labelDueDay.Text = "Day";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // buttonDueMinus
            // 
            this.buttonDueMinus.Location = new System.Drawing.Point(28, 90);
            this.buttonDueMinus.Name = "buttonDueMinus";
            this.buttonDueMinus.Size = new System.Drawing.Size(39, 38);
            this.buttonDueMinus.TabIndex = 17;
            this.buttonDueMinus.Text = "-";
            this.buttonDueMinus.UseVisualStyleBackColor = true;
            // 
            // buttonDueDayOfClass
            // 
            this.buttonDueDayOfClass.Location = new System.Drawing.Point(81, 90);
            this.buttonDueDayOfClass.Name = "buttonDueDayOfClass";
            this.buttonDueDayOfClass.Size = new System.Drawing.Size(134, 38);
            this.buttonDueDayOfClass.TabIndex = 18;
            this.buttonDueDayOfClass.Text = "Day of Class";
            this.buttonDueDayOfClass.UseVisualStyleBackColor = true;
            // 
            // buttonDuePlus
            // 
            this.buttonDuePlus.Location = new System.Drawing.Point(229, 90);
            this.buttonDuePlus.Name = "buttonDuePlus";
            this.buttonDuePlus.Size = new System.Drawing.Size(33, 38);
            this.buttonDuePlus.TabIndex = 19;
            this.buttonDuePlus.Text = "+";
            this.buttonDuePlus.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(40, 510);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 27;
            this.labelDate.Text = "Date";
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(881, 863);
            this.Controls.Add(this.btnAssignmentGrid);
            this.Controls.Add(this.buttonOpenTemplate);
            this.Controls.Add(this.groupBoxTerm);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ComboBox comboBoxDueWeek;
        private System.Windows.Forms.Label labelDueWeek;
        private System.Windows.Forms.TextBox textClassDate;
        private System.Windows.Forms.TextBox textClassTime;
        private System.Windows.Forms.Label labelClassTime;
        private System.Windows.Forms.TextBox textClassDayOfWeek;
        private System.Windows.Forms.Button buttonDuePlus;
        private System.Windows.Forms.Button buttonDueDayOfClass;
        private System.Windows.Forms.Button buttonDueMinus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDueDay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
    }
}

