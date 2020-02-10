using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Bill.Bill;
using EmployeeManagement.Model.Model;

namespace EmployeeManagementPiisTech.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit
        private EditManager _editManager = new EditManager();
        [HttpGet]
        public ActionResult EditEmployee()
        {
            Employee employee = new Employee();

            return View(employee);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee employee)
        {
            string message = "";
            
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

            if (_editManager.Edit(employee))
            {
                message += "Edit Successful!";
            }
            else
            {
                message += "Not Successful!";
            }

            return View(employee);
        }
        public JsonResult CheckEditEmployee(string employeeId )
        {
            string message = "";
            bool result = false;
            Employee employee = new Employee();
            //employee.FirstName = fName;
            //employee.LastName = lName;
            //employee.JobTitle = jobTitle;
            //employee.Age = age;
            //employee.Sex = sex;
            //employee.CurrentSalary = cSalary;
            //employee.LastRevisedSalary = lRSalary;
            //employee.JoinDate = jDate;
            //employee.IsCurrentEmployee = isCEmployee;
            //employee.LastSalaryIncrementDate = lSIDate;
            //employee.CreatedBy = createdBy;
            //employee.CreatedDate = createdDate;
            employee.EmployeeId = employeeId;

            if (_editManager.Edit(employee))
            {
                message += "Edit Successful!";
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