using Microsoft.AspNetCore.Mvc;
using MultipleModelandMultipleChartsInOneView.Models;

namespace MultipleModelandMultipleChartsInOneView.Controllers
{
    public class Temperature2Controller : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var ambentTempResponse = await client.GetAsync("http://192.168.68.35:8082/api/AmbentTemperature");
                if (!ambentTempResponse.IsSuccessStatusCode)
                {
                    // Handle the error here
                    return View("Error");
                }
                var ambentTempData = await ambentTempResponse.Content.ReadAsAsync<List<AmbentTemperature>>();

                var moduleTempResponse = await client.GetAsync("http://192.168.68.35:8082/api/ModuleTemperature");
                if (!moduleTempResponse.IsSuccessStatusCode)
                {
                    // Handle the error here
                    return View("Error");
                }
                var moduleTempData = await moduleTempResponse.Content.ReadAsAsync<List<ModuleTemperature>>();

                var viewModel = new TemperatureModels2
                {
                    Time = ambentTempData.Select(x => x.Time).ToList(),
                    AmbentTemperature1 = ambentTempData.Select(x => x.AmbentTemperature1).ToList(),
                    ModuleTemperature1 = moduleTempData.Select(x => x.ModuleTemperature1).ToList()
                };

                return View(viewModel);
            }
        }



    }
}
