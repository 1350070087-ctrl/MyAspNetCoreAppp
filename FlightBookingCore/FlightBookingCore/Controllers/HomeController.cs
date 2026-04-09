using Microsoft.AspNetCore.Mvc;
using FlightBookingCore.Data;
using FlightBookingCore.Models;
using System.Linq;

namespace FlightBookingCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string diemDi, string diemDen, DateTime ngayDi)
        {
            // Xử lý dữ liệu nhập (tránh null + chuẩn hóa)
            diemDi = diemDi?.Trim().ToLower() ?? "";
            diemDen = diemDen?.Trim().ToLower() ?? "";

            var results = _context.ChuyenBays
                .Where(c =>
                    c.DiemDi.ToLower().Contains(diemDi) &&
                    c.DiemDen.ToLower().Contains(diemDen) &&
                    c.NgayGioKhoiHanh.Date >= ngayDi.Date
                )
                .ToList();

            return View("SearchResults", results);
        }
    }
}