namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoardingForm : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BoardingApplicationForms", new[] { "studentId_studentId" });
            RenameColumn(table: "dbo.BoardingApplicationForms", name: "studentId_studentId", newName: "studentId");
            DropPrimaryKey("dbo.BoardingApplicationForms");
            AddColumn("dbo.BoardingApplicationForms", "ApplicantType", c => c.String(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "BoardingPeriod", c => c.String(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "NumberOfSiblings", c => c.Int(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "isFatherFinacing", c => c.Boolean(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "isMotherFinacing", c => c.Boolean(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "areYouFinancing", c => c.Boolean(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "requestedSponsorship", c => c.Boolean(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "requestedGrant", c => c.Boolean(nullable: false));
            AddColumn("dbo.BoardingApplicationForms", "attributes1", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "attributes2", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "attributes3", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "attributes4", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "attributes5", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "fmiddleInitial", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "gender", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "nationality", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "email", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "faculty", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "school", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "programme", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "programmeMode", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "yearOfStudy", c => c.Int(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "hallPreference", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "familyBirthPosition", c => c.Int(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "numberOfDependants", c => c.Int(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "slbQuestion", c => c.Boolean(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "reasonOfApplication", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "expectedToStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "expectedToDepart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "studentId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.BoardingApplicationForms", "studentId");
            CreateIndex("dbo.BoardingApplicationForms", "studentId");
            DropColumn("dbo.BoardingApplicationForms", "Id");
            DropColumn("dbo.BoardingApplicationForms", "hallPreferencQuestion");
            DropColumn("dbo.BoardingApplicationForms", "scholarshipsGrantedAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BoardingApplicationForms", "scholarshipsGrantedAmount", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "hallPreferencQuestion", c => c.String());
            AddColumn("dbo.BoardingApplicationForms", "Id", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.BoardingApplicationForms", new[] { "studentId" });
            DropPrimaryKey("dbo.BoardingApplicationForms");
            AlterColumn("dbo.BoardingApplicationForms", "studentId", c => c.Int());
            AlterColumn("dbo.BoardingApplicationForms", "expectedToDepart", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "expectedToStart", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "reasonOfApplication", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "slbQuestion", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "numberOfDependants", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "familyBirthPosition", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "hallPreference", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "yearOfStudy", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "programmeMode", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "programme", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "school", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "faculty", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "email", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "nationality", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "gender", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "lastName", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "fmiddleInitial", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "firstName", c => c.String());
            DropColumn("dbo.BoardingApplicationForms", "attributes5");
            DropColumn("dbo.BoardingApplicationForms", "attributes4");
            DropColumn("dbo.BoardingApplicationForms", "attributes3");
            DropColumn("dbo.BoardingApplicationForms", "attributes2");
            DropColumn("dbo.BoardingApplicationForms", "attributes1");
            DropColumn("dbo.BoardingApplicationForms", "requestedGrant");
            DropColumn("dbo.BoardingApplicationForms", "requestedSponsorship");
            DropColumn("dbo.BoardingApplicationForms", "areYouFinancing");
            DropColumn("dbo.BoardingApplicationForms", "isMotherFinacing");
            DropColumn("dbo.BoardingApplicationForms", "isFatherFinacing");
            DropColumn("dbo.BoardingApplicationForms", "NumberOfSiblings");
            DropColumn("dbo.BoardingApplicationForms", "BoardingPeriod");
            DropColumn("dbo.BoardingApplicationForms", "ApplicantType");
            AddPrimaryKey("dbo.BoardingApplicationForms", "Id");
            RenameColumn(table: "dbo.BoardingApplicationForms", name: "studentId", newName: "studentId_studentId");
            CreateIndex("dbo.BoardingApplicationForms", "studentId_studentId");
        }
    }
}
