using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.Repository.Repository;

namespace EmployeeManagement.Bill.Bill
{
    public class EditManager
    {
        EditRepository _editRepository=new EditRepository();
        public bool Edit(Employee _employee)
        {
            return _editRepository.Edit(_employee);
        }
    }
}
