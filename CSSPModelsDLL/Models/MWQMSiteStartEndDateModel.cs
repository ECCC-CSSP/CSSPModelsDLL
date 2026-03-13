using CSSPEnumsDLL.Enums;
using System;

namespace CSSPModelsDLL.Models
{
    public class MWQMSiteStartEndDateModel : LastUpdateAndContactModel
    {
        public MWQMSiteStartEndDateModel()
        {
        }
        public int MWQMSiteStartEndDateID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
