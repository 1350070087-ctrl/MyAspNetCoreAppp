using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlightBookingCore.Data;
using FlightBookingCore.Models;

namespace FlightBookingCore.Controllers
{
    [Area("Admin")]
    public class ChuyenBayController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChuyenBayController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChuyenBay
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChuyenBays.ToListAsync());
        }

        // GET: Admin/ChuyenBay/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ChuyenBay/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChuyenBay,DiemDi,DiemDen,NgayGioKhoiHanh,GiaVe,SoGheTrong")] ChuyenBay chuyenBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuyenBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuyenBay);
        }

        // GET: Admin/ChuyenBay/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var chuyenBay = await _context.ChuyenBays.FindAsync(id);
            if (chuyenBay == null) return NotFound();
            return View(chuyenBay);
        }

        // POST: Admin/ChuyenBay/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChuyenBay,DiemDi,DiemDen,NgayGioKhoiHanh,GiaVe,SoGheTrong")] ChuyenBay chuyenBay)
        {
            if (id != chuyenBay.MaChuyenBay) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuyenBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenBayExists(chuyenBay.MaChuyenBay)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(chuyenBay);
        }

        private bool ChuyenBayExists(int id)
        {
            return _context.ChuyenBays.Any(e => e.MaChuyenBay == id);
        }
    }
}