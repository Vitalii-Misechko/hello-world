namespace MvcMovieDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        OscarsNumber = c.Int(nullable: false),
                        Movie_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .Index(t => t.Movie_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "Movie_ID" });
            DropTable("dbo.Actors");
        }
    }
}
