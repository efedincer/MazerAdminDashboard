using Microsoft.AspNetCore.Mvc;

namespace MazerAdminDashboard.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
