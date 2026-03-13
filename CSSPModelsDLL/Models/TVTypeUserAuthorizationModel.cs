using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class TVTypeUserAuthorizationModel : LastUpdateAndContactModel
    {
        public TVTypeUserAuthorizationModel()
        {
        }
        public int TVTypeUserAuthorizationID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int ContactTVItemID { get; set; }
        public TVTypeEnum TVType { get; set; }
        public string TVPath { get; set; }
        public int TVLevel { get; set; }
        public TVAuthEnum TVAuth { get; set; }
    }
}
