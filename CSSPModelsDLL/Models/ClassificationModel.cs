using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class ClassificationModel : LastUpdateAndContactModel
    {
        public ClassificationModel()
        {
        }
        public int ClassificationID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int ClassificationTVItemID { get; set; }
        public string ClassificationTVText { get; set; }
        public ClassificationTypeEnum ClassificationType { get; set; }
        public int Ordinal { get; set; }
    }
}
