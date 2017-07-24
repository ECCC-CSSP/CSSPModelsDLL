using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSPModelsDLL.Models;
using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class BoxModelResultModel : LastUpdateAndContactModel
    {
        public BoxModelResultModel()
        {
        }
        public int BoxModelResultID { get; set; }
        public int BoxModelID { get; set; }
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        public double Volume_m3 { get; set; }
        public double Surface_m2 { get; set; }
        public double Radius_m { get; set; }
        public double LeftSideDiameterLineAngle_deg { get; set; }
        public double CircleCenterLatitude { get; set; }
        public double CircleCenterLongitude { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }
        public double RectLength_m { get; set; }
        public double RectWidth_m { get; set; }
        public double LeftSideLineAngle_deg { get; set; }
        public double LeftSideLineStartLatitude { get; set; }
        public double LeftSideLineStartLongitude { get; set; }
    }
}
