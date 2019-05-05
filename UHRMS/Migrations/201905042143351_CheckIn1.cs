namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckIn1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckInForms",
                c => new
                    {
                        CheckInId = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        StudyDesk = c.String(nullable: false),
                        Chairs = c.String(nullable: false),
                        Bulb = c.String(nullable: false),
                        Closet = c.String(nullable: false),
                        Door = c.String(nullable: false),
                        Dresser = c.String(nullable: false),
                        Bed = c.String(nullable: false),
                        LightSwitch = c.String(nullable: false),
                        Mattress = c.String(nullable: false),
                        Windows = c.String(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        Dorm_dormId = c.Int(nullable: false),
                        Room_roomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CheckInId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Dorms", t => t.Dorm_dormId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_roomId, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Dorm_dormId)
                .Index(t => t.Room_roomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckInForms", "Room_roomId", "dbo.Rooms");
            DropForeignKey("dbo.CheckInForms", "Dorm_dormId", "dbo.Dorms");
            DropForeignKey("dbo.CheckInForms", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.CheckInForms", new[] { "Room_roomId" });
            DropIndex("dbo.CheckInForms", new[] { "Dorm_dormId" });
            DropIndex("dbo.CheckInForms", new[] { "ApplicationUser_Id" });
            DropTable("dbo.CheckInForms");
        }
    }
}
