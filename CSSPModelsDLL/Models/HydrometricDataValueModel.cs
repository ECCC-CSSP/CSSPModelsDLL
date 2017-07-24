using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class HydrometricDataValueModel : LastUpdateAndContactModel
    {
        public HydrometricDataValueModel()
        {
        }
        public int HydrometricDataValueID { get; set; }
        public int HydrometricSiteID { get; set; }
        public System.DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        public StorageDataTypeEnum StorageDataType { get; set; }
        public double Flow_m3_s { get; set; }
        public string HourlyValues { get; set; }
    }
}
