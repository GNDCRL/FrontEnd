using Microsoft.AspNetCore.Mvc;

namespace PeerLandingFE.Controllers.api
{
    public class ApiBorrowerUserContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
