using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class EmailDistributionListContactLanguageModel : LastUpdateAndContactModel
    {
        public EmailDistributionListContactLanguageModel()
        {
        }
        public int EmailDistributionListContactLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int EmailDistributionListContactID { get; set; }
        public LanguageEnum Language { get; set; }
        public string Agency { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
