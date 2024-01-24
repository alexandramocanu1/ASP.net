using Microsoft.AspNetCore.Mvc;
using Planner.Models;
using System.Collections.Generic;
using System.Linq;

namespace Planner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, UserName = "user1", IsAdmin = false },
            new User { Id = 2, UserName = "user2", IsAdmin = false },
            // Alte utilizatori
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(Users);
        }

        // Alte acțiuni pentru utilizatori, de exemplu, adăugare, ștergere, actualizare
    }
}
