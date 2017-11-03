using CSSPModelsDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSPEnumsDLL.Enums;

namespace CSSPModelsDLL.Services
{
    public class BaseModelService
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public BaseModelService(LanguageEnum LanguageRequest)
        {
        }
        #endregion Constructors

        #region Functions public 
        public void FillPolSourceObsInfoChild(List<PolSourceObsInfoChild> polSourceObsInfoChildList)
        {
            polSourceObsInfoChildList.Clear();
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.Start, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceFromShoreInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceOnWaterMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeLandStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CropStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PastureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FeedlotStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FarmStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FarmStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustryStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypeOfFishStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundFacilitiesStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.UrbanStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WildlifeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MunicipalSystemStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MunicipalSystemStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAgricultureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfLivestockStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalNumberPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointSourceWildlifeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDumpingStationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointSourceManureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManurePileSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManurePileSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureSiteStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterDisposalAtSeaStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterDisposalAtSeaStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSeaportStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSeaportStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSewageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterNumberPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineIssueStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineIssueStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SlipwayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeShoreStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskAStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskAStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskBStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskCStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandBased, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceFromShoreInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterBased, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceOnWaterMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersOnShore, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersLessThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween100And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween250And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween500And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersMoreThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersLessThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersBetween100And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersBetween250And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersBetween500And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersMoreThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeLandStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeLandStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeLandStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandAgriculture, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandForested, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandIndustry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustryStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandRecreation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandUrban, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.UrbanStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeShore, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureCrop, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CropStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturePasture, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PastureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureFeedlot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FeedlotStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FarmStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureBuilding, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropFood, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropHay, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropPeatMoss, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureFallow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FarmHobby, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FarmCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedLoggingActivity, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedClearcut, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedRegrowth, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedBuilding, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryAirport, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryLandfill, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryFisheriesRelated, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryWaste, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryStorageTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishProcessingShellfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishProcessingFinfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishProcessingFishMeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineWharf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSeaWall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfCommercialTransportation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfFishing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfPrivate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfMarina, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfAbandoned, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationFerry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCampground, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationDayUseArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationSwimmingArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationRecreationaltArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCommunityCentre, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationGolfCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundNoDumpStn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundwithDumpStn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageCesspool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDirectDischarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewagePrivyOuthouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageMunicipalSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemDrainageField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemFullRention, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemLagoon, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticNoStructure, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanStormWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanSurfaceRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanDumpStation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WildlifeBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WildlifeLandMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WildlifeMarineMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MuncipialSystemConnected, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MunicipalSystemNotConnected, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankFuel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankPropane, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankChemicals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSizeSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSizeLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingResidentialFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingWarehouseFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingCommericalFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingBarnFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingRecreational, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedRecreational, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedFactory, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingindustryWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryFactory, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishHatchery, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishTanks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCottage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllHotelMotel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberBetween1and5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberbBetween5and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberbBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberbBetween25and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSizeSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSizeLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceLivestock, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfLivestockStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourcePeople, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceDrainagewater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueSourceManurePile, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManurePileSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueAbsent1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeResidental, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeIndustrial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeWoodwaste, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberPresentLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberPresentBetween5and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberPresentBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberPresentGreaterThan25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualLargeDomestic, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualSmallDomestic, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualDomesticBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualFurFarms, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualDomesticMixture, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualSmallWildAnimals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualLargeWildAnimals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualLargeBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualMediumBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualSmallBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentBetween5and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentBetween25and100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceDirectInputToMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween5and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween25and50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween50and100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetweenMoreThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityPresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDumpingStationPresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDumpingStationAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandPipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeDirectInputToMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceManureLandDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceManureDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersLessThan30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween30and100cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween100and200cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersMoreThan200cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseCementHoldingTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseSittingOnGround, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersLessThan1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween1And5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween5And25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersMoreThan25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAlongRoad, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchBetweenAcrossProperties, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainagePavedSurfaces, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageVegetatedSurfaces, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageBareSoilSurfaces, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManurePileSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManurePileLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterDisposalAtSeaStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterMarinePark, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterSeaport, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSeaportStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceSandBar, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureSiteActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureSiteFallow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureFloatingBags, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSubmergedLines, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureVessel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureResidental, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterDumpSiteActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterDumpSiteNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaportRecreational, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaportCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypeSalt, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypeBrachish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypeFresh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAreaSizeSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAreaSizeLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourcePeople, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourceWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourceAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCountNumberLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCountNumberBetween5and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCountNumberBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCountNumberGreaterThan25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSewageDirectDischarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSepticSystemFullRention, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterNumberPresentLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterNumberPresentBetween5and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterNumberPresentBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterNumberPresentGreaterThan25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualSmallMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualLargeMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualLargeBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualMediumBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualSmallBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSandy, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineIssueStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRocky, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineIssueStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineLandFill, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSlipway, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SlipwayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineDayuse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayPaved, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayRocks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusNonPollutionSource, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskAStart,
            });
        }
        #endregion Functions public 
    }
}