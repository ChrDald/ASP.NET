namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTypeGenreToMedia : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Media ADD MediaType VARCHAR(30) ");
            Sql("ALTER TABLE Media ADD MediaGenre VARCHAR(30) ");
        }
        
        public override void Down()
        {
        }
    }
}
