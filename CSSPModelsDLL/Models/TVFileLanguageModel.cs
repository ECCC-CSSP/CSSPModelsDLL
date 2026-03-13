using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class TVFileLanguageModel : LastUpdateAndContactModel
    {
        public TVFileLanguageModel()
        {
        }
        public int TVFileLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int TVFileID { get; set; }
        public LanguageEnum Language { get; set; }
        public string FileDescription { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
