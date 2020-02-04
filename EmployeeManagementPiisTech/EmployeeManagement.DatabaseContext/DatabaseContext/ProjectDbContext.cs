using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;

namespace EmployeeManagement.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeData> EmployeeDatas { get; set; }

    }
}
