namespace MvcMovieDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}