using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class ContactShortcutModel : LastUpdateAndContactModel
    {
        public ContactShortcutModel()
        {
        }
        public int ContactShortcutID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int ContactID { get; set; }
        public string ShortCutText { get; set; }
        public string ShortCutAddress { get; set; }
    }
}
