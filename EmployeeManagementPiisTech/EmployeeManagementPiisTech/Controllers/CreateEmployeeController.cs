using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Bill.Bill;
using EmployeeManagement.Model.Model;

namespace EmployeeManagementPiisTech.Controllers
{
    public class CreateEmployeeController : Controller
    {
        private EmployeeManager _employeeManager=new EmployeeManager();
        // GET: CreateEmployee
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            Employee employee=new Employee();

            return View(employee);
        }
        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            string message="";
            //message+="Code: "+category.Code;
            message+="Name: "+employee.FirstName;
            message+="Name: "+employee.LastName;
            message+="Name: "+employee.JobTitle;
            message+="Name: "+employee.Age;
            message+="Name: "+employee.Sex;
            message+="Name: "+employee.CurrentSalary;
            message+="Name: "+employee.LastRevisedSalary;
            message+="Name: "+employee.JoinDate;
            message+="Name: "+employee.IsCurrentEmployee;
            message+="Name: "+employee.LastSalaryIncrementDate;
            message+="Name: "+employee.CreatedBy;
            message+="Name: "+employee.CreatedDate;
            message+="Name: "+employee.EmployeeId;
            if (_employeeManager.CreateEmployee(employee))
            {
                message += "Saved!";
            }
            else
            {
                message += "Not Saved!";
            }

            return View(employee);
        }
    }
}