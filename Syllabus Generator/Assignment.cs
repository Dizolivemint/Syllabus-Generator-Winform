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
        private int _id;
        private string _title;
        private string _description;
        private int _points;
        private DateTime _dueDate;

        public Assignment(int _id, string _title, string _description, int _points, string _dueDate)
        {
            this._id = _id;
            this._title = _title;
            this._description = _description;
            this._points = _points;
            this._dueDate = _dueDate;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int points
        {
            get { return _points; }
            set { _points = value; }
        }

        public DateTime dueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public DateTime incrementDate(string date)
        {
            DateTime dateTime = formatDate(date);

            Console.WriteLine($"Day of week ${dateTime.DayOfWeek}");
                    }

        private DateTime formatDate(string date)
        {
            DateTime dateTime;
            DateTime defaultDate = DateTime.Today;

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

        private int calcNumDays(DateTime dateStart, DateTime dateEnd, int maxYears)
        {
            int yearStart = dateStart.Year;
            int yearEnd = dateEnd.Year;

            int dayStart = dateStart.Day;
            int dayEnd = dateEnd.Day;

            int numDays = 0;

            int years = yearEnd - yearStart;

            numDays = dayEnd - dayStart;
            numDays += years * 365;

            if (dayEnd <= dayStart)
            {
                years--;
            }

            if (years < maxYears)
            {
                return numDays;
            }

            return -1;
        }
    }
}
