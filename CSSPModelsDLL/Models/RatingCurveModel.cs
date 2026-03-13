using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class RatingCurveModel : LastUpdateAndContactModel
    {
        public RatingCurveModel()
        {
        }
        public int RatingCurveID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int HydrometricSiteID { get; set; }
        public string HydrometricSiteTVText { get; set; }
        public string RatingCurveNumber { get; set; }
    }
}
