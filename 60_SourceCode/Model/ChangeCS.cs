using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChangeCS
    {
        private string _name;
        private string _type;
        private string _status;


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public ChangeCS() { }

        public ChangeCS(string name, string type)
        {
            this._name = name;
            this._type = type;
        }

        public ChangeCS(string name, string type, string status)
        {
            this._name = name;
            this._type = type;
            this._status = status;
        }
    }
}
