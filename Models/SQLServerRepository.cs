using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public class SQLServerRepository
        : IEmployeeRepository
    {
        private readonly AppDBContext context;

        public SQLServerRepository(AppDBContext context)
        {
            this.context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null) 
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public Employee EditEmployee(Employee employee)
        {
            var employee1 = context.Employees.Attach(employee);
            employee1.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int ID)
        {
            Employee employee = context.Employees.Find(ID);
            return employee;
        }
    }
}
