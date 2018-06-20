namespace MVC_FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateNewMediaTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Media SET MediaType = 'Movie', MediaGenre = 'Thriller' WHERE ID = 1");
            Sql("UPDATE Media SET MediaType = 'Movie', MediaGenre = 'Thriller' WHERE ID = 2");
            Sql("UPDATE Media SET MediaType = 'TVShow', MediaGenre = 'Documentary' WHERE ID = 3");
            Sql("UPDATE Media SET MediaType = 'Instructional', MediaGenre = 'Action' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
