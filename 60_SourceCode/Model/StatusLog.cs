using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StatusLog
    {
        private ItemCS _it;
        private string _status;

        public ItemCS It
        {
            get
            {
                return _it;
            }

            set
            {
                _it = value;
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


    }
}
