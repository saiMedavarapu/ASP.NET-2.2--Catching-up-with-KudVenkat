

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
            return View(model);
        }
    }
}
    