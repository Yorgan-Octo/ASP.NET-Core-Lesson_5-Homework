using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {

        public static int Users { get; set; }



        public IActionResult Start()
        {
            Users++;
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            return View(Users);
        }

    }
}