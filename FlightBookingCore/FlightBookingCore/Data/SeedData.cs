using Microsoft.EntityFrameworkCore;
using FlightBookingCore.Models;
using FlightBookingCore.Data;

namespace FlightBookingCore.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            
            // Check if data already exists
            if (context.ChuyenBays.Any())
            {
                return; // DB has been seeded
            }

            var chuyenBays = new ChuyenBay[]
            {
                new ChuyenBay { DiemDi = "HAN", DiemDen = "SGN", NgayGioKhoiHanh = DateTime.Now.AddDays(1).AddHours(8), GiaVe = 1500000m, SoGheTrong = 120 },
                new ChuyenBay { DiemDi = "SGN", DiemDen = "HAN", NgayGioKhoiHanh = DateTime.Now.AddDays(1).AddHours(10), GiaVe = 1500000m, SoGheTrong = 100 },
                new ChuyenBay { DiemDi = "DAD", DiemDen = "SGN", NgayGioKhoiHanh = DateTime.Now.AddDays(2).AddHours(9), GiaVe = 1200000m, SoGheTrong = 150 },
                new ChuyenBay { DiemDi = "SGN", DiemDen = "DAD", NgayGioKhoiHanh = DateTime.Now.AddDays(2).AddHours(14), GiaVe = 1200000m, SoGheTrong = 140 },
                new ChuyenBay { DiemDi = "HAN", DiemDen = "DAD", NgayGioKhoiHanh = DateTime.Now.AddDays(3).AddHours(7), GiaVe = 1800000m, SoGheTrong = 80 }
            };

            context.ChuyenBays.AddRange(chuyenBays);
            context.SaveChanges();
        }
    }
}
