using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class MWQMSitePolSourceSiteModel : LastUpdateAndContactModel
    {
        public MWQMSitePolSourceSiteModel()
        {
        }
        public int MWQMSitePolSourceSiteID { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public string MWQMSiteTVText { get; set; }
        public int PolSourceSiteTVItemID { get; set; }
        public string PolSourceSiteTVText { get; set; }
        public TVTypeEnum TVType { get; set; }
        public string LinkReasons { get; set; }
    }

}
