namespace EmployeeManagement.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeIdTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmployeeId", c => c.Int(nullable: false));
        }
    }
}
