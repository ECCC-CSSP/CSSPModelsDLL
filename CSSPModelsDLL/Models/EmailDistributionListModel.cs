using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class EmailDistributionListModel : LastUpdateAndContactModel
    {
        public EmailDistributionListModel()
        {
        }
        public int EmailDistributionListID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int ParentTVItemID { get; set; }
        public string EmailListName { get; set; }
        public int Ordinal { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
