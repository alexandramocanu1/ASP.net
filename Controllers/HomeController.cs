using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planner.Data;
using Planner.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Accomodations()
        {
            return View();
        }

        public IActionResult Flights()
        {
            return View();
        }


        public async Task<IActionResult> MyTrips()
        {
            var trips = await _context.Trips.ToListAsync();

            return View(trips);
        }

        [HttpGet]
        public IActionResult AddTrip()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTrip(TripModel newTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Trips.Add(newTrip);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(MyTrips));
            }

            return View(newTrip);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
