using System;
using System.Linq;
using System.Collections.Generic;
using MODEL.Models;

namespace Model.Models
{
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