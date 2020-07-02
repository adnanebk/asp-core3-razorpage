using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        
        
        
        public static void Seed(this ModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "name1",
                        Department = Dept.IT,
                        Email = "name1@email.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "name2",
                        Department = Dept.HR,
                        Email = "name2@email.com"
                    },new Employee
                    {
                        Id = 3,
                        Name = "name3",
                        Department = Dept.IT,
                        Email = "name3@email.com"
                    },new Employee
                    {
                        Id = 4,
                        Name = "name4",
                        Department = Dept.IT,
                        Email = "name1@email.com"
                    }
                );
        }
    }
}
