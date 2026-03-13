using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Models
{
    public class LogModel : LastUpdateAndContactModel
    {
        public LogModel()
        {
        }

        public int LogID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public string TableName { get; set; }
        public int ID { get; set; }
        public LogCommandEnum LogCommand { get; set; }
        public string Information { get; set; }
    }
}
