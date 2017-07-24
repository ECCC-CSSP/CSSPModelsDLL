using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class VPAmbientModel : LastUpdateAndContactModel
    {
        public VPAmbientModel()
        {
        }
        public int VPAmbientID { get; set; }
        public int VPScenarioID { get; set; }
        public int Row { get; set; }
        public double MeasurementDepth_m { get; set; }
        public double CurrentSpeed_m_s { get; set; }
        public double CurrentDirection_deg { get; set; }
        public double AmbientSalinity_PSU { get; set; }
        public double AmbientTemperature_C { get; set; }
        public int BackgroundConcentration_MPN_100ml { get; set; }
        public double PollutantDecayRate_per_day { get; set; }
        public double FarFieldCurrentSpeed_m_s { get; set; }
        public double FarFieldCurrentDirection_deg { get; set; }
        public double FarFieldDiffusionCoefficient { get; set; }
    }
}
