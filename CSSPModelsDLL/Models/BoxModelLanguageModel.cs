using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class BoxModelLanguageModel : LastUpdateAndContactModel
    {
        public BoxModelLanguageModel()
        {
        }
        public int BoxModelLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int BoxModelID { get; set; }
        public LanguageEnum Language { get; set; }
        public string ScenarioName { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
