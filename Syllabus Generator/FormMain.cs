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
            for (int i = 0; i <= 7; i++)
            {
                comboBoxDay.Items.Add(i);
            }
        }

        private void SearchReplace()
        {
            foreach (var textBox in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<TextBox>()))
            {
                oWord.SearchReplace($"<{textBox.Name}>", textBox.Text, isDeveloper);
            }

            
            int i = 0;
            foreach (var item in listBoxGrid.Items)
            {
                i++;
                oWord.SearchReplace($"<dueDateID{i}>", item.ToString(), isDeveloper);
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
            // AddTable();
            // FillCells();

            
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
            // listBoxGrid.Items.Add($"{textAssignmentName.Text}{splitChar} {textAssignmentPoints.Text}{splitChar} {textAssignmentDueDate.Text}");

            // Add only due dates
            listBoxGrid.Items.Add(textAssignmentDueDate.Text);
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenTemplate_Click(object sender, EventArgs e)
        {
            oWord.fileSource = (String)oWord.OpenFileDialog();
            oWord.OpenTemplate();
        }

        private void btnAssignmentGrid_Click(object sender, EventArgs e)
        {
            Form FormAssignmentGrid = new FormAssignmentGrid();
            FormAssignmentGrid.Tag = new Assignment(0, "", "", 0, formatDate("11/14/2018", 0));
            Assignment assignment = new Assignment(0, "", "", 0, formatDate("11/14/2018", 0));
            DialogResult selectedButton = FormAssignmentGrid.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                assignment = FormAssignmentGrid.Tag as Assignment;
            }
        }
        private DateTime formatDate(string date, int days)
        {
            DateTime dateTime;
            DateTime defaultDate = DateTime.Today.AddDays(days);

            if (DateTime.TryParse(date, out dateTime))
            {
                if (dateTime < DateTime.Today)
                {
                    MessageBox.Show("Date must be the same or later than today", "Date before today");
                    return defaultDate;
                }
                return dateTime;
            }
            else
            {
                MessageBox.Show("Please format the date as given", "Format Error");
                return defaultDate;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxGrid.Items.RemoveAt(listBoxGrid.SelectedIndex);
            }
            catch
            {
                return;
            }
            try
            {
                listBoxGrid.SelectedIndex = 0;
            }
            catch
            {
                return;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxGrid.SelectedIndex;
            try
            {
                listBoxGrid.Items.RemoveAt(selectedIndex);
                listBoxGrid.Items.Insert(selectedIndex, $"{textAssignmentName.Text}{splitChar} {textAssignmentPoints.Text}{splitChar} {textAssignmentDueDate.Text}");
            }
            catch
            {
                return;
            }
        }
    }
}
