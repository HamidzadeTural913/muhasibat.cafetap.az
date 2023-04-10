using CafeTap.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class DashboardController : MyController
    {

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("/test")]
        public IActionResult Test()
        {
            return View();
        }


        [HttpGet]

        public IActionResult AccessDenied() => View();
    }
}
