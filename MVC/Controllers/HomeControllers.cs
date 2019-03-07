

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

namespace MVC.Controllers
{
    public class HomeController: Controller
    {
        public JsonResult index(){
            return Json(new{id=1, name="Loli"});
        }
    }
}
    