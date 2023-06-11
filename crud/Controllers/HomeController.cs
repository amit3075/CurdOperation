using Microsoft.AspNetCore.Mvc;
using crud.Models;
using System.Diagnostics;

namespace crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            student s1 = new student();
            var l1 = s1.GetStudentList();
            return View(l1);
        }

        public IActionResult edit(int id)
        {
            var student = new student();
            var studentList = student.GetStudentList();
            var model = studentList.Where(x => x.Id == id).FirstOrDefault();
            if (model != null)
                return View(model);
            //foreach (var x in studentList)
            //{
            //    if (x.Id == id)
            //    {
            //        x.Name = model.Name;
            //        x.Address = model.Address;
            //        x.Age = model.Age;
            //    }
            //}
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}