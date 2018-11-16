namespace Syllabus_Generator
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            this.groupBoxCourseDescription = new System.Windows.Forms.GroupBox();
            this.textCourseDescription = new System.Windows.Forms.TextBox();
            this.groupBoxReading = new System.Windows.Forms.GroupBox();
            this.textOptionalTexts = new System.Windows.Forms.TextBox();
            this.labelOptionalTexts = new System.Windows.Forms.Label();
            this.textRequiredTexts = new System.Windows.Forms.TextBox();
            this.labelRequiredTexts = new System.Windows.Forms.Label();
            this.groupBoxCourseDescription.SuspendLayout();
            this.groupBoxReading.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCourseDescription
            // 
            this.groupBoxCourseDescription.Controls.Add(this.textCourseDescription);
            this.groupBoxCourseDescription.Location = new System.Drawing.Point(391, 23);
            this.groupBoxCourseDescription.Name = "groupBoxCourseDescription";
            this.groupBoxCourseDescription.Size = new System.Drawing.Size(377, 168);
            this.groupBoxCourseDescription.TabIndex = 22;
            this.groupBoxCourseDescription.TabStop = false;
            this.groupBoxCourseDescription.Text = "Course Description";
            // 
            // textCourseDescription
            // 
            this.textCourseDescription.Location = new System.Drawing.Point(16, 29);
            this.textCourseDescription.MaxLength = 0;
            this.textCourseDescription.Multiline = true;
            this.textCourseDescription.Name = "textCourseDescription";
            this.textCourseDescription.Size = new System.Drawing.Size(340, 126);
            this.textCourseDescription.TabIndex = 0;
            this.textCourseDescription.Text = resources.GetString("textCourseDescription.Text");
            // 
            // groupBoxReading
            // 
            this.groupBoxReading.Controls.Add(this.textOptionalTexts);
            this.groupBoxReading.Controls.Add(this.labelOptionalTexts);
            this.groupBoxReading.Controls.Add(this.textRequiredTexts);
            this.groupBoxReading.Controls.Add(this.labelRequiredTexts);
            this.groupBoxReading.Location = new System.Drawing.Point(21, 23);
            this.groupBoxReading.Name = "groupBoxReading";
            this.groupBoxReading.Size = new System.Drawing.Size(353, 169);
            this.groupBoxReading.TabIndex = 21;
            this.groupBoxReading.TabStop = false;
            this.groupBoxReading.Text = "Reading / Media";
            // 
            // textOptionalTexts
            // 
            this.textOptionalTexts.Location = new System.Drawing.Point(19, 100);
            this.textOptionalTexts.Multiline = true;
            this.textOptionalTexts.Name = "textOptionalTexts";
            this.textOptionalTexts.Size = new System.Drawing.Size(309, 20);
            this.textOptionalTexts.TabIndex = 3;
            // 
            // labelOptionalTexts
            // 
            this.labelOptionalTexts.AutoSize = true;
            this.labelOptionalTexts.Location = new System.Drawing.Point(16, 84);
            this.labelOptionalTexts.Name = "labelOptionalTexts";
            this.labelOptionalTexts.Size = new System.Drawing.Size(75, 13);
            this.labelOptionalTexts.TabIndex = 2;
            this.labelOptionalTexts.Text = "Optional Texts";
            // 
            // textRequiredTexts
            // 
            this.textRequiredTexts.Location = new System.Drawing.Point(19, 48);
            this.textRequiredTexts.Multiline = true;
            this.textRequiredTexts.Name = "textRequiredTexts";
            this.textRequiredTexts.Size = new System.Drawing.Size(309, 22);
            this.textRequiredTexts.TabIndex = 1;
            // 
            // labelRequiredTexts
            // 
            this.labelRequiredTexts.AutoSize = true;
            this.labelRequiredTexts.Location = new System.Drawing.Point(16, 29);
            this.labelRequiredTexts.Name = "labelRequiredTexts";
            this.labelRequiredTexts.Size = new System.Drawing.Size(79, 13);
            this.labelRequiredTexts.TabIndex = 0;
            this.labelRequiredTexts.Text = "Required Texts";
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.groupBoxCourseDescription);
            this.Controls.Add(this.groupBoxReading);
            this.Name = "FormInformation";
            this.Text = "FormInformation";
            this.Load += new System.EventHandler(this.FormInformation_Load);
            this.groupBoxCourseDescription.ResumeLayout(false);
            this.groupBoxCourseDescription.PerformLayout();
            this.groupBoxReading.ResumeLayout(false);
            this.groupBoxReading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCourseDescription;
        private System.Windows.Forms.TextBox textCourseDescription;
        private System.Windows.Forms.GroupBox groupBoxReading;
        private System.Windows.Forms.TextBox textOptionalTexts;
        private System.Windows.Forms.Label labelOptionalTexts;
        private System.Windows.Forms.TextBox textRequiredTexts;
        private System.Windows.Forms.Label labelRequiredTexts;
    }
}