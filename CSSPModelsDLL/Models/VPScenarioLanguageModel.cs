using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class VPScenarioLanguageModel : LastUpdateAndContactModel
    {
        public VPScenarioLanguageModel()
        {
        }
        public int VPScenarioLanguageID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int VPScenarioID { get; set; }
        public LanguageEnum Language { get; set; }
        public string VPScenarioName { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
