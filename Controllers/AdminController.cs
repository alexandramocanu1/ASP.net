using Microsoft.AspNetCore.Mvc;
using Planner.Models;
using System.Collections.Generic;
using System.Linq;

namespace Planner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        public static List<User> Admins = new List<User>
        {
            new User { Id = 1, UserName = "admin1", IsAdmin = true },
            new User { Id = 2, UserName = "admin2", IsAdmin = true },
            // Alți administratori
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(Admins);
        }

        // Alte acțiuni pentru administratori, de exemplu, adăugare, ștergere, actualizare
    }
}
