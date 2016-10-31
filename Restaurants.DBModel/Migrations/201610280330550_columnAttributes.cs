namespace Restaurants.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Suburbs", "SuburbName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Suburbs", "PostCode", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suburbs", "PostCode", c => c.String());
            AlterColumn("dbo.Suburbs", "SuburbName", c => c.String());
            AlterColumn("dbo.Restaurants", "Name", c => c.String());
        }
    }
}
