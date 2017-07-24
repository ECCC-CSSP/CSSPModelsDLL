﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class RainExceedanceModel : LastUpdateAndContactModel
    {
        public RainExceedanceModel()
        {
        }
        public int RainExceedanceID { get; set; }
        public bool YearRound { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public Nullable<float> RainMaximum { get; set; }
        public Nullable<float> RainExtreme { get; set; }
        public int DaysPriorToStart { get; set; }
        public bool RepeatEveryYear { get; set; }
        public string ProvinceTVItemIDs { get; set; }
        public string SubsectorTVItemIDs { get; set; }
        public string ClimateSiteTVItemIDs { get; set; }
        public string EmailDistributionListIDs { get; set; }
    }
}
