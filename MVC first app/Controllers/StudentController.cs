using Microsoft.AspNetCore.Mvc;

namespace MVC_first_app.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAll()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update() {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
