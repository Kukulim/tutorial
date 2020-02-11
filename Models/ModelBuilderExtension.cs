using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
            ID = 1,
            Name = "Luk",
            Department = DepEnum.Programista,
            Email = "luk@luk.pl"
            },
            new Employee
            {
                ID = 2,
                Name = "Kate",
                Department = DepEnum.HR,
                Email = "Kate@luk.pl"
            }
            );
        }
    }
}
