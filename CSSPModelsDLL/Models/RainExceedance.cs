using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class RainExceedanceModel : LastUpdateAndContactModel
    {
        public RainExceedanceModel()
        {
        }
        public int RainExceedanceID { get; set; }
        public int RainExceedanceTVItemID { get; set; }
        public string RainExceedanceName { get; set; }
        public Nullable<int> StartMonth { get; set; }
        public Nullable<int> StartDay { get; set; }
        public Nullable<int> EndMonth { get; set; }
        public Nullable<int> EndDay { get; set; }
        public Nullable<float> RainMaximum_mm { get; set; }
        public Nullable<int> StakeholdersEmailDistributionListID { get; set; }
        public string StakeholdersEmailDistributionListName { get; set; }
        public Nullable<int> OnlyStaffEmailDistributionListID { get; set; }
        public string OnlyStaffEmailDistributionListName { get; set; }
    }
}
