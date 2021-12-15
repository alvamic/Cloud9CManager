using Microsoft.AspNetCore.Mvc;

namespace C9_CostManager.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
