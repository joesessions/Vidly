namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ( 'John Smith', 'FALSE', 1)");
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ( 'Mary Tascule', 'TRUE', 2)");
            
        }

        public override void Down()
        {
        }
    }
}

