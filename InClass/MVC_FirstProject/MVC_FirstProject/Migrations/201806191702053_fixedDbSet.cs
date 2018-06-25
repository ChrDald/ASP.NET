namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subscribed = c.Boolean(nullable: false),
                        MembershipID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Memberships", t => t.MembershipID, cascadeDelete: true)
                .Index(t => t.MembershipID);
            
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscontRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipID", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipID" });
            DropTable("dbo.Media");
            DropTable("dbo.Memberships");
            DropTable("dbo.Customers");
        }
    }
}
