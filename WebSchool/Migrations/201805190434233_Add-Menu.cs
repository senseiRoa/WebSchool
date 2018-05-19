namespace WebSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Menu",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(nullable: false, maxLength: 50),
                        ParentMenuID = c.Int(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        MenuURL = c.String(maxLength: 100),
                        MenuIcon = c.String(maxLength: 25),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MenuID);
            
            CreateTable(
                "dbo.T_Permission",
                c => new
                    {
                        PermissionID = c.Guid(nullable: false),
                        RoleID = c.String(nullable: false, maxLength: 128),
                        MenuID = c.Int(nullable: false),
                        Action = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PermissionID)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("dbo.T_Menu", t => t.MenuID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Permission", "MenuID", "dbo.T_Menu");
            DropForeignKey("dbo.T_Permission", "RoleID", "dbo.AspNetRoles");
            DropIndex("dbo.T_Permission", new[] { "MenuID" });
            DropIndex("dbo.T_Permission", new[] { "RoleID" });
            DropTable("dbo.T_Permission");
            DropTable("dbo.T_Menu");
        }
    }
}
