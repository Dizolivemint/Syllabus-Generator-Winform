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
            this.SuspendLayout();
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(623, 314);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(147, 20);
            this.textFind.TabIndex = 0;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(570, 317);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(27, 13);
            this.labelFind.TabIndex = 1;
            this.labelFind.Text = "Find";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(570, 358);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(47, 13);
            this.labelReplace.TabIndex = 3;
            this.labelReplace.Text = "Replace";
            // 
            // textReplace
            // 
            this.textReplace.Location = new System.Drawing.Point(623, 355);
            this.textReplace.Name = "textReplace";
            this.textReplace.Size = new System.Drawing.Size(147, 20);
            this.textReplace.TabIndex = 2;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(573, 395);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(197, 25);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "&Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // labelShortname
            // 
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(16, 31);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(99, 13);
            this.labelShortname.TabIndex = 5;
            this.labelShortname.Text = "Course Short Name";
            // 
            // textShortName
            // 
            this.textShortName.Location = new System.Drawing.Point(19, 47);
            this.textShortName.Name = "textShortName";
            this.textShortName.Size = new System.Drawing.Size(236, 20);
            this.textShortName.TabIndex = 6;
            // 
            // labelCourseFullName
            // 
            this.labelCourseFullName.AutoSize = true;
            this.labelCourseFullName.Location = new System.Drawing.Point(16, 86);
            this.labelCourseFullName.Name = "labelCourseFullName";
            this.labelCourseFullName.Size = new System.Drawing.Size(90, 13);
            this.labelCourseFullName.TabIndex = 7;
            this.labelCourseFullName.Text = "Course Full Name";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(19, 102);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(236, 20);
            this.textFullName.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 22);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textTarget
            // 
            this.textTarget.Location = new System.Drawing.Point(19, 266);
            this.textTarget.Name = "textTarget";
            this.textTarget.ReadOnly = true;
            this.textTarget.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTarget.Size = new System.Drawing.Size(185, 20);
            this.textTarget.TabIndex = 10;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(16, 250);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(57, 13);
            this.labelTarget.TabIndex = 11;
            this.labelTarget.Text = "Target File";
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.textTarget);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.labelCourseFullName);
            this.Controls.Add(this.textShortName);
            this.Controls.Add(this.labelShortname);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.textReplace);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textFind);
            this.Name = "FormName";
            this.Text = "Syllabus Generator";
            this.Load += new System.EventHandler(this.formName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

