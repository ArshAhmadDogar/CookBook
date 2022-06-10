using Microsoft.AspNetCore.Mvc;

namespace CookBook.Controllers{
    public class ClassesController : Controller{
        public ViewResult Main()
        {
            return View();
        }
    }
}