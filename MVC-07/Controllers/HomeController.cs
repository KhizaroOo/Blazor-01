using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_07.AppData;
using MVC_07.Models;

namespace MVC_07.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        #region Arts

        List<Art> MyAllArts = new MyArts().GetMyArts(24);

        #endregion

        #region InfoGraphics

        List<Infographic> MyAllInfographics = new MyInfographics().GetMyInfographics(12);

        #endregion

        #region Writings

        List<Writing> MyAllWritings = new MyWritings().GetMyWritings(12);

        #endregion

        #region ToolBoxes

        List<ToolBox> MyAllToolBoxes = new MyToolBoxes().GetMyToolBoxes(12);

        #endregion

        ViewBag.MyAllArts = MyAllArts;
        ViewBag.MyAllInfographics = MyAllInfographics;
        ViewBag.MyAllWritings = MyAllWritings;
        ViewBag.MyAllToolBoxes = MyAllToolBoxes;

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

