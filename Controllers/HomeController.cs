using Planner.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Trip");
    }
}
