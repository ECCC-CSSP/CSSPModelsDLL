using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class TideSiteModel : LastUpdateAndContactModel
    {
        public TideSiteModel()
        {
        }
        public int TideSiteID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int TideSiteTVItemID { get; set; }
        public string TideSiteName { get; set; }
        public string Province { get; set; }
        public int sid { get; set; }
        public int Zone { get; set; }
    }
}
