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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            textRequiredTexts.Text = "There are no required texts for this course.";
            textOptionalTexts.Text = "You will be required to read online materials and any assigned articles.";
        }
    }
}
