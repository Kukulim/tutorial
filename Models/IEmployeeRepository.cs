﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int ID);
        IEnumerable<Employee> GetAllEmployee();
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        Employee EditEmployee(Employee employee);

    }
}
