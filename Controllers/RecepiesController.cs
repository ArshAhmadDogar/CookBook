using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using CookBook.Models;

namespace CookBook.Controllers{

public class RecepiesController : Controller
{
    private RecepieDbContext _recepie;
    // private CommentsDbContext _cmnt;

    public RecepiesController(RecepieDbContext contx)
    {
        _recepie=contx;
    }
   
    public ActionResult Recepies()
    {
        return View(_recepie.Recepies.ToList());
    }

   


    public ViewResult CreateNew()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateNew([Bind("name","price","Category","Description","Ingredients","UserId")] Recepie recepie)
    {
        _recepie.Add(recepie);
        _recepie.SaveChanges();
        return RedirectToAction("Recepies");
    }

    public ViewResult Details(int id)
        {
            dynamic mymodel = new ExpandoObject();
            var det = _recepie.Recepies.Find(id);
            var user = _recepie.Users.Find(det.UserId);
            mymodel.Recepie=det;
            mymodel.User=user;
            mymodel.Comments = _recepie.Comments;
            return View(mymodel);
        }

     [HttpPost]
        public IActionResult Comments([Bind("name","email","Comment")] Comments cmnt)
        {
            _recepie.Add(cmnt);
            _recepie.SaveChanges();
            return View();
        }


}
}
