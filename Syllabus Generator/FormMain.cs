using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Syllabus_Generator
{
    public partial class FormName : Form
    {
        private Oword oWord = new Oword("PCOM_T-DACM_Master_Template.dotx", "");
        private bool isDeveloper = false;
        private char splitChar = ',';

        public FormName()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            oWord.Close();
        }

        private void formName_Load(object sender, EventArgs e)
        {
            textRequiredTexts.Text = "There are no required texts for this course.";
            textOptionalTexts.Text = "You will be required to read online materials and any assigned articles.";
        }

        private void SearchReplace()
        {
            foreach (var textBox in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<TextBox>()))
            {
                oWord.SearchReplace($"<{textBox.Name}>", textBox.Text, isDeveloper);
            }
        }

        private void AddTable()
        {
            oWord.AddTable("<tableAssignments>", listBoxGrid.Items.Count, 3);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {                
            string findText = "";
            string replaceText = "";
            
            replaceText = textReplace.Text;
            oWord.SearchReplace(findText, replaceText, isDeveloper);
        }

        private void FillCells()
        {
            string row = "";
            int y = 0;

            foreach (string item in listBoxGrid.Items)
            {
                row = item;
                y++;

                string[] columns = row.Split(splitChar);

                for (int x = 0; x < columns.Length; x++)
                {
                    oWord.FillCell(columns[x], 1, x+1, y, 0);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SearchReplace();
            AddTable();
            FillCells();

            
            textTarget.Text = (String)oWord.SaveFileDialog();
            oWord.fileTarget = textTarget.Text;
            oWord.SaveAs(oWord.fileTarget);
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            if (textFind.Text == "")
                buttonReplace.Enabled = false;
            else
                buttonReplace.Enabled = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxGrid.Items.Add($"{textAssignmentName.Text}{splitChar} {textAssignmentPoints.Text}{splitChar} {textAssignmentDueDate.Text}");
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenTemplate_Click(object sender, EventArgs e)
        {
            oWord.fileSource = (String)oWord.OpenFileDialog();
        }
    }
}
