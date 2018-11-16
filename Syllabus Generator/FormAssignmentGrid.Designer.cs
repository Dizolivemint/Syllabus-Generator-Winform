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
            this.groupBoxDetails.Location = new System.Drawing.Point(24, 342);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(364, 83);
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
            this.groupBoxGrid.Location = new System.Drawing.Point(24, 12);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(361, 324);
            this.groupBoxGrid.TabIndex = 20;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Assignment Grid";
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(27, 236);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(92, 26);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
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
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(24, 131);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(53, 13);
            this.labelDue.TabIndex = 7;
            this.labelDue.Text = "Due Date";
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
            // labelAssignmentName
            // 
            this.labelAssignmentName.AutoSize = true;
            this.labelAssignmentName.Location = new System.Drawing.Point(24, 33);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(92, 13);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name";
            // 
            // listBoxGrid
            // 
            this.listBoxGrid.FormattingEnabled = true;
            this.listBoxGrid.Location = new System.Drawing.Point(159, 42);
            this.listBoxGrid.Name = "listBoxGrid";
            this.listBoxGrid.Size = new System.Drawing.Size(175, 264);
            this.listBoxGrid.TabIndex = 4;
            // 
            // textAssignmentDueDate
            // 
            this.textAssignmentDueDate.Location = new System.Drawing.Point(27, 147);
            this.textAssignmentDueDate.Name = "textAssignmentDueDate";
            this.textAssignmentDueDate.Size = new System.Drawing.Size(102, 20);
            this.textAssignmentDueDate.TabIndex = 2;
            // 
            // textAssignmentPoints
            // 
            this.textAssignmentPoints.Location = new System.Drawing.Point(27, 99);
            this.textAssignmentPoints.Name = "textAssignmentPoints";
            this.textAssignmentPoints.Size = new System.Drawing.Size(102, 20);
            this.textAssignmentPoints.TabIndex = 1;
            // 
            // textAssignmentName
            // 
            this.textAssignmentName.Location = new System.Drawing.Point(27, 50);
            this.textAssignmentName.Name = "textAssignmentName";
            this.textAssignmentName.Size = new System.Drawing.Size(102, 20);
            this.textAssignmentName.TabIndex = 0;
            // 
            // FormAssignmentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxGrid);
            this.Name = "FormAssignmentGrid";
            this.Text = "FormAssignmentGrid";
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