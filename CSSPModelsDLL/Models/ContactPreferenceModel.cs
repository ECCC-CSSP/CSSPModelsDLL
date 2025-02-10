using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class ContactPreferenceModel : LastUpdateAndContactModel
    {
        public ContactPreferenceModel()
        {
        }
        public int ContactPreferenceID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int ContactID { get; set; }
        public TVTypeEnum TVType { get; set; }
        public int MarkerSize { get; set; }
    }
}
