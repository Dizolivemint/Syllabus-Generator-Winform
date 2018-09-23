namespace Syllabus_Generator
{
    partial class FormTopic
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
            this.richTextTopic = new System.Windows.Forms.RichTextBox();
            this.listTopics = new System.Windows.Forms.ListBox();
            this.labelTopics = new System.Windows.Forms.Label();
            this.labelTopicNumber = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextTopic
            // 
            this.richTextTopic.Location = new System.Drawing.Point(152, 38);
            this.richTextTopic.Name = "richTextTopic";
            this.richTextTopic.Size = new System.Drawing.Size(471, 264);
            this.richTextTopic.TabIndex = 0;
            this.richTextTopic.Text = "";
            // 
            // listTopics
            // 
            this.listTopics.FormattingEnabled = true;
            this.listTopics.Location = new System.Drawing.Point(33, 38);
            this.listTopics.Name = "listTopics";
            this.listTopics.Size = new System.Drawing.Size(92, 264);
            this.listTopics.TabIndex = 1;
            // 
            // labelTopics
            // 
            this.labelTopics.AutoSize = true;
            this.labelTopics.Location = new System.Drawing.Point(30, 22);
            this.labelTopics.Name = "labelTopics";
            this.labelTopics.Size = new System.Drawing.Size(84, 13);
            this.labelTopics.TabIndex = 2;
            this.labelTopics.Text = "Weeks / Topics";
            // 
            // labelTopicNumber
            // 
            this.labelTopicNumber.AutoSize = true;
            this.labelTopicNumber.Location = new System.Drawing.Point(149, 22);
            this.labelTopicNumber.Name = "labelTopicNumber";
            this.labelTopicNumber.Size = new System.Drawing.Size(84, 13);
            this.labelTopicNumber.TabIndex = 3;
            this.labelTopicNumber.Text = "Week / Topic #";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(36, 319);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 28);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(37, 362);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(88, 28);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(152, 319);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 28);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // FormTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 420);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTopicNumber);
            this.Controls.Add(this.labelTopics);
            this.Controls.Add(this.listTopics);
            this.Controls.Add(this.richTextTopic);
            this.Name = "FormTopic";
            this.Text = "Weeks | Topics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextTopic;
        private System.Windows.Forms.ListBox listTopics;
        private System.Windows.Forms.Label labelTopics;
        private System.Windows.Forms.Label labelTopicNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
    }
}