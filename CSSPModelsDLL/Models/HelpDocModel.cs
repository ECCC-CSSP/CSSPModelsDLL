using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class HelpDocModel : LastUpdateAndContactModel
    {
        public HelpDocModel()
        {
        }
        public int HelpDocID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public string DocKey { get; set; }
        public LanguageEnum Language { get; set; }
        public string DocHTMLText { get; set; }
    }
}
