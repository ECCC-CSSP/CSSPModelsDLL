using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class EmailDistributionListLanguageModel : LastUpdateAndContactModel
    {
        public EmailDistributionListLanguageModel()
        {
        }
        public int EmailDistributionListLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int EmailDistributionListID { get; set; }
        public LanguageEnum Language { get; set; }
        public string EmailListName { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
