namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserLastActivityAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastActivity", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "LastActivity");
        }
    }
}
