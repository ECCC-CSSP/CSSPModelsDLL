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
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialEffluentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturalSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgriculturalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureManagementStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManureManagementStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FisheriesSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SlipwayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselCountStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.MarWhfCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarWhfCountNumberStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundFacilitiesStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.UrbanStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSizeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfAnimalStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgSingleTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgSingleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalNumberPresentStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WastewaterDumpingStationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WastewaterDumpingStationStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazReasonStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayRouteFirstStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparionZoneStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughWaterCourseStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseDistStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConductDilutionAnalysesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SuggestedRiskStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskConfirmationStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskConfirmationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FollowUpStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowUpStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypeOfSourceStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterwayWidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat10mStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StructureDiameterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3DayStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCountStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadinPerDayStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEIStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWaterStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactZoneStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceHumanLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceHumanMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceAnimal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceEffluentLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialEffluentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceEffluentMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialEffluentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleResidential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleCottage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleTrailer, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleBarn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSinglePublicBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleSchool, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleChurch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleMedicalFacility, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleOuthouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSinglehotelMotel, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleBoatM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleBargeM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSinglehotelMotelM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleResidentialM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleCottageM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleWarehouseM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleCommericalM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleFishPlant, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleBeachPatio, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleResidences, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleCottages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleTrailers, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleWarehouses, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleCommericals, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleBarns, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultiplePublicBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleSchools, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleChurches, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleMedicalFacilities, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleOuthouses, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OuthouseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleHotelsMotels, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleBoatsM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleBargesM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleHotelsMotelsM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleResidencesM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleCottagesM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleWarehousesM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleCommericalsM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleFishPlants, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionMultipleBeachPatios, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween21and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween41and60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween61and100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween101and200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween201and400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo1M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo2M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo3M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo4M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo5M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo6M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo7M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo8M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo9M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberEqualTo10M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and20M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween21and40M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween41and60M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween61and100M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween101and200M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween201and400M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan400M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationRural, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationUrban, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationForested, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationAgricultural, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationShorelineMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationWharfMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationIsland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationRecreationalArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationSeasonalCottageLot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationFishPlant, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationAquacultureSiteMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationAnchorageMooringSiteMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationDisposalAtSeaMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationMarineParkMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationMarinaMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationFloatHomeCommunityMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationMarinaLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationShorelineLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationWharfLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersEquals100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween251And500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersBetween501And1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialAreaSizeMetersInFoRequired, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseConcreteTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseOnGround, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OuthouseOnPortable, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentForestry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentAgricultureFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AgriculturalSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentFisheryLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FISCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentShorelineStructures, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentIndustrialTreatment, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentStorageTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TankSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentAirport, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentLandfill, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LandfillTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentUrbanRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.UrbanStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentRecreation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentAquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentAnchorageMooringSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentDisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentMarina, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentRural, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturalSourceCrop, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureSourcePasture, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PastureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturesourceFeedlot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FeedlotStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AriculturalSourcePeatMoss, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgricultureSourceManure, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ManureManagementStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturalSourceBarn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AgriculturalSoureRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureManagementPileSpread, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureManagementLiqSpread, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ManureManagementBoth, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FieldLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationOnFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationOffFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FieldLocationBoth, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PastureFallow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FeedlotNotActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceShellfishProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceFinfishProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceBaitFishProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceLobsterProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceLobsterAndBaitfishProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceShellfishLive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceFinfishLive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceLobsterLive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationProcessing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FisheriesSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationHoldingTanks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FisheriesSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationPackaging, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FisheriesSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationRearing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FisheriesSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishOperationFishMeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleProcessingPlant, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleHatchery, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSinglePond, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSinglePound, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleAbandoned, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeSingleWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleProcessingPlants, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleHatcheries, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultiplePonds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleTanks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultiplePounds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishOperationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleAbandoned, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FishBuildingTypeMultipleWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberBetween10and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberBetween25and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FISCountNumberGreaterThan40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FishBuildingTypeMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceWharf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarWhfCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceSeaWall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceBoatRamp, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SlipwayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceBoatHouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayPaved, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SlipwayRocks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfCommercialTransportation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfFishing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfRecreational, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VesselCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfAbandoned, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.VesselCountNotApplicable, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WharfTransportationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationCommericalSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationFerrySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationFishingBoatSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationBargeSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationRecreationActivitySingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationPleasureBoatSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationCommerical, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationFerry, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationFishingBoats, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationBarges, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationRecreationActivities, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationPleasureBoats, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCampground, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RECCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationDayUseArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationSwimmingArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationGolfCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationFishing, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationCampgroundSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationDayUseAreaSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationSwimmingAreaSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RecreationGolfCourseSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RECCountNumber500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CampgroundFacilitiesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundNoDumpStn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundWithDumpStn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundNoDumpStnSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CampgroundWithDumpStnSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanAccumulatedFlow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanWastewaterDumpStation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize4000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TankSize8000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeResidental, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeIndustrial, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LandfillTypeWoodwaste, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.IndustrialAreaSizeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfAnimalLivestock, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfLivestockStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfAnimalWildlife, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfWildlifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfAnimalMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockHorses, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockCows, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockSheep, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockPigs, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockMixtureLarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockChickens, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockTurkeys, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockDucks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockMixtureSmall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockFurFarms, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfLivestockDogs, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RecreationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeCrows, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeGulls, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeEagle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeUngulate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeCoyote, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeGeneral, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeBeaver, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildlifeMuskrat, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypesOfWildLifeDucksGeese, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationRuralDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationUrbanDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationForestedDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationAgriculturalDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationFarmDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationShorelineDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWharfDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationBargeDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationIslandDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationRecreationalAreaDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationCottageLotDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWetlandDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWaterCourseDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationFishPlant, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationRural, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationUrban, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationForested, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationAgricultural, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationFarm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWharf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationIsland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationRecreationalArea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationCottageLot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationPondLakeDom, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationPondLake, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgSingleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalBldgMultipleTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgEqualsNotApplicable, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgSingleCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgSingleBarn, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgSingleBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleBarns, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleOtherBuildings, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentapprox5000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan10000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NumberAnimalPresentUnknown, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypesOfAnimalStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeSingleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountEquals10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween11to25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween26to50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween51to75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountBetween76to100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BoatCountGreaterThan250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityPresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WastewaterDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WastewaterDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityNotObserved, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WastewaterDumpingStationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OilDumpingFacilityNotApplicable, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WastewaterDumpingStationPresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WastewaterDumpingStationAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WastewaterDumpingStationNotObserved, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureSiteActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatAquaCountNumberStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo70, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo90, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberGreaterThan100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleCage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleFloatingBag, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleSubmergedLine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleLosterPound, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleBoat, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeFloatingBags, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSubmergedLines, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToShoreStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeLosterPounds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeBarges, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeBoats, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationWharf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationBarge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationIsland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationSandBar, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationRockOutcrop, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationAquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationOffShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineLocationMudflat, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeShorelineBirds, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeGulls, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeCormorants, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeDucksGeese, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeLoons, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeaducks, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeOther, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterTypesOfMarineLifeSeaOtter, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineLocationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminantRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminantExcrement, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminantEffluent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminantEffluentMultiple, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MarineSourcesOfContaminanMixedMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantRunoffFromField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantProcessingWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantTankWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantSewage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantEffluent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantDomesticExcrement, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantMarineWashrooms, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantLandMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantSpills, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantWilldExcrement, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantEffluentMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantEffluentLocation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRunoffLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageThruConduit, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageSepticSystemLeachateField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRetentionTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOpenTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageSystemConstructedWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOnSiteSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOffSiteSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticNoInformation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageAnimalWasteStorage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageAnimalExcrement, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRunoffMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageThruConduitMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRetentionTankMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageMixedMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazReasonStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazReasonStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelHighMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazReasonStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelMedMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ObservationHazReasonStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazardousLevelLowMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonVisualH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonNumbersH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonDiscussH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonRainfallH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonVisualM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonNumbersM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonDiscussM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonRainfallM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonVisualHMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonNumbersHMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonDiscussHMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonRainfallHMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonVisualMMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonNumbersMMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonDiscussMMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonRainfallMMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonHistoricDataH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonHIstoricDataM, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonHistoricDataHMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ObservationHazReasonHistoricDataMMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayLandHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayLandMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayLandLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayMarineHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayMarineMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayMarineLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayInActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayNotDetermined, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstStream, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDirectFlow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstCulvertMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPipeMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstStreamMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDitchMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDirectFlowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstCulvertLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPipeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstStreamLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDitchLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstSubSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDirectFlowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstInActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstNotDetermined, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstMunicipalityONSITE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstDirectMARINE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPipeMARINE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstLandDisposalMARINE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstMunicipalityOFFSITE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstMixesMARINE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPondLake, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPondLakeMED, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceFirstPondLakeLOW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondCulvertStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeStream, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeStreamMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDitchMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeStreamLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDitchLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeSubSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondPipeDirectflowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertStream, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitch, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertStreamMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitchMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainageMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertStreamLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDitchLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DitchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertSubSurfaceDrainageLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceSecondCulvertDirectFlowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox1Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox2Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox3Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox4Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox5Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox6Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox7Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox8Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox9Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox10Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween11And25Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween26And40Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersGreaterThan40Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox1Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox2Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox3Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox4Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox5Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox6Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox7Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox8Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox9Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersApprox10Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween11And25Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersBetween26And40Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WidthInMetersGreaterThan40Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeNA, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeLowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeMediumMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeHighMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeNAMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeLowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeMediumLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeHighLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeNALow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeLowHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeMediumHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeHighHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeNAHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeLowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeMediumMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeHighMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeNAMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeLowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeMediumLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeHighLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeNALow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresentHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresentMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresentLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianGrassedZonePresentHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianGrassedZonePresentMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianGrassedZonePresentLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructurePipeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughNoStructureHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructurePipeMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughNoStructureMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructurePipeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughNoStructureLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughSaltwaterMarshHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughSaltwaterMarshMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughSaltwaterMarshLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughBeaverDamHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughBeaverDamMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughBeaverDamLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureSaltMarshWatercourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureSaltMarshWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureSaltMarshWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBeaverDamWatercourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBeaverDamWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBeaverDamWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000HighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequiredHighW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000MedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqMedW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000LowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqLowW, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo1High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo2High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo3High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo4High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo5High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo6High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo7High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo8High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo9High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo10High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo1Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo2Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo3Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo4Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo5Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo6Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo7Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo8Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo9Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo10Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo1Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo2Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo3Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo4Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo5Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo6Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo7Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo8Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo9Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo10Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumbeNoInformation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual15High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual30High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cmHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterNoInformationHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual15Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual30Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cmMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterNoInformationMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual15Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual30Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cmLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterNoInformationLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAlongRoadHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAcrossPropertiesHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAlongRoadMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAcrossPropertiesMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAlongRoadLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAcrossPropertiesLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainagePavedSurfacesHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageVegetatedSurfacesHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageBareSoilSurfacesHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainagePavedSurfacesMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageVegetatedSurfacesMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageBareSoilSurfacesMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainagePavedSurfacesLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageVegetatedSurfacesLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageBareSoilSurfacesLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHiHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMedHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLoHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallWaterCourseHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallWaterCourseMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallWaterCourseLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowlHighHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowMediumHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowLowHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowRainfallHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowNAHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowlHighMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowMediumMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowLowMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowRainfallMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowNAMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowlHighLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowMediumLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowLowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowRainfallLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowNALow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000High, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequiredHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Med, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Low, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelHighIndirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelMedIndirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelLowIndirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelHighDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelMedDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SecondaryHazardousLevelLowDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingDirectHighHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConductDilutionAnalysesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingindirectHighHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConductDilutionAnalysesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingDirectMedHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConductDilutionAnalysesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingindirectMedHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConductDilutionAnalysesStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingDirectLowHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingindirectLowHaz, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingNone, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefiniteHi, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotentialHi, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefiniteMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotentialMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefiniteLo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotentialLo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusNonPollutionSource, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusNotDetermined, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesDirectHighYes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesDirectHighNo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectHighYes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectHighNo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesDirectMedYes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesDirectMedNo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectMedYes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TypeOfSourceStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ConductDilutionAnalysesIndirectMedNo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SuggestedRiskLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SuggestedRiskModerate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SuggestedRiskHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SuggestedRiskInfoRequired, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskConfirmationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskModerate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskConfirmationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskConfirmationStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskNotDetermined, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowUpStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskConfirmationNotConfirmed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowUpStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskConfirmationConfirmedVisual, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowUpStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskConfirmationConfirmedWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FollowUpStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypeOfSourceCircular, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StructureDiameterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TypeOfSourceWaterWays, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterwayWidthInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersApprox1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersApprox2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox50cm1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox1m1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox50cm2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox1m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals05m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals1m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals3m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DischargeM3DayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DischargeM3Day6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SampleFecalCountStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For4320, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For4320, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For8640, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For8640, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For17280, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For17280, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For25920, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For25920, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For43200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For43200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCount500For64800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SampleFecalCoun1000For64800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.LoadinPerDayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayA, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayB, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayC, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayD, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayF, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayG, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.LoadPerDayH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DilutionVolumeToTarget14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeA, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeB, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeC, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeD, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeE, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeF, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeG, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DilutionVolumeH, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotia2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEI2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiak3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIk3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandk3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebeck3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCk3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotia6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEI6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiak39E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIk9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandk9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebeck9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCk9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotia1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEI1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiak2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIk2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotia3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEI3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswick5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotia5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEI5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundland5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebec5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishC5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1V5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DepthOfWaterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV2E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV3E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV6E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV9E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV1E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV2E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV3E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater1mV5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater2mV5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater5mV5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater8mV5E6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthOfWater14mV5E5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SurfaceAreaImpactRadiusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E5one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E5Two3E5Two, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E5eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E5fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E5one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E5five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E5eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E5fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E5five6E5one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius6E5two, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius6E5five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius6E5eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius6E59E5fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius9E5one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius9E5two, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius9E5five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius9E5eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius1E6one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius1E6two, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius1E6five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E6Eight2E6Eight3E6eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius1E6fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E6one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E6two, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E6Five3E6Five5E6five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius2E6fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E6Two5E6Two2E5five, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E6one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius3E65E6fourteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius5E6one, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SurfaceAreaImpactRadius5E6eight, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactZoneYes, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactZonePotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactZoneNo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactZoneNotSure, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters0W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters5W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters10W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters20W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters30W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters40W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters50W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters75W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters100W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters150W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters200W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters300W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters400W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters600W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters800W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters1000W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters5WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters10WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters20WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters30WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters40WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters50WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters75WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters100WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters150WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters200WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters300WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters400WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters600WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters800WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters1000WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000WAnchor, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters5WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters10WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters20WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters30WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters40WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters50WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters75WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters100WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters150WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters200WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters300WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters400WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters600WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters800WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMeters1000WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToShoreInMetersGreaterThan1000WDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
        }
        #endregion Functions public 
    }
}
