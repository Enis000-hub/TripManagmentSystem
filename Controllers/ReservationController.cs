using Microsoft.AspNetCore.Mvc;
using TripManagmentSystem.Data;
using TripManagmentSystem.Models;

namespace TripManagmentSystem.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Потребител: Резервиране на хотел
        public IActionResult BookHotel(int hotelId)
        {
            var hotel = _context.Hotels.Find(hotelId);
            return View(hotel);
        }

        [HttpPost]
        public IActionResult BookHotel(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(reservation);
        }
    }

}
