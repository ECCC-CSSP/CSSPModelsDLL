using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class AppErrLogModel : LastUpdateAndContactModel
    {
        public AppErrLogModel()
        {
        }

        public int AppErrLogID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public string Tag { get; set; }
        public int LineNumber { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public System.DateTime DateTime_UTC { get; set; }
    }
}
