using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public double CurrentSalary { get; set; }
        public double LastRevisedSalary { get; set; }
        public string JoinDate { get; set; }
        public bool IsCurrentEmployee { get; set; }
        public string LastSalaryIncrementDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string EmployeeId { get; set; }
    }
}
