using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CookBook.Models;

namespace CookBook.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private RecepieDbContext _recepie;

    public HomeController(ILogger<HomeController> logger,RecepieDbContext recepie)
    {
        _logger = logger;
        _recepie = recepie;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ViewResult Register()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Register([Bind("name","email","password")] User usr)
    {
        _recepie.Add(usr);
        _recepie.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ViewResult Login()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Login([Bind("email","password")] User usr)
    {
        var User = _recepie.Users.Where(s => s.email==usr.email && s.password == usr.password).FirstOrDefault();
        if (User!=null && usr.email == User.email && usr.password ==User.password )
        {
            return RedirectToAction("Recepies","Recepies");
        }else {
            return RedirectToAction("Index","Home");
        }
        
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
