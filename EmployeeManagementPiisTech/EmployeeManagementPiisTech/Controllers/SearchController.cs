using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Bill.Bill;
using EmployeeManagement.Model.Model;

namespace EmployeeManagementPiisTech.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        private SearchManager _searchManager=new SearchManager();

        [HttpGet]
        public ActionResult SearchEmployee()
        {
            Employee employee = new Employee();

            return View(employee);
        }
        [HttpPost]
        public ActionResult SearchEmployee(Employee employee)
        {
            string message = "";
            //message+="Code: "+category.Code;
            message += "Name: " + employee.FirstName;
            message += "Name: " + employee.LastName;


            if (_searchManager.SearchEmployees(employee))
            {
                message += "Exists!";
            }
            else
            {
                message += "Not Exists!";
            }

            return View(employee);
        }
        public JsonResult CheckEmployee(int EmpId)
        {
            string message = "";
            bool result = false;
            Employee employee = new Employee();
            employee.EmployeeId = EmpId;
            
            if (_searchManager.SearchEmployees(employee))
            {
                message += "Successful!";
                result = true;
            }
            else
            {
                message += "Not Successful!";
                result = false;
            }

            return Json(new { result = result, message = message });
        }
    }
}