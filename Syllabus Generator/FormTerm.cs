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
    public partial class FormTerm : Form
    {
        public FormTerm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dayStart = monthCalendarTermStart.SelectionStart.Date;
            DateTime dayEnd = monthCalendarTermEnd.SelectionStart.Date;
            DateTime dayMute = new DateTime();

            double numDays = (dayEnd - dayStart).TotalDays;
            int numWeeks = 1 + ((int)numDays / 7);

            for (int i = 0; i < numWeeks; i++)
            {
                dayMute = dayStart.AddDays(i * 7);
                listBoxTerm.Items.Add($"{i + 1}: {dayMute.Month}/{dayMute.Day}");
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            listBoxTerm.Items.Add(textBoxTermName.Text);

            this.Tag = listBoxTerm.Items.Cast<string>().ToList();
            this.Close();
        }
    }
}
