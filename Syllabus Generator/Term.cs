using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabus_Generator
{
    class TermJson
    {
        [JsonProperty("term")]
        public Term term { get; set; }
    }

    class Term
    {

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("DayStart")]
        public DateTime DayStart { get; set; }

        [JsonProperty("DayEnd")]
        public DateTime DayEnd { get; set; }

        [JsonProperty("Weeks")]
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
