using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;

namespace CSSPModelsDLL.Models
{
    public class PolSourceSiteEffectModel : LastUpdateAndContactModel
    {
        public PolSourceSiteEffectModel()
        {
            PolSourceSiteEffectTermModelList = new List<PolSourceSiteEffectTermModel>();
        }
        public int PolSourceSiteEffectID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int PolSourceSiteOrInfrastructureTVItemID { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public string PolSourceSiteEffectTermIDs { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Site { get; set; }
        public Nullable<int> AnalysisDocumentTVItemID { get; set; }
        public List<PolSourceSiteEffectTermModel> PolSourceSiteEffectTermModelList { get; set; }
    }

}
