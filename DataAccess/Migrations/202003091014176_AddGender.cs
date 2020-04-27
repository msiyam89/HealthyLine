namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Gender", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Gender");
        }
    }
}
