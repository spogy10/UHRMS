namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationForm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoardingApplicationForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        studentStatus = c.String(),
                        title = c.String(),
                        firstName = c.String(),
                        fmiddleInitial = c.String(),
                        lastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        nationality = c.String(),
                        religion = c.String(),
                        denomination = c.String(),
                        homeTelephone = c.Int(nullable: false),
                        mobileTelephone = c.Int(nullable: false),
                        workTelephone = c.Int(nullable: false),
                        email = c.String(),
                        postOfficeBox = c.String(),
                        street = c.String(),
                        town = c.String(),
                        parish = c.String(),
                        mailingPostOfficeBox = c.String(),
                        mailingStreet = c.String(),
                        mailingTown = c.String(),
                        mailingParish = c.String(),
                        emergencyContactName1 = c.String(),
                        emergencyContactRelationship1 = c.String(),
                        emergencyContactMobileNumber1 = c.String(),
                        emergencyContactMWorkNumber1 = c.String(),
                        emergencyContactAddress1 = c.String(),
                        emergencyContactName2 = c.String(),
                        emergencyContactRelationship2 = c.String(),
                        emergencyContactMobileNumber2 = c.String(),
                        emergencyContactMWorkNumber2 = c.String(),
                        emergencyContactAddress2 = c.String(),
                        familyDoctorName = c.String(),
                        familyDoctorNumber = c.String(),
                        medicalConditions = c.String(),
                        specialNeeds = c.String(),
                        faculty = c.String(),
                        school = c.String(),
                        programme = c.String(),
                        programmeMode = c.String(),
                        yearOfStudy = c.String(),
                        licensePeriod = c.String(),
                        hallPreference = c.String(),
                        hallPreferencQuestion = c.String(),
                        vehicleType = c.String(),
                        vehicleModel = c.String(),
                        vehicleMake = c.String(),
                        registrationNumber = c.String(),
                        fatherOccupation = c.String(),
                        motherOccupation = c.String(),
                        guardianOccupation = c.String(),
                        familyBirthPosition = c.String(),
                        numberOfDependants = c.String(),
                        financeer = c.String(),
                        slbQuestion = c.String(),
                        scholarshipsGranted = c.String(),
                        scholarshipsGrantedAmount = c.String(),
                        extraCurriculars1 = c.String(),
                        extraCurriculars2 = c.String(),
                        extraCurriculars3 = c.String(),
                        extraCurriculars4 = c.String(),
                        extraCurriculars5 = c.String(),
                        skills1 = c.String(),
                        skills2 = c.String(),
                        skills3 = c.String(),
                        skills4 = c.String(),
                        skills5 = c.String(),
                        reasonOfApplication = c.String(),
                        hallBlock = c.String(),
                        roomNumber = c.Int(nullable: false),
                        yearsOnHall = c.Int(nullable: false),
                        hallCommiteesServed = c.String(),
                        hallActivitiesInvolved = c.String(),
                        reasonReturning = c.String(),
                        expectedToStart = c.String(),
                        expectedToDepart = c.String(),
                        Applicant_Id = c.String(maxLength: 128),
                        studentId_studentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Applicant_Id)
                .ForeignKey("dbo.Students", t => t.studentId_studentId)
                .Index(t => t.Applicant_Id)
                .Index(t => t.studentId_studentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BoardingApplicationForms", "studentId_studentId", "dbo.Students");
            DropForeignKey("dbo.BoardingApplicationForms", "Applicant_Id", "dbo.AspNetUsers");
            DropIndex("dbo.BoardingApplicationForms", new[] { "studentId_studentId" });
            DropIndex("dbo.BoardingApplicationForms", new[] { "Applicant_Id" });
            DropTable("dbo.BoardingApplicationForms");
        }
    }
}
