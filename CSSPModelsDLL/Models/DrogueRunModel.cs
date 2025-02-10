using CSSPEnumsDLL.Enums;
using System;

namespace CSSPModelsDLL.Models
{
    public class DrogueRunModel : LastUpdateAndContactModel
    {
        public DrogueRunModel()
        {
        }
        public int DrogueRunID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int SubsectorTVItemID { get; set; }
        public int DrogueNumber { get; set; }
        public DrogueTypeEnum DrogueType { get; set; }
        public DateTime RunStartDateTime { get; set; }
        public bool IsRisingTide { get; set; }
    }
}
