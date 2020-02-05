using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.DatabaseContext.DatabaseContext;
using System.Data.Entity;

namespace EmployeeManagement.Repository.Repository
{
    public class EmployeeRepository
    {
        public bool CreateEmployee(Employee _employee)
        {
            ProjectDbContext dbContext = new ProjectDbContext();
            dbContext.Employees.Add(_employee);
            return dbContext.SaveChanges() > 0;
        }
        public bool DeleteEmployee(Employee _employee)
        {
            ProjectDbContext dbContext = new ProjectDbContext();
            dbContext.Employees.Remove(_employee);
            return dbContext.SaveChanges()>0;

        }
    }
}
