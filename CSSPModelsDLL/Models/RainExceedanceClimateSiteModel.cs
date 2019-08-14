using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class RainExceedanceClimateSiteModel : LastUpdateAndContactModel
    {
        public RainExceedanceClimateSiteModel()
        {
        }
        public int RainExceedanceClimateSiteID { get; set; }
        public int RainExceedanceID { get; set; }
        public int ClimateSiteID { get; set; }
    }
}
