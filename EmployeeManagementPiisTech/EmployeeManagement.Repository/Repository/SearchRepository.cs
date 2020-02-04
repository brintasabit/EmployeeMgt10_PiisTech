using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.DatabaseContext.DatabaseContext;

namespace EmployeeManagement.Repository.Repository
{
    public class SearchRepository
    {
        public bool SearchEmployees(Employee _employee)
        {
            bool result = false;
            List<Employee>employees=new List<Employee>();
            ProjectDbContext dbContext = new ProjectDbContext();
            Employee emp = dbContext.Employees.Where(x => x.EmployeeId == _employee.EmployeeId).FirstOrDefault();
            
                if (emp.EmployeeId == _employee.EmployeeId)
                {
                    //Employee em=new Employee();

                    result = true;
                   // employees.Add(em);
                }

                return result;

        }
    }
}
