using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TeamProjectCollection
    {
        public TeamProjectCollection() { }

        private string _name;
        private string _uri;

        public string Uri
        {
            get
            {
                return _uri;
            }

            set
            {
                _uri = value;
            }
        }

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
    }
}
