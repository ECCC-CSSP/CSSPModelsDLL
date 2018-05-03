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
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BCTidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthTideStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthTideStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthTideStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAreaWidthTideStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionSingleFishPlants, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceShellfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceFinfish, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FisheriesSourceLobster, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationBoatSingle, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationBargeSingle, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationPleasureCraft, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationBarges, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OilDumpingFacilityStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfTransportationRecreation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterAquacultureTypeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WatAquaCountNumberEqualTo20, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughWaterCourseStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeNA, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsent, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfo, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvert, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructurePipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridge, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBerm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructure, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureMed, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseDistStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureWaterCourse, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000W, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequiredW, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo9, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DiameterInCentimetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeCountNumberEqualTo10, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersEqual30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween31and50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween51and100cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween101and200cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween201and300cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween301and400cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersBetween401and500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterInCentimetersGreaterThan500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PipeFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DiameterNoInformation, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAlongRoad, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DrainageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DitchAcrossProperties, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainagePavedSurfaces, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageVegetatedSurfaces, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DrainageBareSoilSurfaces, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHi, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLo, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRain, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowWaterCourse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WaterCourseAreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallWaterCourse, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowlHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowRainfall, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowNA, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SecondaryHazardousLevelStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequired, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersApprox3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersApprox5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterwayWidthInMetersApprox10, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox2m1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox3m1, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox2m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox3m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox50cm3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox1m3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox2m3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox3m3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox50cm5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox1m5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox2m5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox3m5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox50cm10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox1m10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox2m10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StreamVolSqMeterStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AverageDepthApprox3m10, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals6m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals9m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals15m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StreamVolSqMeterEquals30m2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TimeToFloat10mStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesHalf, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesOne, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesThree, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsSix, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteSix, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesSix, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesSix, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsNine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteNine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesNine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesNine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsFifteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteFifteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesFifteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesFifteen, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat30SecondsThirty, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat1MinuteThirty, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat2MinutesThirty, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TimeToFloat3MinutesThirty, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500a, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000a, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700a, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500b, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000b, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700b, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500c, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000c, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700c, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500d, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000d, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700d, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500e, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000e, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700e, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500f, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000f, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700f, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500g, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000g, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700g, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500h, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000h, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700h, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500i, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000i, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700i, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500j, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000j, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700j, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo500k, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1000k, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FecalCountNumberApproxTo1700k, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Start,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Starta, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startb, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startc, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14Startd, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarteGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartfGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartgGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarthGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartiGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartjGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartkGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartlGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartmGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartnGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartoGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartpGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartqGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartrGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartsGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StarttGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartuGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartvGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartwGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartxGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartyGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.CubicMeterToDiluteToMPN14StartzGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RegionStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter30cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter50cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter75cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter2m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureDiameter3m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HeigthOfFlowStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent300cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent300cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent300cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent500cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent750cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent750cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent750cm, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent1m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent2m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent2m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent2m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox25Percent3m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox50Percent3m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HeigthOfFlowApprox75Percent3m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.VolumeCubicMeterSecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual005, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual01, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual02, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual03, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual05, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual075, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual11, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual28, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual33, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual52, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual89, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.VolumeCubicMeterSecEqual152, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FecalCountNumberStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween14And100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween101And250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween251And600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween601and1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween1001And2000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween2001And5500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween5501And11000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewBrunswickBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNBStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNovaScotiaBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNSStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionPEIBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInPEIStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionNewfoundlandBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInNfldStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionQuebecBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInQuebecStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RegionBritishCBetween11001And20000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SectorsInBCStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB1To2GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB3To4GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB5To7GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB9To12GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB13To15GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals16GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNB17To18GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNBEquals19GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals1GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS2To3GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS4To6GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals7GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNS8To14GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNEquals15GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals16GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals18GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNSEquals20GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NSTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI1To4Plus9GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI5To6GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInPEI7To8GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PEITidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual2GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfld6To7G8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual15G8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual29G8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual30GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual35GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInNfldEqual43GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualAGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualGGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecTandPandNGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecLandKandSandPGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualBGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ01GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ02GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ03GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInQuebecEqualZ04GP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.QuebecTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox50cmGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox1mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox2mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox5mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.QuebecTidalAmplitudeApprox8mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBEGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualGBWGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualNCQCGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SectorsInBCEqualWCVIGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BCTidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.BCTidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox4mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox1mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldTidalAmplitudeApprox2mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt15m2Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt30m2Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt30m5Wide60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt60m5Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt60m5Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt60m10Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide40a, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide70, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt15m2Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt30m05Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt30m05Wide120, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt60m05Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt60m05Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAverageDepthAt100m10Wide80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NfldAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals5m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals10m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals15m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals20m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals30m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals40m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals60m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals70m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals80m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NfldAreaWidthEquals120m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox50cmGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox1mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PEITidalAmplitudeApprox2mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt100m105Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt150m205Wide90, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt150m205Wide150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt500m1Wide65, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt1500m4Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAverageDepthAt1500m4Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PrinceEAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals5m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals10m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals15m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals20m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals30m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals40m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals65m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals90m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals100m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PrinceEAreaWidthEquals150m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox50cmGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox1mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox2mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox5mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox6mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBTidalAmplitudeApprox7mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NewBAverageDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide60, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt60m05Wide200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt100m2Wide80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m05Wide200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide110, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m2Wide200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt150m5Wide80, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m05Wide150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m05Wide250, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m205Wide25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m205Wide45, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m6Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m20Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NewBAverageDepthAt500m30Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NBAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals5m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals10m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals15m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals20m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals25m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals30m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals40m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals45m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals50m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals60m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals70m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals75m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals80m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals100m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals110m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals150m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals200m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NBAreaWidthEquals250m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP1, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP2, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP3, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP4, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP6, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP7, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox50cmGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox1mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox2mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox3mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox5mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox8mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSTidalAmplitudeApprox14mGP8, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAverageDepthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt30m1Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt30m1Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt60m1Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt100m1Wide150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide110, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m1Wide400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m2Wide50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m2Wide100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m3Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m5Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt150m5Wide70, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide15, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m2Wide65, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m3Wide35, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt500m10Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m1Wide40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m2Wide10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NovaSAverageDepthAt1500m2Wide20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.NovaSAreaWidthTideStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals5m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals10m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals15m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals20m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals25m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals30m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals35m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals40m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals50m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals60m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals70m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals100m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals110m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals150m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals200m, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.NSAreaWidthEquals400m, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.BoatStart,
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
