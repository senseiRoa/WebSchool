namespace WebSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirtsName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDay", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirthDay");
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirtsName");
        }
    }
}
