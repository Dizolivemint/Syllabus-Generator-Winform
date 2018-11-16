using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabus_Generator
{
    public partial class FormFindReplace : Form
    {
        Oword oWord;
        bool isDeveloper = false;

        public FormFindReplace()
        {
            InitializeComponent();
        }

        private void FormFindReplace_Load(object sender, EventArgs e)
        {

        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string findText = "";
            string replaceText = "";

            replaceText = textReplace.Text;
            oWord.SearchReplace(findText, replaceText, isDeveloper);
        }

        private void textFind_TextChanged(object sender, EventArgs e)
        {
            if (textFind.Text == "")
                buttonReplace.Enabled = false;
            else
                buttonReplace.Enabled = true;

        }
    }
}
