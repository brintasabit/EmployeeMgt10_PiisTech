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
        public bool SearchEmployees(string employeeId)
        {
            bool result = false;
            List<Employee> employees = new List<Employee>();
            ProjectDbContext dbContext = new ProjectDbContext();
            var emp = dbContext.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();


            if (emp != null)
            {

                //Employee em=new Employee();

                result = true;
                // employees.Add(em);

            }


            return result;

        }
        public Employee GetEmployees(string employeeId)
        {
            bool result = false;
            Employee employees = new Employee();
            ProjectDbContext dbContext = new ProjectDbContext();
            employees = dbContext.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();

            return employees;

        }
    }
}
