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
    public class UserController : Controller
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = new Guid("d426edc3-e854-4418-89ff-0a04a229f4ea"), UserName = "user1", IsAdmin = false },
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(Users);
        }

    }
}
