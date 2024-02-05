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
    public class TripController : Controller
    {
        public static List<TripModel> TripModels = new List<TripModel>
        {
            new TripModel { Id = 1, UserId = 1, TravelDate = DateTime.Now, TravelDuration = 3, Accommodation = "AirnBnB", LikedAccommodation = false},
        };

        public IActionResult Index()
        {
            return View(TripModels);
        }

        [HttpPost]
        public IActionResult Add(TripModel newTrip)
        {
            TripModels.Add(newTrip);

            return RedirectToAction("Index", "Trip");
        }

    }
}
