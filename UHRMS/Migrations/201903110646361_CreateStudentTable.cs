namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        permanentAddress = c.String(),
                        studentPhoneNumber = c.Int(nullable: false),
                        faculty = c.String(),
                        programme = c.String(),
                        durationOfProgramme = c.Int(nullable: false),
                        emergencyContactName1 = c.String(),
                        emergencyContactNumber1 = c.String(),
                        emergencyContactAddress1 = c.String(),
                        emergencyContactName2 = c.String(),
                        emergencyContactNumber2 = c.String(),
                        emergencyContactAddress2 = c.String(),
                        Applicant_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.studentId)
                .ForeignKey("dbo.AspNetUsers", t => t.Applicant_Id)
                .Index(t => t.Applicant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Applicant_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "Applicant_Id" });
            DropTable("dbo.Students");
        }
    }
}
