using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabus_Generator
{
    class Assignment
    {
        private int _id;
        private string _title;
        private string _description;
        private int _points;
        private DateTime _dueDate;

        public Assignment(int _id, string _title, string _description, int _points, DateTime _dueDate)
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
    }
}
