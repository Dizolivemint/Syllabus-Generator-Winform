namespace Syllabus_Generator
{
    partial class FormAssignmentGrid
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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDue = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelAssignmentName = new System.Windows.Forms.Label();
            this.listBoxGrid = new System.Windows.Forms.ListBox();
            this.textAssignmentDueDate = new System.Windows.Forms.TextBox();
            this.textAssignmentPoints = new System.Windows.Forms.TextBox();
            this.textAssignmentName = new System.Windows.Forms.TextBox();
            this.groupBoxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Location = new System.Drawing.Point(36, 526);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Size = new System.Drawing.Size(546, 128);
            this.groupBoxDetails.TabIndex = 21;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Assignment Details";
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
            this.groupBoxGrid.Controls.Add(this.textAssignmentDueDate);
            this.groupBoxGrid.Controls.Add(this.textAssignmentPoints);
            this.groupBoxGrid.Controls.Add(this.textAssignmentName);
            this.groupBoxGrid.Location = new System.Drawing.Point(36, 18);
            this.groupBoxGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGrid.Size = new System.Drawing.Size(542, 498);
            this.groupBoxGrid.TabIndex = 20;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Assignment Grid";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(40, 431);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(138, 40);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(40, 363);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(138, 40);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(40, 302);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 40);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(36, 202);
            this.labelDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(78, 20);
            this.labelDue.TabIndex = 7;
            this.labelDue.Text = "Due Date";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(36, 128);
            this.labelPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(139, 20);
            this.labelPercentage.TabIndex = 6;
            this.labelPercentage.Text = "Point / Percentage";
            // 
            // labelAssignmentName
            // 
            this.labelAssignmentName.AutoSize = true;
            this.labelAssignmentName.Location = new System.Drawing.Point(36, 51);
            this.labelAssignmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(139, 20);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name";
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.ItemHeight = 20;
            this.listBoxGrid.Location = new System.Drawing.Point(238, 65);
            this.listBoxGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.Size = new System.Drawing.Size(260, 404);
            this.listBoxGrid.TabIndex = 4;
            // 
            // textAssignmentDueDate
            // 
            this.textAssignmentDueDate.Location = new System.Drawing.Point(40, 226);
            this.textAssignmentDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAssignmentDueDate.Name = "textAssignmentDueDate";
            this.textAssignmentDueDate.Size = new System.Drawing.Size(151, 26);
            this.textAssignmentDueDate.TabIndex = 2;
            // 
            // textAssignmentPoints
            // 
            this.textAssignmentPoints.Location = new System.Drawing.Point(40, 152);
            this.textAssignmentPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAssignmentPoints.Name = "textAssignmentPoints";
            this.textAssignmentPoints.Size = new System.Drawing.Size(151, 26);
            this.textAssignmentPoints.TabIndex = 1;
            // 
            // textAssignmentName
            // 
            this.textAssignmentName.Location = new System.Drawing.Point(40, 77);
            this.textAssignmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAssignmentName.Name = "textAssignmentName";
            this.textAssignmentName.Size = new System.Drawing.Size(151, 26);
            this.textAssignmentName.TabIndex = 0;
            // 
            // FormAssignmentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 692);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAssignmentGrid";
            this.Text = "Assignment Grid";
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDue;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.ListBox listBoxGrid;
        private System.Windows.Forms.TextBox textAssignmentDueDate;
        private System.Windows.Forms.TextBox textAssignmentPoints;
        private System.Windows.Forms.TextBox textAssignmentName;
    }
}