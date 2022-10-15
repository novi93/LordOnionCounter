using System.ComponentModel;

namespace LOC.Entites
{
    public class GridWI
    {

        [DisplayName("")]
        [DefaultValue(true)]
        public bool Check { get; set; }

        [DisplayName("Id")]
        [ReadOnly(true)]
        public int Id { get; set; }

        [DisplayName("Title")]
        [ReadOnly(true)]
        public string Title { get; set; }

        [DisplayName("CreatedBy")]
        [ReadOnly(true)]
        public string CreatedBy { get; set; }

        [DisplayName("Base LOC")]
        [ReadOnly(true)]
        public int BaseLOC { get; set; }
        [DisplayName("Church Loc")]
        [ReadOnly(true)]
        public int ChurchLOC { get; set; }
    }
}
