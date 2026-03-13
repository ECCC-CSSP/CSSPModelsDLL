using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class MWQMSubsectorLanguageModel : LastUpdateAndContactModel
    {
        public MWQMSubsectorLanguageModel()
        {
        }
        public int MWQMSubsectorLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int MWQMSubsectorID { get; set; }
        public LanguageEnum Language { get; set; }
        public string SubsectorDesc { get; set; }
        public TranslationStatusEnum TranslationStatusSubsectorDesc { get; set; }
        public string LogBook { get; set; }
        public TranslationStatusEnum TranslationStatusLogBook { get; set; }
    }
}
