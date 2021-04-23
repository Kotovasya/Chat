namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageDateAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dialogs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                        Password = c.String(),
                        Owner_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Text = c.String(),
                        Author_Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Dialog_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Dialogs", t => t.Dialog_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Dialog_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsersDialogs",
                c => new
                    {
                        Dialog_Id = c.Int(nullable: false),
                        User_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dialog_Id, t.User_Id })
                .ForeignKey("dbo.Dialogs", t => t.Dialog_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Dialog_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersDialogs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UsersDialogs", "Dialog_Id", "dbo.Dialogs");
            DropForeignKey("dbo.Messages", "Dialog_Id", "dbo.Dialogs");
            DropForeignKey("dbo.Messages", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Dialogs", "Owner_Id", "dbo.Users");
            DropIndex("dbo.UsersDialogs", new[] { "User_Id" });
            DropIndex("dbo.UsersDialogs", new[] { "Dialog_Id" });
            DropIndex("dbo.Messages", new[] { "Dialog_Id" });
            DropIndex("dbo.Messages", new[] { "Author_Id" });
            DropIndex("dbo.Dialogs", new[] { "Owner_Id" });
            DropTable("dbo.UsersDialogs");
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
            DropTable("dbo.Dialogs");
        }
    }
}
