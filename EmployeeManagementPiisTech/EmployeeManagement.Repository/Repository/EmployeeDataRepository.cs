using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.DatabaseContext.DatabaseContext;
using System.Data.Entity;
using System.Runtime.InteropServices;

namespace EmployeeManagement.Repository.Repository
{
    public class EmployeeDataRepository
    {
        public bool RegisterEmployee(EmployeeData _employeeData)
        {
            ProjectDbContext dbContext = new ProjectDbContext();
            dbContext.EmployeeDatas.Add(_employeeData);
            return dbContext.SaveChanges() > 0;
        }
        public bool LogInEmployee(EmployeeData _employeeData)
        {
            bool result = false;
            ProjectDbContext dbContext = new ProjectDbContext();

            EmployeeData emp = dbContext.EmployeeDatas.Where(x => x.Email == _employeeData.Email).FirstOrDefault();
            if (emp != null)
            {
                if (emp.Password == _employeeData.Password)
                {
                    result = true;
                }
            }
            
            return result;
        }
    }
}
