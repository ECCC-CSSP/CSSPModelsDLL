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
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayRouteMarineStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteMarineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.MunicipalityDataStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MunicipalityDataStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskAnalysesWaterDepthStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskAnalysesWaterDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalAmplitudeStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FetchStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalLargeDeepDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLargeDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLargeDeepDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLargeDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalSmallDeepDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallDeepDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalLgShallowDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLgShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShallowDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLgShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalSmallShallowDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallShallowDefinStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallShallowDefinStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ConfirmationOfHighStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalLargeDeepPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLargeDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLargeDeepPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLargeDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalSmallDeepPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallDeepPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalLgShallowPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLgShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShallowPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLgShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclosedTidalSmallShallowPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallShallowPotentialStart, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallShallowPotentialStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.SourceEffluentWater, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and25, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween26and40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan40, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween11and25M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberBetween26and40M, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.HumanPollutionMultipleStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanPollutionCountNumberGreaterThan40M, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationShoreline, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationWharf, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationAquacultureSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationAnchorageMooringSite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationDisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationMarinePark, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationMarina, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.HumanLocationFloatHomeCommunity, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentDisposalAtSea, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.IndustrialEffluentMarinePark, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SourcesOfContaminantStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineSourceSlipway, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WharfPrivate, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.UrbanStormWater, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalLocationFishPlant, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgSingleWarehouse, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleWarehouse, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AnimalNumberPresentStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AnimalBldgMultipleBarn, 
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.WatAquaCountNumberStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleFloatingBags, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleSubmergedLines, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleLosterPound, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSingleBarges, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeCages, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SewageStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeFloatingBags, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MarineSourcesOfContaminantStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterAquacultureTypeSubmergedLines, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.SourcesOfContaminantAnimalExcrement, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRunoff, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageThruConduit, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageSepticSystemLeachateField, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageRetentionTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOpenTank, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageSystemConstructedWetland, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOnSiteSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MunicipalityDataStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageOffSiteSystem, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.MunicipalityDataStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SepticNoInformation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageAnimalWasteStorage, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.SewageAnimalExcrement, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathWayStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwayLand, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteFirstStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayMarine, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteMarineStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathWayInActive, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeLowVegetated, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeMediumVegetated, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeHighVegetated, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.AreaSlopeNAVegetated, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ShorelineRiparionZoneStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeMedium, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeHigh, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.WaterCourseAreaSlopeNA, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZonePresentVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneAbsentVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FlowThroughStructureStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShorelineRiparianZoneNoInfoVeg, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureCulvertVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructurePipeVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBridgeVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureBermVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowThroughStructureWetlandVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StructureInRoadNoStructureVeg, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.DistanceToWaterInMetersStart,
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
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelHighVegetate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelMediumVegetate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelLowVegetate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.AreaSlopeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.FlowLevelRainfallVegetate, 
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
                PolSourceObsInfo = PolSourceObsInfoEnum.PipeFlowNA, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.PathwayRouteSecondPipeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersGreaterThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetersInfoRequired, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters0Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters5Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters10Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters20Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters30Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters40Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters50Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters75Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters100Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters150Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters200Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters300Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters400Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters600Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters800Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMeters1000Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetGrThan1000Vegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DistanceToWaterInMetInfoReqVegetation, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceMarineDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceMarinePipe, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.PathwaySourceMarineLandDisposal, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ImpactRatingStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingDirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingindirect, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ImpactRatingNone, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.StatusStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskAnalysesWaterDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskAnalysesWaterDepthStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.StatusNonPollutionSource, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.RiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.TidalAmplitudeStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.DepthUnknown, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalLargeDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalSmallDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalLargeShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalSmallShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalLargeDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalSmallDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalLargeShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalSmallShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.FetchStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.TidalUnknown, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalLargeDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLargeDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLargeDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLargeDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalSmallDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallDeepDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallDeepDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalLgShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLgShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLgShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalSmallShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallShallowDefinite, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallShallowDefinStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteresTidalLargeDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLargeDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLargeDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLargeDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalSmallDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallDeepPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallDeepPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalLgShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalLgShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalLgShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelteredTidalSmallShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.EnclosedTidalSmallShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalSmallShallowPotential, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.OpenTidalSmallShallowPotentialStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.ShelterUnknown, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetnfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetGreTh1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet50, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet100, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet200, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet300, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet400, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet500, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet600, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet700, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet800, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet900, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetGrTh1000, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetInfoReq, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
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
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskLow, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskModerate, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskHighNotConfirmed, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RiskHighConfirmedVisual, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.RishHighConfirmedWater, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.ConfirmationOfHighStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMeters1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncTidalLarDeDistToGrowAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDisToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLarDeDistToGrowAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrowAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EncloTidalSmDeDistToGrAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrowAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidSmDeDistToGrAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalLgShalDistToGrAreaInMetnfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrowAreaInMetGrThan1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpenTidalLgShalSeaDistToGrAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetGreTh1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.EnclTidalSmShalSeaDistToGrAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet50Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet100Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet200Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet300Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet400Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet500Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet600Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet700Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet800Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet900Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrowAreaInMet1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetGrTh1000Pot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
            polSourceObsInfoChildList.Add(new PolSourceObsInfoChild()
            {
                PolSourceObsInfo = PolSourceObsInfoEnum.OpTidalSmShalDistToGrAreaInMetInfoReqPot, 
                PolSourceObsInfoChildStart = PolSourceObsInfoEnum.SuggestedRiskStart,
            });
        }
        #endregion Functions public 
    }
}
