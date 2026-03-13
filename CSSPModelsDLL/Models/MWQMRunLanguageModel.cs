using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class MWQMRunLanguageModel : LastUpdateAndContactModel
    {
        public MWQMRunLanguageModel()
        {
        }
        public int MWQMRunLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int MWQMRunID { get; set; }
        public LanguageEnum Language { get; set; }
        public string RunComment { get; set; }
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        public string RunWeatherComment { get; set; }
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
    }
}
