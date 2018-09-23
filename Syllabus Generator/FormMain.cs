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
        public FormName()
        {
            InitializeComponent();
        }

        private void formName_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string findText = textFind.Text;
            string replaceText = textReplace.Text;
            SearchReplace(findText, replaceText);
        }
    }
}
