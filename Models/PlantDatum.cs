using System;
using System.Collections.Generic;

namespace MultipleModelandMultipleChartsInOneView.Models
{
    public partial class PlantDatum
    {
        public DateTime? Time { get; set; }
        public float? PlantNetGeneration { get; set; }
        public float? Import { get; set; }
        public float? Export { get; set; }
        public float? TodayNetGeneration { get; set; }
        public float? TodayImport { get; set; }
        public float? TodayExport { get; set; }
    }
}
