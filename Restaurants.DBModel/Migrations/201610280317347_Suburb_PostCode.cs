namespace Restaurants.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Suburb_PostCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suburbs", "PostCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suburbs", "PostCode");
        }
    }
}
