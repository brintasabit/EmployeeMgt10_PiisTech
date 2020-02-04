using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.Repository.Repository;

namespace EmployeeManagement.Bill.Bill
{
    public class EmployeeDataManager
    {
        EmployeeDataRepository _employeeDataRepository=new EmployeeDataRepository();

        public bool RegisterEmployee(EmployeeData _employeeData)
        {
            return _employeeDataRepository.RegisterEmployee(_employeeData);
        }

        public bool LogInEmployee(EmployeeData _employeeData)
        {
            return _employeeDataRepository.LogInEmployee(_employeeData);
        }
    }
}
