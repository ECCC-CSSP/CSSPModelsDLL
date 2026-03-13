using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class MWQMSiteLanguageModel : LastUpdateAndContactModel
    {
        public MWQMSiteLanguageModel()
        {
        }
        public int MWQMSiteLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int MWQMSiteID { get; set; }
        public LanguageEnum Language { get; set; }
        public string MWQMSiteName { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
