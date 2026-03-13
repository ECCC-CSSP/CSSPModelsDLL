using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class TelModel : LastUpdateAndContactModel
    {
        public TelModel()
        {
        }
        public int TelID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int TelTVItemID { get; set; }
        public string TelNumber { get; set; }
        public TelTypeEnum TelType { get; set; }
        public string TelTypeText { get; set; }
    }
}
