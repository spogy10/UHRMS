namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDormTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "Staff_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Rooms", new[] { "Staff_Id" });
            CreateTable(
                "dbo.Dorms",
                c => new
                    {
                        dormId = c.Int(nullable: false, identity: true),
                        dormName = c.String(),
                        numberOfRooms = c.Int(nullable: false),
                        numberOfBathrooms = c.Int(nullable: false),
                        dormDetails = c.String(),
                        Staff_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.dormId)
                .ForeignKey("dbo.AspNetUsers", t => t.Staff_Id)
                .Index(t => t.Staff_Id);
            
            DropTable("dbo.Rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        roomId = c.Int(nullable: false, identity: true),
                        dormName = c.String(),
                        numberOfRooms = c.Int(nullable: false),
                        numberOfBathrooms = c.Int(nullable: false),
                        dormDetails = c.String(),
                        Staff_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.roomId);
            
            DropForeignKey("dbo.Dorms", "Staff_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Dorms", new[] { "Staff_Id" });
            DropTable("dbo.Dorms");
            CreateIndex("dbo.Rooms", "Staff_Id");
            AddForeignKey("dbo.Rooms", "Staff_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
