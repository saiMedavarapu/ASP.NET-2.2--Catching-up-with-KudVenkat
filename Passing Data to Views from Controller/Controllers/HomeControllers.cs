

// namespace MVC.Controllers
// {
//     public class HomeController
//     {
//         public string index(){
//             return "Hello from MVC";
//         }
//     }
// }

using Microsoft.AspNetCore.Mvc;
using MODEL.Models;

namespace MVC.Controllers
{
    public class HomeController: Controller
    {
        private IEmployeeRepository _employeeRepository;
      

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string index(){
          return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details(){
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);----> this for naming the same cshtml file as view name
            //return View("test");----> this for other name but inside the views/home folder.
            // return View("Myviews/test.cshtml");//----> this is for the relative path of other view folder.
            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            ViewBag.Employee = model;
            ViewBag.PageTitle = "Page Title";
            return View();
        }
    }
}
