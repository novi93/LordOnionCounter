using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LOC.Entites
{
    [ReadOnly(true)]
    class CountDetailGrdEntity
    {
        public CountDetailGrdEntity()
        {
            PercentChurch = 100;
            PercentSame = 0;
        }

        [ReadOnly(true)]
        public string File { get; set; }

        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Same")]
        public int Same_Code { get; set; }

        [ReadOnly(true)]
        [DisplayName("Added")]
        public int Added_Code { get; set; }

        [ReadOnly(true)]
        [DisplayName("Modified")]
        public int Modified_Code { get; set; }

        [ReadOnly(true)]
        [DisplayName("Removed")]
        public int Removed_Code { get; set; }

        //[ReadOnly(true)]
        //[DisplayName("Added+Modified")]
        //public int Add_Mod
        //{
        //    get { return Added_Code + Modified_Code; }
        //}

        [DisplayName("% Church")]
        public decimal PercentChurch { get; set; }

        [DisplayName("% Same")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public decimal PercentSame { get; set; }

        [DisplayName("Added+Modified+Removed")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public int Add_Mod_Del
        {
            get
            {
                return Convert.ToInt32( PercentSame / 100 * Same_Code
                  + PercentChurch / 100 * (Added_Code + Modified_Code + Removed_Code));
            }
        }

        #region not Browsable
        [Browsable(false)]
        public string FullPath { get; set; }
        #endregion
    }
}
