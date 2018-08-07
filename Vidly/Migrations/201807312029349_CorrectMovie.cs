namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "Comedy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Comedy", c => c.String());
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
