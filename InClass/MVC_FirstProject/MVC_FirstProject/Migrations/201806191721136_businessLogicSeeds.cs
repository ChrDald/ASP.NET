namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class businessLogicSeeds : DbMigration
    {
        public override void Up()
        {
            // pay as you go
            Sql("INSERT INTO Memberships (ID, SignUpFee, DurationInMonths, DiscontRate) VALUES(1,0,0,0) ");

            // monthly
            Sql("INSERT INTO Memberships (ID, SignUpFee, DurationInMonths, DiscontRate) VALUES(2,10,1,10) ");

            // quarterly
            Sql("INSERT INTO Memberships (ID, SignUpFee, DurationInMonths, DiscontRate) VALUES(3,30,3,15) ");

            // yearly
            Sql("INSERT INTO Memberships (ID, SignUpFee, DurationInMonths, DiscontRate) VALUES(4,100,12,20) ");
        }
        
        public override void Down()
        {
        }
    }
}
