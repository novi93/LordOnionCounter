using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChangeCSLog
    {
        private int _changesetID;
        private List<ItemCS> _lsItemCS;
        private List<StatusLog> _lsStatusLog;


        public int ChangesetID
        {
            get
            {
                return _changesetID;
            }

            set
            {
                _changesetID = value;
            }
        }

        public List<ItemCS> LsItemCS
        {
            get
            {
                return _lsItemCS;
            }

            set
            {
                _lsItemCS = value;
            }
        }

        public List<StatusLog> LsStatusLog
        {
            get
            {
                return _lsStatusLog;
            }

            set
            {
                _lsStatusLog = value;
            }
        }

        public ChangeCSLog() { }
    }
}
