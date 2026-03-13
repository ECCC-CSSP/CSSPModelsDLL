using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class SamplingPlanSubsectorSiteModel : LastUpdateAndContactModel
    {
        public SamplingPlanSubsectorSiteModel()
        {
        }

        public int SamplingPlanSubsectorSiteID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int SamplingPlanSubsectorID { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public string MWQMSiteText { get; set; }
        public bool IsDuplicate { get; set; }
    }
}
