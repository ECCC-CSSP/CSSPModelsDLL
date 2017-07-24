using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class VPScenarioModel : LastUpdateAndContactModel
    {
        public VPScenarioModel()
        {
        }
        public int VPScenarioID { get; set; }
        public string VPScenarioName { get; set; }
        public int InfrastructureTVItemID { get; set; }
        public string InfrastructureTVText { get; set; }
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        public Nullable<bool> UseAsBestEstimate { get; set; }
        public double EffluentFlow_m3_s { get; set; }
        public int EffluentConcentration_MPN_100ml { get; set; }
        public double FroudeNumber { get; set; }
        public double PortDiameter_m { get; set; }
        public double PortDepth_m { get; set; }
        public double PortElevation_m { get; set; }
        public double VerticalAngle_deg { get; set; }
        public double HorizontalAngle_deg { get; set; }
        public int NumberOfPorts { get; set; }
        public double PortSpacing_m { get; set; }
        public double AcuteMixZone_m { get; set; }
        public double ChronicMixZone_m { get; set; }
        public double EffluentSalinity_PSU { get; set; }
        public double EffluentTemperature_C { get; set; }
        public double EffluentVelocity_m_s { get; set; }
        //public string RawResults { get; set; }
    }
}
