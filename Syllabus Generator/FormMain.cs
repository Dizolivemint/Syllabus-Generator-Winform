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
            // Set days dynamically days = 
            DateTime daySelect = DateTime.Parse("12/31/18");

            // Populate days
            for (int i = 0; i < 7; i++)
            {
                comboBoxDay.Items.Add(daySelect.AddDays(i).Date.ToString("ddd"));
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
            FormAssignmentGrid.Tag = new Assignment(0, "", "", 0, "11/14/2018");
            Assignment assignment = new Assignment(0, "", "", 0, "11/14/2018");
            DialogResult selectedButton = FormAssignmentGrid.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                assignment = FormAssignmentGrid.Tag as Assignment;
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
                listBoxGrid.Items.Insert(selectedIndex, $"{textAssignmentDueDate.Text}");
            }
            catch
            {
                return;
            }
        }

        private void buttonTermAdd_Click(object sender, EventArgs e)
        {
            Form FormTerm = new FormTerm();

            FormTerm.Tag = new List<string>();
            List<string> listWeeks = new List<string>();

            DialogResult selectedButton = FormTerm.ShowDialog();

            if (selectedButton == DialogResult.OK)
            {
                listWeeks = FormTerm.Tag as List<string>;
                foreach (string week in listWeeks)
                {
                    comboBoxDueWeek.Items.Add(week);
                }
                
            }
        }
    }
}
