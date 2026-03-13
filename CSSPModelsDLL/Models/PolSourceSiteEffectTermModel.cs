using CSSPEnumsDLL.Enums;
using System;

namespace CSSPModelsDLL.Models
{
    public class PolSourceSiteEffectTermModel : LastUpdateAndContactModel
    {
        public PolSourceSiteEffectTermModel()
        {
        }
        public int PolSourceSiteEffectTermID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public bool IsGroup { get; set; }
        public Nullable<int> UnderGroupID { get; set; }
        public string EffectTermEN { get; set; }
        public string EffectTermFR { get; set; }
    }
}
