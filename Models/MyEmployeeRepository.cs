using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public class MyEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MyEmployeeRepository()
        {
            _employeeList = new List<Employee>() { 
                new Employee(){ ID = 1, Name = "Luk", Email = "luk@luk.pl", Department = DepEnum.Programista},
                new Employee(){ ID = 2, Name = "Muk", Email = "muk@luk.pl", Department = DepEnum.HR},
                new Employee(){ ID = 3, Name = "Kusz", Email = "kusz@luk.pl", Department = DepEnum.Lekarz}
            };

        }

        public Employee AddEmployee(Employee employee)
        {
            employee.ID = _employeeList.Max(e => e.ID) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int ID)
        {
            return _employeeList.FirstOrDefault(e => e.ID == ID);
        }
    }
}
