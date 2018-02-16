using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Pessoa()
        {
            return View(1);
        }
    }
}