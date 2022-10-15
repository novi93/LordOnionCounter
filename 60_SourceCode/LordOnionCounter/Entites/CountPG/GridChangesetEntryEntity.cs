using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LOC.Entites
{
    [ReadOnly(true)]
    public class GridChangesetEntryEntity
    {
        [DisplayName("")]
        public bool Check { get; set; }

        [ReadOnly(true)]
        [DisplayName("Changeset")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0:C}")]
        public int? ChangesetId { get; set; }

        [ReadOnly(true)]
        public string Comment { get; set; }

        [ReadOnly(true)]
        [DisplayName("Committer")]
        public string CommitterDisplayName { get; set; }

    }
}
