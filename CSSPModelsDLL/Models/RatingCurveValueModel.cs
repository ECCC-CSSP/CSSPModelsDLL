using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class RatingCurveValueModel : LastUpdateAndContactModel
    {
        public RatingCurveValueModel()
        {
        }
        public int RatingCurveValueID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int RatingCurveID { get; set; }
        public double StageValue_m { get; set; }
        public double DischargeValue_m3_s { get; set; }
    }
}
