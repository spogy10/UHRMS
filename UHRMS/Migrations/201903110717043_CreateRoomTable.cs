namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRoomTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        roomId = c.Int(nullable: false, identity: true),
                        dormNumber = c.Int(nullable: false),
                        currentOccupancy = c.Int(nullable: false),
                        maxOccupancy = c.Int(nullable: false),
                        feeNo = c.Int(nullable: false),
                        roomDescription = c.String(),
                        Staff_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.roomId)
                .ForeignKey("dbo.AspNetUsers", t => t.Staff_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Staff_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Rooms", new[] { "Staff_Id" });
            DropTable("dbo.Rooms");
        }
    }
}
