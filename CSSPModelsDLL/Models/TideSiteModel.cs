using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class TideSiteModel : LastUpdateAndContactModel
    {
        public TideSiteModel()
        {
        }
        public int TideSiteID { get; set; }
        public int TideSiteTVItemID { get; set; }
        public string TideSiteTVText { get; set; }
        public string WebTideModel { get; set; }
        public double WebTideDatum_m { get; set; }
    }
}
