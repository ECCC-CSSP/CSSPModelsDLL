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
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparionZoneStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistancetoSaltWaterStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustryStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.INDCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypeOfFishStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineStructureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarNumPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourceSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfWharfCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarWhfWharfCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarBldCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundFacilitiesStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECFecalSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSewageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecNumPresentStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAgricultureSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAgricultureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AGRCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FORCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingTypeSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllSingleStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLandBIrdsStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesLandBIrdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLargeWildAnimalsStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesLargeWildAnimalsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesSmallWildAnimalsStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesSmallWildAnimalsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalNumberPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointSourceSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceSingleStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManureAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceTypeWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSiteStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AquacultureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnchorageMooringSiteStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnchorageMooringSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DisposalAtSeaStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DisposalAtSeaStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineParkStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineParkStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OutcropStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OutcropStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatAquaCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructActiveStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatStructActiveStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureSiteSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureSiteStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatStructCountNumberStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceOnWaterMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanSewageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanSewageStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineBirdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaBirdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LargeMarineMammalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SmallMarineanimalStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SmallMarineanimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineAnimalPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarinePointSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarinePointSourceStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FollowupStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMeters1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceFromShoreInMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistancetoSaltWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistancetoSaltWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistancetoSaltWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMeters1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistancetoSaltWaterInMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandFisheries, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandIndustry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustryStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandMarineStructure, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineStructureStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AGRCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropFood, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropHay, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CropPeatMoss, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureFallow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgrAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FarmHobby, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AGRCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FarmCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AGRCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersequals100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersbetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersBetween251And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersBetween501And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgrAreaMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedLoggingActivity, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedClearcut, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedRegrowth, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ForAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForestedBuilding, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FORCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersequals100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersbetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersBetween251And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersBetween501And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ForAreaMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryAirport, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.INDCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryLandfill, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryWaste, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryStorageTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustryBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.INDCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberBetween25and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.INDCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishShellfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishFinfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishLobster, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishFishMeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishHeldAlive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishPackaging, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishingRearing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishHatcherySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishTanksSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishPondsSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishWarehouseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishCommercialSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishHatchery, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishInsideTanks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishPounds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingFishCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberBetween25and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingFishStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineWharf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarWhfWharfCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarBldCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSeaWall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarNumPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentEqual10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentBetween25and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarNumPresentGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaWallSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourceSingleCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourceSinglePipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourceCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaWallSourcePipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfCommercialTransportation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfFishing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfPrivate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfMarina, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfAbandoned, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarBldCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountBetwee11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountBetween26and50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountBetween51and100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationFerrySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationPleasureCraftSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationFerry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TransportationPleasureCraft, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarBldCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MARBuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllCottageSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllTrailerSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllResidentialSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllWarehouseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllHotelMotelSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllSchoolSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllChurchSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllmedicalFacilitySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllCottage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllHotelMotel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllSchool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllChurch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MARBuildingAllmedicalFacility, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCampground, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationDayUseArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationSwimmingArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationRecreationaltArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecNumPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCommunityCentre, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecNumPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationGolfCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECcampgrdLotsapprox500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecTents, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecTrailersandTents, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.RecFecalSourcePeople, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecFecalSourceWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecFecalSourceDrainagewater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecFecalSourcePets, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSewageCesspool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSewagePrivyOuthouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSewageMunicipalSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSepticSystemDrainageField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSepticSystemLagoon, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSepticSystemConstructedWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecSepticFreeFlow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecNumPresentGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAllStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDirectDischarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageFlowStructure, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewagePrivyOuthouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemLeachateField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemFullRention, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageCesspool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticSystemLagoon, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageSystemConstructedWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageMunicipalSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticNoINformation, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankPropane, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StorageTankChemicals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize2000plus, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StorageTankStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingResidentialFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingWarehouseFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingCommericalFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingBarnFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingRecreationalFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingSchoolFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingChurchFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingMedicalFacilityFarmSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingResidentialFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingWarehouseFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingCommericalFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingBarnFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingRecreationalFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingSchoolFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingChurchFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingMedicalFacilityFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AGRCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingAgricultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FORCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BuildingForestedStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedResidentialSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedWarehouseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedRecreationalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedTrailerSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedFactorySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedSchoolSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedChurchSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedMedicalFacilitySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedRecreational, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedFactory, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedSchool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedChurch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingForestedMedicalFacility, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingindustryWarehouseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryFactorySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustrySchoolSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryChurchSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryMedicalFacilitySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingindustryWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryFactory, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustrySchool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryChurch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingIndustryMedicalFacility, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCottageSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllTrailerSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllResidentialSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllWarehouseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllHotelMotelSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllSchoolSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllChurchSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllmedicalFacilitySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCottage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllHotelMotel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllSchool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllChurch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BuildingAllmedicalFacility, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersEquals100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersBetween251And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersBetween501And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaMetersgreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MajorIssueSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourcePeople, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourcePets, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceLivestock, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfLivestockStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceDrainagewater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalProcessWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalPotentialContamination, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalSourceAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueSourceManurePile, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManureAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueAbsent1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueAccumulatedRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MajorIssueSurfaceRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualHorses, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualCows, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualSheep, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualPigs, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualDomesticMixtureLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualChickens, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualTurkeys, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualDucks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualGeese, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualDomesticMixtureSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualFurFarms, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualSmallWildAnimals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesSmallWildAnimalsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualLargeWildAnimals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesLargeWildAnimalsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEquallandBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesLandBIrdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesEqualMarinebirdsSeals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineAnimalPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLandBirdsCrows, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLandBirdsEagle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLargeWildAnimalsMoose, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLargeWildAnimalsDeer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesLargeWildAnimalsCoyote, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesSmallWildAnimalsFoxes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesSmallWildAnimalsGroundHogs, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesSmallWildAnimalsSkunks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox5000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan10000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WasteSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeLandCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeLandPipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeLandWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeLandDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeLandDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypeDirectInputToMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WasteSourceTypetoField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationOnFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationOffFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationBoth, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween11to25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween26to50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween51to75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween76to100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan250, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityNotObserved, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageDumpingStationNotObserved, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PointCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandCulvertSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandPipeSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandWaterCourseSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandDitchSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeLandDrainageSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterNoInformation, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween11And25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween26And40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersGreaterThan40, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchDirectlytoWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately70, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately90, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersapproximately100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureAreaMetersMoreThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PointSourceManureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AquacultureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnchorageMooringSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DisposalAtSeaStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceTypeWaterMarinePark, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineParkStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceLandOutcrop, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OutcropStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatAquaCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnchorageMooringSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatStructActiveStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterDisposalAtSeaStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarinePark, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatStructActiveStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OutcropSandBar, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OutcropRock, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OutcropIsland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSizeStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureCagesSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureFloatingBagsSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSubmergedLinesSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureLosterPoundCageSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureBargesSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureFloatingBags, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureSubmergedLines, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureLosterPoundCage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AquacultureBarges, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatStructCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructInactive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureVesselSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureBargeSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureResidentalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureCommercialSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureNotActiveSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureVessel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureResidental, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureCommercial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterStructureNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatStructCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterStructureSiteStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterDumpSiteActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual750, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersEqual1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterSizeMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersEqual1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceOnWaterMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypeStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourcePeople, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourceWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineAnimalPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalSourceAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterFecalProcessWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterFecalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanSewageWashroom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanSewageWashroomAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatNumberPresentGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterSewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualSmallMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SmallMarineanimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualLargeMammals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LargeMarineMammalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualSeaBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SeaBirdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesEqualShorelineBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineBirdsStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsPloversandSandpipers, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsBlackBackedGulls, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsHerringGulls, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsGreaterYellowlegs, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsSurfScoter, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsBrownPelican, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineBirdsOthers, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsCormorants, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsDucks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsGeese, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsBlackBlackGulls, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsLoons, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsSeaducks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SeaBirdsOther, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammaGreySeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalHoodedSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalBeardSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalStellarSeaLion, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalAtlanticWalrus, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LargeMarineMammalNorthernFurSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SmallMarineanimalHarpSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SmallMarineanimalHarbourSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SmallMarineanimalSeaOtter, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentLessThan5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentBetween6and10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentBetween26and100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan10000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineAnimalPresentGreaterThan20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarinePointSourceInputToMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FORCountNumberStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusNonPollutionSource, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskModerate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskHighP, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskHighConfirmedVisual, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RishHighConfirmedWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowupStart,
            });
        }
        #endregion Functions public 
    }
}
