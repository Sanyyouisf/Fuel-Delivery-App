namespace FuelDeliveryApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OperatingRegions",
                c => new
                    {
                        regionId = c.Int(nullable: false, identity: true),
                        regionName = c.String(),
                    })
                .PrimaryKey(t => t.regionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OperatingRegions");
        }
    }
}
