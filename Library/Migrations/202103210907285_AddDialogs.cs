namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDialogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dialogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        OwnerId = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                        Message_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.OwnerId, cascadeDelete: true)
                .ForeignKey("dbo.Messages", t => t.Message_Id)
                .Index(t => t.OwnerId)
                .Index(t => t.User_Id)
                .Index(t => t.Message_Id);
                        
            AddColumn("dbo.Users", "Dialog_Id", c => c.Int());
            AddColumn("dbo.Messages", "Dialog_Id", c => c.Int());
            CreateIndex("dbo.Messages", "Dialog_Id");
            CreateIndex("dbo.Users", "Dialog_Id");
            AddForeignKey("dbo.Users", "Dialog_Id", "dbo.Dialogs", "Id");
            AddForeignKey("dbo.Messages", "Dialog_Id", "dbo.Dialogs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Dialog_Id", "dbo.Dialogs");
            DropForeignKey("dbo.Dialogs", "OwnerId", "dbo.Users");
            DropForeignKey("dbo.Dialogs", "Message_Id", "dbo.Users");
            DropForeignKey("dbo.Dialogs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Dialog_Id", "dbo.Dialogs");
            DropIndex("dbo.Users", new[] { "Dialog_Id" });
            DropIndex("dbo.Messages", new[] { "Dialog_Id" });
            DropIndex("dbo.Dialogs", new[] { "Message_Id" });
            DropIndex("dbo.Dialogs", new[] { "User_Id" });
            DropIndex("dbo.Dialogs", new[] { "OwnerId" });
            DropColumn("dbo.Users", "Dialog_Id");
            DropColumn("dbo.Messages", "Dialog_Id");
            DropTable("dbo.Dialogs");
        }
    }
}
