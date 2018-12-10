using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabus_Generator
{
    class Term
    {

        public string Title { get; set; }

        public DateTime DayStart { get; set; }

        public DateTime DayEnd { get; set; }

        public int Weeks { get; set; }
       
        public Term(string _title, DateTime _dayStart, DateTime _dayEnd)
        {
            Title = _title;
            DayStart = _dayStart;
            DayEnd = _dayEnd;

            double numDays = (_dayEnd - _dayStart).TotalDays;
            Weeks = 1 + ((int)numDays / 7);
        }
    }
}
