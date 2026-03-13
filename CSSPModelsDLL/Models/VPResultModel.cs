using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class VPResultModel : LastUpdateAndContactModel
    {
        public VPResultModel()
        {
        }
        public int VPResultID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int VPScenarioID { get; set; }
        public int Ordinal { get; set; }
        public int Concentration_MPN_100ml { get; set; }
        public double Dilution { get; set; }
        public double FarFieldWidth_m { get; set; }
        public double DispersionDistance_m { get; set; }
        public double TravelTime_hour { get; set; }
    }
}
