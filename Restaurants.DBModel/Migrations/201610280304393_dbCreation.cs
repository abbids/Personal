namespace Restaurants.DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SuburbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suburbs", t => t.SuburbId, cascadeDelete: true)
                .Index(t => t.SuburbId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "SuburbId", "dbo.Suburbs");
            DropIndex("dbo.Restaurants", new[] { "SuburbId" });
            DropTable("dbo.Suburbs");
            DropTable("dbo.Restaurants");
        }
    }
}
