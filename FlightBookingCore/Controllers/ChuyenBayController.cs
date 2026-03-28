using Microsoft.AspNetCore.Mvc;
using FlightBookingCore.Data;
using System.Linq;

namespace FlightBookingCore.Controllers
{
    public class ChuyenBayController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChuyenBayController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ds = _context.ChuyenBays.ToList();
            return View(ds);
        }
    }
}