using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class SpillLanguageModel : LastUpdateAndContactModel
    {
        public SpillLanguageModel()
        {
        }
        public int SpillLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int SpillID { get; set; }
        public LanguageEnum Language { get; set; }
        public string SpillComment { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
