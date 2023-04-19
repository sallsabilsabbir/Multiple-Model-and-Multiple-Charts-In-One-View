namespace MultipleModelandMultipleChartsInOneView.Models
{
    public class TemperatureModels
    {
        public List<DateTime?> Time { get; set; }
        public List<float?> AmbentTemperature1 { get; set; }
        public List<float?> ModuleTemperature1 { get; set; }
    }
}
