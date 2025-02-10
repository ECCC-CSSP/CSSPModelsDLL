using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class InfrastructureLanguageModel : LastUpdateAndContactModel
    {
        public InfrastructureLanguageModel()
        {
        }
        public int InfrastructureLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int InfrastructureID { get; set; }
        public LanguageEnum Language { get; set; }
        public string Comment { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
