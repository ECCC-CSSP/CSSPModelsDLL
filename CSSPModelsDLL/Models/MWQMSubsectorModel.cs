﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class MWQMSubsectorModel : LastUpdateAndContactModel
    {
        public MWQMSubsectorModel()
        {
        }
        public int MWQMSubsectorID { get; set; }
        public int MWQMSubsectorTVItemID { get; set; }
        public string MWQMSubsectorTVText { get; set; }
        public string SubsectorHistoricKey { get; set; }
        public string SubsectorDesc { get; set; }
        public string TideLocationSIDText { get; set; }
    }

    public class MWQMSubsectorAnalysisModel
    {
        public MWQMSubsectorAnalysisModel()
        {
            MWQMSiteAnalysisModelList = new List<MWQMSiteAnalysisModel>();
            MWQMRunAnalysisModelList = new List<MWQMRunAnalysisModel>();
            MWQMSampleAnalysisModelList = new List<MWQMSampleAnalysisModel>();
        }

        public MWQMSubsectorModel MWQMSubsectorModel { get; set; }
        public List<MWQMSiteAnalysisModel> MWQMSiteAnalysisModelList { get; set; }
        public List<MWQMRunAnalysisModel> MWQMRunAnalysisModelList { get; set; }
        public List<MWQMSampleAnalysisModel> MWQMSampleAnalysisModelList { get; set; }

    }

    public class MWQMSiteAnalysisModel : MWQMSiteModel
    {
        public MWQMSiteAnalysisModel()
        {
        }

        public bool IsActive { get; set; }
    }

    public class MWQMRunAnalysisModel : MWQMRunModel
    {
        public MWQMRunAnalysisModel()
        {
        }

        public bool IsActive { get; set; }
    }

    public class MWQMSampleAnalysisModel : MWQMSampleModel
    {
        public MWQMSampleAnalysisModel()
        {
        }
    }

    public class MWQMSubsectorClimateSites
    {
        public MWQMSubsectorClimateSites()
        {
            ClimateSiteModelUsedAndWithinDistanceModelList = new List<ClimateSiteWithLatLngAndOrdinalModel>();
            //MWQMRunModelList = new List<MWQMRunModel>();
            Error = "";
        }

        public string Error { get; set; }
        public List<ClimateSiteWithLatLngAndOrdinalModel> ClimateSiteModelUsedAndWithinDistanceModelList { get; set; }
        public MWQMSubsectorWithLatLngModel MWQMSubsectorWithLatLngModel { get; set; }
        //public List<MWQMRunModel> MWQMRunModelList { get; set; }
    }

    public class MWQMSubsectorWithLatLngModel : MWQMSubsectorModel
    {
        public MWQMSubsectorWithLatLngModel()
        {
        }

        public float Lat { get; set; }
        public float Lng { get; set; }

    }
    public class ClimateSitesAndRains
    {
        public ClimateSitesAndRains()
        {
            Error = "";
            ClimateDataValueModelList = new List<Models.ClimateDataValueModel>();
        }

        public string Error { get; set; }
        public ClimateSiteModel ClimateSiteModel { get; set; }
        public List<ClimateDataValueModel> ClimateDataValueModelList { get; set; }
    }

    public class ClimateSiteWithLatLngAndOrdinalModel : ClimateSiteModel
    {
        public ClimateSiteWithLatLngAndOrdinalModel()
        {
            YearsOfUseText = "";
        }

        public float Lat { get; set; }
        public float Lng { get; set; }
        public int Ordinal { get; set; }
        public float Distance_km { get; set; }
        public int MapInfoID { get; set; }
        public string YearsOfUseText { get; set; }
    }
    public class ClimateSiteTVItemIDYearsText
    {
        public ClimateSiteTVItemIDYearsText()
        {
            ClimateSiteUseStartEndYearList = new List<ClimateSiteUseStartEndYears>();
           }

        public int ClimateSiteTVItemID { get; set; }
        public string YearsText { get; set; }
        public List<ClimateSiteUseStartEndYears> ClimateSiteUseStartEndYearList { get; set; }
    }
    public class ClimateSiteUseStartEndYears
    {
        public ClimateSiteUseStartEndYears()
        {
        }

        public int StartYear { get; set; }
        public int? EndYear { get; set; }
    }
    public class ClimateSiteUseOfSiteModel
    {
        public ClimateSiteUseOfSiteModel()
        {
            ClimateSiteText = "";
            UseOfSiteModelList = new List<UseOfSiteModel>();
        }

        public string ClimateSiteText { get; set; }
        public List<UseOfSiteModel> UseOfSiteModelList { get; set; }
    }
}