using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.Repository.Repository;

namespace EmployeeManagement.Bill.Bill
{
    public class SearchManager
    {
        SearchRepository _searchRepository=new SearchRepository();
        public bool SearchEmployees(Employee _employee)
        {
            return _searchRepository.SearchEmployees(_employee);
        }
    }
}
