using Microsoft.AspNetCore.Mvc;

namespace PeerLandingFE.Controllers
{
    public class BorrowerUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
