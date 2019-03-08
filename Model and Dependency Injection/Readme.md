## Review:
Model: Set of class represinting data and logic to represent the data.

-------------------------------

Employee.cs has the data objects and the implementation is in MockEmploeeRepository.cs in which IEmployeeRepository is used as the interface. 

public class MockEmployeeRepository: IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>(){
                new Employee(){ ID=1, Name="Loli", Department="IT", email="Loli@gmail.com" },
                new Employee(){ ID=2, Name="Jon", Department="Grader", email="Jon@gmail.com" },
                new Employee(){ ID=3, Name="Bao", Department="Grader", email="Bao@gmail.com" }
            } ;
        }

        public Employee GetEmployee(int ID){
            return _employeeList.FirstOrDefault(e=> e.ID==ID);
        }
    }
}


-----------------------------------------------------------

When we inject interface in constructor it gives us error in runtime.

public HomeController(IEmployeeRepository employeeRepository)//Constructor injection.
        {
            _employeeRepository = employeeRepository;
        }
        public string index(){
          return _employeeRepository.GetEmployee(1).Name;
        }
--------------------------------------------------------------
To over come this issue we have to use dependency injection.

Which can be injected from addsingleton method in startup.cs under configureServices.

Here: Since IEmployeeRepository is a interface and MockEmployeeRepository is instance of it we have to inject it too.

 public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddMvcCore();
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }
    ---------------------------------------------------