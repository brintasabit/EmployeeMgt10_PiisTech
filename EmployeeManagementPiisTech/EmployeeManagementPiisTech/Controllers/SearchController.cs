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
        public ActionResult SearchEmployee(string employeeId)
        {
            Employee employee=new Employee();
            
         
         
           

            return View(employee);




        }

       
        public JsonResult CheckEmployee(string EmpId)
        {
            string message = "";
            bool result = false;
           // Employee employee = new Employee();
            
            
            if (_searchManager.SearchEmployees(EmpId))
            {
                message += " Successful!";
                result = true;
            }
            else
            {
                message += "Not Successful!";
                result = false;
            }

            return Json(new { result = result, message = message });
        }
        public ActionResult ShowEmployee(string employeeId)
        {
            Employee emp = new Employee();
            emp = _searchManager.GetEmployees(employeeId);
            return View(emp);
        }
    }
}