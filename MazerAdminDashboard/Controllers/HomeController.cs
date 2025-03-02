using System.Diagnostics;
using MazerAdminDashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace MazerAdminDashboard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult LayoutDefault()
    {
        return View();
    }

    public IActionResult LayoutHorizontal()
    {
        return View();
    }

    public IActionResult LayoutVertical1Column()
    {
        return View();
    }

    public IActionResult LayoutVerticalNavbar()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
