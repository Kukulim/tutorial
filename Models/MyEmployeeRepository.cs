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

        public Employee DeleteEmployee(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.ID == id);
            if(employee != null) 
            { 
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public Employee EditEmployee(Employee employee)
        {
            Employee employee1 = _employeeList.FirstOrDefault(e => e.ID == employee.ID);
            if (employee != null)
            {
                employee1.Name = employee.Name;
                employee1.Email = employee.Email;
                employee1.Department = employee.Department;
            }
            return employee1;
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
