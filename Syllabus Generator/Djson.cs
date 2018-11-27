using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabus_Generator
{
    class Djson
    {
        private object _data;
        private string _json;
        private List<Assignment> _assignments;
        private List<Term> _terms;

        public Djson (object _data)
        {
            this._data = _data;

            _json = JsonConvert.SerializeObject(_data);
            saveJsonFile(_json);
        }

        private object readJsonFile(string fileName, object Data)
        {

            string output = "";

            return JsonConvert.DeserializeObject<Assignment>(output);
        }

        private void saveJsonFile(string json)
        {

        }

    }
}
