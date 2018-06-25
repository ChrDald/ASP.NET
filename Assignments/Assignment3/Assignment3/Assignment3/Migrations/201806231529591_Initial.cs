namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        CountryOfOrigin = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(),
                        Brand = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        ScreenSize = c.String(),
                        PhoneType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        OS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.Phones");
            DropTable("dbo.Brands");
        }
    }
}
