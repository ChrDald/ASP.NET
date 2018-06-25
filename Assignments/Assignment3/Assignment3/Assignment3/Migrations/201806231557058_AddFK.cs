namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFK : DbMigration
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

            AddColumn("dbo.Phones", "PhoneTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Phones", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Phones", "PhoneTypeId");
            CreateIndex("dbo.Phones", "BrandId");
            AddForeignKey("dbo.Phones", "BrandId", "dbo.Brands", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Phones", "PhoneTypeId", "dbo.PhoneTypes", "ID", cascadeDelete: true);
            DropColumn("dbo.Phones", "Brand");
            DropColumn("dbo.Phones", "PhoneType");
        }
        
        public override void Down()
        {
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.Phones");
            DropTable("dbo.Brands");

            AddColumn("dbo.Phones", "PhoneType", c => c.String());
            AddColumn("dbo.Phones", "Brand", c => c.String());
            DropForeignKey("dbo.Phones", "PhoneTypeId", "dbo.PhoneTypes");
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "BrandId" });
            DropIndex("dbo.Phones", new[] { "PhoneTypeId" });
            DropColumn("dbo.Phones", "BrandId");
            DropColumn("dbo.Phones", "PhoneTypeId");
        }
    }
}
