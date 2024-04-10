using Microsoft.AspNetCore.Mvc;

namespace BlazorEnabledModule.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
