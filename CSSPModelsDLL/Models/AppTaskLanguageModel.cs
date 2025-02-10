using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class AppTaskLanguageModel : LastUpdateAndContactModel
    {
        public AppTaskLanguageModel()
        {
        }
        public int AppTaskLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int AppTaskID { get; set; }
        public LanguageEnum Language { get; set; }
        public string StatusText { get; set; }
        public string ErrorText { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
