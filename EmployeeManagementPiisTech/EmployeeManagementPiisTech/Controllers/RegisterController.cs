using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EmployeeManagement.Bill.Bill;
using EmployeeManagement.Model.Model;

namespace EmployeeManagementPiisTech.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private EmployeeDataManager _employeeDataManager=new EmployeeDataManager();
        [HttpGet]
        public ActionResult RegisterEmployee()
        {
            EmployeeData employeeData = new EmployeeData();

            return View(employeeData);
        }
        [HttpPost]
        public ActionResult RegisterEmployee(EmployeeData employeeData)
        {
            string message = "";
            //message+="Code: "+category.Code;
            message += "Name: " + employeeData.Email;
            message += "Name: " + employeeData.Password;
            message += "Name: " + employeeData.RememberMe;
            
            if (_employeeDataManager.RegisterEmployee(employeeData))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }

            return View(employeeData);
        }
    }
}