using CSSPEnumsDLL.Enums;
using System.Collections.Generic;

namespace CSSPModelsDLL.Models
{
    public class PolSourceObservationIssueModel : LastUpdateAndContactModel
    {
        public PolSourceObservationIssueModel()
        {
            PolSourceObsInfoList = new List<PolSourceObsInfoEnum>();
        }
        public int PolSourceObservationIssueID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public int PolSourceObservationID { get; set; }
        public string ObservationInfo { get; set; }
        public int Ordinal { get; set; }
        public string ExtraComment { get; set; }
        public List<PolSourceObsInfoEnum> PolSourceObsInfoList { get; set; }
    }
}
