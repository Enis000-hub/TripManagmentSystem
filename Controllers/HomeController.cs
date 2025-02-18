using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripManagmentSystem.Models;

public class HomeController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    //  �������� UserManager
    public HomeController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }
}
