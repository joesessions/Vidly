namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attemptedCleanup : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
 
        }
        
        public override void Down()
        {
 
            DropColumn("dbo.Customers", "Birthday");
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
