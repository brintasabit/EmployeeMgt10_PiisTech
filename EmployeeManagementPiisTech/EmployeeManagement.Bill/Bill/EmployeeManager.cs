using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.Repository.Repository;

namespace EmployeeManagement.Bill.Bill
{
    public class EmployeeManager
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public bool CreateEmployee(Employee _employee)
        {
            return _employeeRepository.CreateEmployee(_employee);
        }
    }
}
