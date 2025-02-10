using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class MWQMSampleLanguageModel : LastUpdateAndContactModel
    {
        public MWQMSampleLanguageModel()
        {
        }
        public int MWQMSampleLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int MWQMSampleID { get; set; }
        public LanguageEnum Language { get; set; }
        public string MWQMSampleNote { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
