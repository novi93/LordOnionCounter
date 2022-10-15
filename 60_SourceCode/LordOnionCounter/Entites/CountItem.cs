using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.ComponentModel;

namespace LOC.Entites
{
    public class CountItem
    {
        public CountItem()
        {
            Id = Guid.NewGuid();
        }

        [Browsable(false)]
        public Guid Id { get; set; }

        [Browsable(false)]
        public Change BaseItem { get; set; }

        [Browsable(false)]
        public Change MinItem { get; set; }

        [Browsable(false)]
        public Change MaxItem { get; set; }
    }
}
