using System;
using System.Collections.Generic;

namespace MultipleModelandMultipleChartsInOneView.Models
{
    public partial class YesterdaysDatum
    {
        public DateTime? Time { get; set; }
        public float? Energy { get; set; }
        public float? Pr { get; set; }
        public float? AcMaxPower { get; set; }
        public float? DcMaxPower { get; set; }
        public float? SpecificEnergy { get; set; }
    }
}
