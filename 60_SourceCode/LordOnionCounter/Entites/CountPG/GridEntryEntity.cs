using Microsoft.TeamFoundation.VersionControl.Client;
using System.ComponentModel;
using System.IO;

namespace LOC.Entites
{
    public class GridEntryEntity : CountItem
    {

        [DisplayName("")]
        [DefaultValue(true)]
        public bool Check { get; set; }

        [DisplayName("ItemId")]
        [ReadOnly(true)]
        public int? ItemId { get { return MinItem.Item.ItemId; } }

        [DisplayName("Diff Path")]
        [ReadOnly(true)]
        public string DiffPath { get { return Path.GetFileName(MinItem?.Item.ServerItem); } }

        [DisplayName("Diff Cs")]
        [ReadOnly(true)]
        public int? DiffChangesetId { get { return MaxItem?.Item.ChangesetId; } }
        [ReadOnly(true)]
        [Browsable(false)]
        public bool IsFile { get { return MinItem?.Item.ItemType == ItemType.File; } }

        [DisplayName("Base Path")]
        public string BaseServerItem { get { return Path.GetFileName(BaseItem?.Item.ServerItem); } }

        [DisplayName("Base Cs")]
        public int? BaseChangesetId { get { return BaseItem?.Item.ChangesetId; } }

        [ReadOnly(true)]
        [Browsable(false)]
        public ChangeType ChangeType { get { return MinItem.ChangeType; } }

        //[ReadOnly(true)]
        //public bool IsNew
        //{
        //    get
        //    {
        //        return MinItem.ChangeType.HasFlag(ChangeType.Add)
        //            && !MinItem.ChangeType.HasFlag(ChangeType.Branch);
        //    }
        //}
    }
}
