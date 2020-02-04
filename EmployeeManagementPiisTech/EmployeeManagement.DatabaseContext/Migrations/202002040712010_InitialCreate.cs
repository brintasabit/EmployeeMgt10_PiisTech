namespace EmployeeManagement.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        JobTitle = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.String(),
                        CurrentSalary = c.Double(nullable: false),
                        LastRevisedSalary = c.Double(nullable: false),
                        JoinDate = c.String(),
                        IsCurrentEmployee = c.Boolean(nullable: false),
                        LastSalaryIncrementDate = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeDatas");
        }
    }
}
