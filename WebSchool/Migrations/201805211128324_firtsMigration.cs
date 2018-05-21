namespace WebSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firtsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirtsName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.T_Course",
                c => new
                    {
                        CourseID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 25),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.T_InscriptionStudent",
                c => new
                    {
                        InscriptionStudentID = c.Guid(nullable: false),
                        StudentID = c.String(maxLength: 128),
                        Observation = c.String(maxLength: 500),
                        Assistance = c.Boolean(nullable: false),
                        InstanceOfCourseID = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InscriptionStudentID)
                .ForeignKey("dbo.T_InstanceOfCourse", t => t.InstanceOfCourseID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.StudentID)
                .Index(t => new { t.StudentID, t.InstanceOfCourseID }, unique: true, name: "IX_one");
            
            CreateTable(
                "dbo.T_InstanceOfCourse",
                c => new
                    {
                        InstanceOfCourseID = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        StartTime = c.Time(nullable: false, precision: 7),
                        FinalTime = c.Time(nullable: false, precision: 7),
                        TeacherID = c.String(maxLength: 128),
                        CourseID = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InstanceOfCourseID)
                .ForeignKey("dbo.T_Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.TeacherID)
                .Index(t => new { t.Date, t.StartTime, t.FinalTime, t.TeacherID }, unique: true, name: "IX_OnlySchedulePerTeacher")
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.T_School",
                c => new
                    {
                        SchoolID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 25),
                        CreateDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        EraseDate = c.DateTime(),
                        LogicalErasure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SchoolID);
            
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
            DropForeignKey("dbo.T_InscriptionStudent", "StudentID", "dbo.AspNetUsers");
            DropForeignKey("dbo.T_InscriptionStudent", "InstanceOfCourseID", "dbo.T_InstanceOfCourse");
            DropForeignKey("dbo.T_InstanceOfCourse", "TeacherID", "dbo.AspNetUsers");
            DropForeignKey("dbo.T_InstanceOfCourse", "CourseID", "dbo.T_Course");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.T_Permission", new[] { "MenuID" });
            DropIndex("dbo.T_Permission", new[] { "RoleID" });
            DropIndex("dbo.T_InstanceOfCourse", new[] { "CourseID" });
            DropIndex("dbo.T_InstanceOfCourse", "IX_OnlySchedulePerTeacher");
            DropIndex("dbo.T_InscriptionStudent", "IX_one");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.T_Permission");
            DropTable("dbo.T_Menu");
            DropTable("dbo.T_School");
            DropTable("dbo.T_InstanceOfCourse");
            DropTable("dbo.T_InscriptionStudent");
            DropTable("dbo.T_Course");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
