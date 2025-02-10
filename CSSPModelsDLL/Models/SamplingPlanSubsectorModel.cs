using CSSPEnumsDLL.Enums;
using System.Collections.Generic;

namespace CSSPModelsDLL.Models
{
    public class SamplingPlanSubsectorModel : LastUpdateAndContactModel
    {
        public SamplingPlanSubsectorModel()
        {
            SamplingPlanSubsectorSiteModelList = new List<SamplingPlanSubsectorSiteModel>();
        }

        public int SamplingPlanSubsectorID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int SamplingPlanID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public string SubsectorTVText { get; set; }
        public List<SamplingPlanSubsectorSiteModel> SamplingPlanSubsectorSiteModelList { get; set; }
        public int SiteCount { get; set; }
    }
}
