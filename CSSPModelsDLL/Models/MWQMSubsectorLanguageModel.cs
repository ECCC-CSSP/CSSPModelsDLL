﻿using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class MWQMSubsectorLanguageModel : LastUpdateAndContactModel
    {
        public MWQMSubsectorLanguageModel()
        {
        }
        public int MWQMSubsectorLanguageID { get; set; }
        public int MWQMSubsectorID { get; set; }
        public LanguageEnum Language { get; set; }
        public string SubsectorDesc { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
    }
}
