namespace Syllabus_Generator
{
    partial class FormFindReplace
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
            this.groupBoxFindReplace = new System.Windows.Forms.GroupBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textReplace = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.textFind = new System.Windows.Forms.TextBox();
            this.groupBoxFindReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFindReplace
            // 
            this.groupBoxFindReplace.Controls.Add(this.buttonReplace);
            this.groupBoxFindReplace.Controls.Add(this.labelReplace);
            this.groupBoxFindReplace.Controls.Add(this.textReplace);
            this.groupBoxFindReplace.Controls.Add(this.labelFind);
            this.groupBoxFindReplace.Controls.Add(this.textFind);
            this.groupBoxFindReplace.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFindReplace.Name = "groupBoxFindReplace";
            this.groupBoxFindReplace.Size = new System.Drawing.Size(187, 189);
            this.groupBoxFindReplace.TabIndex = 15;
            this.groupBoxFindReplace.TabStop = false;
            this.groupBoxFindReplace.Text = "Find and Replace";
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
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(16, 35);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(27, 13);
            this.labelFind.TabIndex = 1;
            this.labelFind.Text = "Find";
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(19, 51);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(147, 20);
            this.textFind.TabIndex = 0;
            // 
            // FormFindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 281);
            this.Controls.Add(this.groupBoxFindReplace);
            this.Name = "FormFindReplace";
            this.Text = "FormFindReplace";
            this.Load += new System.EventHandler(this.FormFindReplace_Load);
            this.groupBoxFindReplace.ResumeLayout(false);
            this.groupBoxFindReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFindReplace;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textReplace;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textFind;
    }
}