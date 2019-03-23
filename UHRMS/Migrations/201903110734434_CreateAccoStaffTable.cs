namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAccoStaffTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccoStaffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        Staff_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Staff_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccoStaffs", "Staff_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AccoStaffs", new[] { "Staff_Id" });
            DropTable("dbo.AccoStaffs");
        }
    }
}
