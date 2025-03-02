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

    public IActionResult Index() => View();

    public IActionResult LayoutDefault() => View(); //done

    public IActionResult LayoutHorizontal() => View(); //done

    public IActionResult LayoutVertical1Column() => View(); //undone

    public IActionResult LayoutVerticalNavbar() => View(); //done

    public IActionResult EmailApplication() => View();

    public IActionResult AuthForgotPassword() => View();

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
