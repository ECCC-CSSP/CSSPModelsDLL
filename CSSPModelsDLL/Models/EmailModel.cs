using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class EmailModel : LastUpdateAndContactModel
    {
        public EmailModel()
        {
        }
        public int EmailID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int EmailTVItemID { get; set; }
        public string EmailAddress { get; set; }
        public EmailTypeEnum EmailType { get; set; }
        public string EmailTypeText { get; set; }
    }
}
