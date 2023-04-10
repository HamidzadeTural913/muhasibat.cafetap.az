using CafeTap.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Controllers
{
    public class HomeController : MyController
    {
        [HttpGet]
        [Route("Home")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
