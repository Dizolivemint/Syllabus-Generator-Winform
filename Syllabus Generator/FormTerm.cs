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
        Term term;
        public FormTerm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dayStart = monthCalendarTermStart.SelectionStart.Date;
            DateTime dayEnd = monthCalendarTermEnd.SelectionStart.Date;
            DateTime dayMute = new DateTime(); 

            term = new Term(textBoxTermName.Text, dayStart, dayEnd);

            for (int i = 0; i < term.Weeks; i++)
            {
                dayMute = dayStart.AddDays(i * 7);
                listBoxTerm.Items.Add($"{i + 1}: {dayMute.Month}/{dayMute.Day}");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (listBoxTerm.Items.Count > 0 && textBoxTermName.Text != "")
            {
                listBoxTerm.Items.Add(textBoxTermName.Text);
                this.Tag = listBoxTerm.Items.Cast<string>().ToList();
                Djson djsonTerm = new Djson();
                djsonTerm.Save(term, "term.json");
            }
                

            

            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxTerm.Items.Clear();
                textBoxTermName.Text = "";
                
            }
            catch
            {

            }
        }
    }
}
