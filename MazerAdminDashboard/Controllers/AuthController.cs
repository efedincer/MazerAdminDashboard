using Microsoft.AspNetCore.Mvc;

namespace MazerAdminDashboard.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
