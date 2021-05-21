namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMessageIdGeneration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Messages");
            AlterColumn("dbo.Messages", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Messages", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Messages");
            AlterColumn("dbo.Messages", "Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Messages", "Id");
        }
    }
}
