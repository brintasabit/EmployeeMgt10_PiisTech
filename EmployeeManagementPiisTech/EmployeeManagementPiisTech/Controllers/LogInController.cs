using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Bill.Bill;
using EmployeeManagement.Model.Model;

namespace EmployeeManagementPiisTech.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private EmployeeDataManager _employeeDataManager = new EmployeeDataManager();
        [HttpGet]
        public ActionResult LogInEmployee()
        {
            EmployeeData employeeData = new EmployeeData();

            return View(employeeData);
        }
        [HttpPost]
        public ActionResult LogInEmployee(EmployeeData employeeData)
        {
            string message = "";
            //message+="Code: "+category.Code;
            message += "Name: " + employeeData.Email;
            message += "Name: " + employeeData.Password;
            message += "Name: " + employeeData.RememberMe;

            if (_employeeDataManager.LogInEmployee(employeeData))
            {
                message += "Log In Successful!";
            }
            else
            {
                message += "Not Saved!";
            }

            return View(employeeData);
        }
        public JsonResult CheckLogInEmployee(string Email,string Password)
        {
            string message = "";
            bool result = false;
            EmployeeData employeeData = new EmployeeData();
            employeeData.Email = Email;
            employeeData.Password = Password;
            if (_employeeDataManager.LogInEmployee(employeeData))
            {
                message += "Log In Successful!";
                result = true;
            }
            else
            {
                message += "Not Successful!";
                result = false;
            }

            return Json(new { result = result,message = message});
        }
    }
}