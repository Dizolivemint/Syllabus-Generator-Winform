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
        private Oword oWord = new Oword("Template.dotx", "");

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

        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string findText = textFind.Text;
            string replaceText = textReplace.Text;
            oWord.SearchReplace(findText, replaceText, true);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textTarget.Text = (String)oWord.SaveFileDialog();
            oWord.fileTarget = textTarget.Text;
            oWord.SaveAs(oWord.fileTarget);
        }
    }
}
