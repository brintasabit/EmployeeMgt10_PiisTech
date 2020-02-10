using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model.Model;
using EmployeeManagement.DatabaseContext.DatabaseContext;

namespace EmployeeManagement.Repository.Repository
{
    public class EditRepository
    {
        public bool Edit(Employee _employee)
        {
            try
            {
                ProjectDbContext dbContext = new ProjectDbContext();
                //Supplier aSupplier = dbContext.Suppliers.FirstOrDefault(c => c.Id == _supplier.Id);
                dbContext.Entry(_employee).State = EntityState.Modified;
                //dbContext.Suppliers.AddOrUpdate(aSupplier);
                return dbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
               // Console.WriteLine(e);
                throw;
            }
        }

    }
}
