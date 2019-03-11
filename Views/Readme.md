If we call any view method and return a view object without creating the .cshtml file it will give the kestral error. 


------------------------------
public ViewResult Details(){
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);----> this for naming the same cshtml file as view name
            //return View("test");----> this for other name but inside the views/home folder.
            return View("Myviews/test.cshtml");//----> this is for the relative path of other view folder.
        }
    }
------------------------------------------------------

To fix it. Create a new folder, views(if you dont have one) and insert a folder with name of your controller in it. 

## NOTE:
Inside that create a file with .cshtml extension and give it a name of method which you are return in the view object to.


View is a file with cshtml file.
-------------------------------------------------
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

-----------------------------------------------------------

## Customizing the views by passing the view name as a return object.

 public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string index(){
          return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details(){
            Employee model = _employeeRepository.GetEmployee(1);




            //return View(model);
            return View("test");
        }
--------------------------------------------------
## If we want from other folders. Views can be provided as the object rhough absolute path

public ViewResult Details(){
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);----> this for naming the same cshtml file as view name
            //return View("test");----> this for other name but inside the views/home folder.
            return View("Myviews/test.cshtml");//----> this is for the relative path of other view folder.
        }
    }
