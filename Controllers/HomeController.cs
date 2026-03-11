using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FlowerShopNET.Models;

namespace FlowerShopNET.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Us";
        ViewData["Description"] = "We are a passionate flower shop dedicated to bringing beauty and joy through fresh flowers.";
        ViewData["Founded"] = "Founded in 2010, we have served over 10,000 happy customers.";
        ViewData["Mission"] = "Our mission is to deliver the freshest flowers with love and care.";
        return View();
    }

    public IActionResult Shop()
    {
        ViewData["Title"] = "Shop";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
