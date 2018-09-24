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
            this.textFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textReplace = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.labelShortname = new System.Windows.Forms.Label();
            this.textShortName = new System.Windows.Forms.TextBox();
            this.labelCourseFullName = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxReading = new System.Windows.Forms.GroupBox();
            this.labelRequiredTexts = new System.Windows.Forms.Label();
            this.textRequiredTexts = new System.Windows.Forms.TextBox();
            this.labelOptionalTexts = new System.Windows.Forms.Label();
            this.textOptionalTexts = new System.Windows.Forms.TextBox();
            this.groupBoxFindReplace = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.textAssignmentName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBoxGrid = new System.Windows.Forms.ListBox();
            this.labelAssignmentName = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelDue = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxReading.SuspendLayout();
            this.groupBoxFindReplace.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(19, 51);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(147, 20);
            this.textFind.TabIndex = 0;
            this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(16, 35);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(27, 13);
            this.labelFind.TabIndex = 1;
            this.labelFind.Text = "Find";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(16, 90);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(47, 13);
            this.labelReplace.TabIndex = 3;
            this.labelReplace.Text = "Replace";
            // 
            // textReplace
            // 
            this.textReplace.Location = new System.Drawing.Point(19, 106);
            this.textReplace.Name = "textReplace";
            this.textReplace.Size = new System.Drawing.Size(147, 20);
            this.textReplace.TabIndex = 2;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Location = new System.Drawing.Point(19, 146);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(147, 25);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "&Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // labelShortname
            // 
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(27, 39);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(99, 13);
            this.labelShortname.TabIndex = 5;
            this.labelShortname.Text = "Course Short Name";
            // 
            // textShortName
            // 
            this.textShortName.Location = new System.Drawing.Point(30, 55);
            this.textShortName.Name = "textShortName";
            this.textShortName.Size = new System.Drawing.Size(236, 20);
            this.textShortName.TabIndex = 6;
            // 
            // labelCourseFullName
            // 
            this.labelCourseFullName.AutoSize = true;
            this.labelCourseFullName.Location = new System.Drawing.Point(27, 94);
            this.labelCourseFullName.Name = "labelCourseFullName";
            this.labelCourseFullName.Size = new System.Drawing.Size(90, 13);
            this.labelCourseFullName.TabIndex = 7;
            this.labelCourseFullName.Text = "Course Full Name";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(30, 110);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(236, 20);
            this.textFullName.TabIndex = 8;
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
            this.groupBoxInfo.Controls.Add(this.labelShortname);
            this.groupBoxInfo.Controls.Add(this.textShortName);
            this.groupBoxInfo.Controls.Add(this.labelCourseFullName);
            this.groupBoxInfo.Controls.Add(this.textFullName);
            this.groupBoxInfo.Location = new System.Drawing.Point(19, 15);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(364, 169);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Basic Information";
            // 
            // groupBoxReading
            // 
            this.groupBoxReading.Controls.Add(this.textOptionalTexts);
            this.groupBoxReading.Controls.Add(this.labelOptionalTexts);
            this.groupBoxReading.Controls.Add(this.textRequiredTexts);
            this.groupBoxReading.Controls.Add(this.labelRequiredTexts);
            this.groupBoxReading.Location = new System.Drawing.Point(416, 15);
            this.groupBoxReading.Name = "groupBoxReading";
            this.groupBoxReading.Size = new System.Drawing.Size(353, 169);
            this.groupBoxReading.TabIndex = 13;
            this.groupBoxReading.TabStop = false;
            this.groupBoxReading.Text = "Reading / Media";
            // 
            // labelRequiredTexts
            // 
            this.labelRequiredTexts.AutoSize = true;
            this.labelRequiredTexts.Location = new System.Drawing.Point(16, 39);
            this.labelRequiredTexts.Name = "labelRequiredTexts";
            this.labelRequiredTexts.Size = new System.Drawing.Size(79, 13);
            this.labelRequiredTexts.TabIndex = 0;
            this.labelRequiredTexts.Text = "Required Texts";
            // 
            // textRequiredTexts
            // 
            this.textRequiredTexts.Location = new System.Drawing.Point(19, 58);
            this.textRequiredTexts.Name = "textRequiredTexts";
            this.textRequiredTexts.Size = new System.Drawing.Size(309, 20);
            this.textRequiredTexts.TabIndex = 1;
            // 
            // labelOptionalTexts
            // 
            this.labelOptionalTexts.AutoSize = true;
            this.labelOptionalTexts.Location = new System.Drawing.Point(16, 94);
            this.labelOptionalTexts.Name = "labelOptionalTexts";
            this.labelOptionalTexts.Size = new System.Drawing.Size(75, 13);
            this.labelOptionalTexts.TabIndex = 2;
            this.labelOptionalTexts.Text = "Optional Texts";
            // 
            // textOptionalTexts
            // 
            this.textOptionalTexts.Location = new System.Drawing.Point(19, 110);
            this.textOptionalTexts.Name = "textOptionalTexts";
            this.textOptionalTexts.Size = new System.Drawing.Size(309, 20);
            this.textOptionalTexts.TabIndex = 3;
            // 
            // groupBoxFindReplace
            // 
            this.groupBoxFindReplace.Controls.Add(this.buttonReplace);
            this.groupBoxFindReplace.Controls.Add(this.labelReplace);
            this.groupBoxFindReplace.Controls.Add(this.textReplace);
            this.groupBoxFindReplace.Controls.Add(this.labelFind);
            this.groupBoxFindReplace.Controls.Add(this.textFind);
            this.groupBoxFindReplace.Location = new System.Drawing.Point(977, 225);
            this.groupBoxFindReplace.Name = "groupBoxFindReplace";
            this.groupBoxFindReplace.Size = new System.Drawing.Size(187, 189);
            this.groupBoxFindReplace.TabIndex = 14;
            this.groupBoxFindReplace.TabStop = false;
            this.groupBoxFindReplace.Text = "Find and Replace";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(183, 137);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 37);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
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
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.buttonRemove);
            this.groupBoxGrid.Controls.Add(this.buttonUpdate);
            this.groupBoxGrid.Controls.Add(this.buttonAdd);
            this.groupBoxGrid.Controls.Add(this.labelDue);
            this.groupBoxGrid.Controls.Add(this.labelPercentage);
            this.groupBoxGrid.Controls.Add(this.labelAssignmentName);
            this.groupBoxGrid.Controls.Add(this.listBoxGrid);
            this.groupBoxGrid.Controls.Add(this.textBox3);
            this.groupBoxGrid.Controls.Add(this.textBox2);
            this.groupBoxGrid.Controls.Add(this.textAssignmentName);
            this.groupBoxGrid.Location = new System.Drawing.Point(22, 200);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(361, 340);
            this.groupBoxGrid.TabIndex = 18;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Assignment Grid";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(19, 31);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(145, 37);
            this.buttonBackup.TabIndex = 16;
            this.buttonBackup.Text = "&Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(185, 31);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(145, 37);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "&Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Location = new System.Drawing.Point(417, 205);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(351, 257);
            this.groupBoxDetails.TabIndex = 19;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Assignment Details";
            // 
            // textAssignmentName
            // 
            this.textAssignmentName.Location = new System.Drawing.Point(27, 50);
            this.textAssignmentName.Name = "textAssignmentName";
            this.textAssignmentName.Size = new System.Drawing.Size(102, 20);
            this.textAssignmentName.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 2;
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.Location = new System.Drawing.Point(159, 42);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.Size = new System.Drawing.Size(175, 264);
            this.listBoxGrid.TabIndex = 4;
            // 
            // labelAssignmentName
            // 
            this.labelAssignmentName.AutoSize = true;
            this.labelAssignmentName.Location = new System.Drawing.Point(24, 33);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(92, 13);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(24, 83);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(97, 13);
            this.labelPercentage.TabIndex = 6;
            this.labelPercentage.Text = "Point / Percentage";
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(24, 131);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(53, 13);
            this.labelDue.TabIndex = 7;
            this.labelDue.Text = "Due Date";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 26);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(27, 236);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(92, 26);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(27, 280);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 26);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 630);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxFindReplace);
            this.Controls.Add(this.groupBoxReading);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "FormName";
            this.Text = "Syllabus Generator";
            this.Load += new System.EventHandler(this.formName_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxReading.ResumeLayout(false);
            this.groupBoxReading.PerformLayout();
            this.groupBoxFindReplace.ResumeLayout(false);
            this.groupBoxFindReplace.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textReplace;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label labelShortname;
        private System.Windows.Forms.TextBox textShortName;
        private System.Windows.Forms.Label labelCourseFullName;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxReading;
        private System.Windows.Forms.TextBox textOptionalTexts;
        private System.Windows.Forms.Label labelOptionalTexts;
        private System.Windows.Forms.TextBox textRequiredTexts;
        private System.Windows.Forms.Label labelRequiredTexts;
        private System.Windows.Forms.GroupBox groupBoxFindReplace;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDue;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.ListBox listBoxGrid;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textAssignmentName;
        private System.Windows.Forms.GroupBox groupBoxDetails;
    }
}

