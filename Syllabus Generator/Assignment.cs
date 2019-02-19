using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabus_Generator
{
    class Assignment
    {
        public Assignment(string _dueDate)
        {
            this.DueDate = this.formatDate(_dueDate);
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Points { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime incrementDate(string date)
        {
            DateTime dateTime = formatDate(date);

            Console.WriteLine($"Day of week c{dateTime.DayOfWeek}");

            return dateTime;
        }

        private DateTime formatDate(string date)
        {
            DateTime dateTime;
            DateTime defaultDate = DateTime.Today;

            if (DateTime.TryParse(date, out dateTime))
            {
                return dateTime;
            }
            else
            {
                MessageBox.Show("Please format the date as given", "Format Error");
                return defaultDate;
            }
        }

        private double calcNumDays(DateTime dateStart, DateTime dateEnd, int maxYears)
        {
            return (dateEnd - dateStart).TotalDays;
        }
    }
}
