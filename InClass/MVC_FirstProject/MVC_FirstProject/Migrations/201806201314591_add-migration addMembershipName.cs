namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationaddMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Memberships ADD Name VARCHAR(50)");
        }
        
        public override void Down()
        {
        }
    }
}
