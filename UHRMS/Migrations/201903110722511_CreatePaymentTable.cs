namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePaymentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        paymentId = c.Int(nullable: false, identity: true),
                        studentId = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        cardtype = c.String(),
                        accountnumber = c.Int(nullable: false),
                        expirationMonth = c.Int(nullable: false),
                        expirationYear = c.Int(nullable: false),
                        CSV = c.Int(nullable: false),
                        Staff_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.paymentId)
                .ForeignKey("dbo.AspNetUsers", t => t.Staff_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Staff_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Payments", new[] { "Staff_Id" });
            DropTable("dbo.Payments");
        }
    }
}
