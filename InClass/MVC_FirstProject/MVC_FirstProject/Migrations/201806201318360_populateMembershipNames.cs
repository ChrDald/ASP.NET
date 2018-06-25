namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Memberships SET Name = 'Pay as you go' WHERE ID = 1;");
            Sql("UPDATE Memberships SET Name = 'Monthly' WHERE ID = 2;");
            Sql("UPDATE Memberships SET Name = 'Quarterly' WHERE ID = 3;");
            Sql("UPDATE Memberships SET Name = 'Yearly' WHERE ID = 4;");

        }
        
        public override void Down()
        {
        }
    }
}
