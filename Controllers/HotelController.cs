using Microsoft.AspNetCore.Mvc;
using TripManagmentSystem.Data;
using TripManagmentSystem.Models;

namespace TripManagmentSystem.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Admin: Списък на всички хотели
        public IActionResult Index()
        {
            var hotels = _context.Hotels.ToList();
            return View(hotels);
        }

        // Admin: Добавяне на нов хотел
        public IActionResult AddHotel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHotel(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _context.Hotels.Add(hotel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // Admin: Редактиране на хотел
        public IActionResult EditHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);
            return View(hotel);
        }

        [HttpPost]
        public IActionResult EditHotel(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _context.Hotels.Update(hotel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // Admin: Изтриване на хотел
        public IActionResult DeleteHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }

}
