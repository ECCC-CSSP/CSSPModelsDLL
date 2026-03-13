using CSSPEnumsDLL.Enums;
using System;

namespace CSSPModelsDLL.Models
{
    public class CoCoRaHSValueModel : LastUpdateAndContactModel
    {
        public CoCoRaHSValueModel()
        {
        }
        public int CoCoRaHSValueID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int CoCoRaHSSiteID { get; set; }
        public DateTime ObservationDateAndTime { get; set; }
        public Nullable<double> TotalPrecipAmt { get; set; }
        public Nullable<double> NewSnowDepth { get; set; }
        public Nullable<double> NewSnowSWE { get; set; }
        public Nullable<double> TotalSnowDepth { get; set; }
        public Nullable<double> TotalSnowSWE { get; set; }
    }
}
