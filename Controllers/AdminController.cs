using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planner.Models;
using System.Collections.Generic;
using System.Linq;

namespace Planner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class AdminController : Controller
    {
        public static List<User> Admins = new List<User>
        {

            new User { Id = new Guid("f1dae65d-9dd7-44e7-baf1-fd1c52270b95"), UserName = "admin1", IsAdmin = true }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(Admins);
        }

    }
}
