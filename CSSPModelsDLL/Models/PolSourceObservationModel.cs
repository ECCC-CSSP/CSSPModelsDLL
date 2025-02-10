using CSSPEnumsDLL.Enums;
using System.Collections.Generic;

namespace CSSPModelsDLL.Models
{
    public class PolSourceObservationModel : LastUpdateAndContactModel
    {
        public PolSourceObservationModel()
        {
            PolSourceObservationIssueModelList = new List<PolSourceObservationIssueModel>();
        }
        public int PolSourceObservationID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int PolSourceSiteID { get; set; }
        public int PolSourceSiteTVItemID { get; set; }
        public string PolSourceSiteTVText { get; set; }
        public System.DateTime ObservationDate_Local { get; set; }
        public string Observation_ToBeDeleted { get; set; }
        public List<PolSourceObservationIssueModel> PolSourceObservationIssueModelList { get; set; }
        public int ContactTVItemID { get; set; }
        public string ContactTVText { get; set; }
        public bool DesktopReviewed { get; set; }
    }
}
