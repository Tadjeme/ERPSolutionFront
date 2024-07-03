using ERPSolutionFront.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ERPSolutionFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly ClientERPCmdtApi _clientERPCmdtApi;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //var result = _clientERPCmdtApi.CampagneGETAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
