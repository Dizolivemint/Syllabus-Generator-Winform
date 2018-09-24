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
                oWord.SearchReplace($"<{textBox.Name}>", textBox.Text, false);
            }
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {                
            string findText = "";
            string replaceText = "";
            
            replaceText = textReplace.Text;
            oWord.SearchReplace(findText, replaceText, false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SearchReplace();

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
    }
}
