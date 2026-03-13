using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class CoCoRaHSSiteModel : LastUpdateAndContactModel
    {
        public CoCoRaHSSiteModel()
        {
        }
        public int CoCoRaHSSiteID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public string StationNumber { get; set; }
        public string StationName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
