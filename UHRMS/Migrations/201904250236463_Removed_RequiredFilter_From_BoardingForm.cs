namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removed_RequiredFilter_From_BoardingForm : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BoardingApplicationForms", "ApplicantType", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "firstName", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "fmiddleInitial", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "lastName", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "gender", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "nationality", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "email", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "faculty", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "school", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "programme", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "programmeMode", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "BoardingPeriod", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "hallPreference", c => c.String());
            AlterColumn("dbo.BoardingApplicationForms", "reasonOfApplication", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BoardingApplicationForms", "reasonOfApplication", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "hallPreference", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "BoardingPeriod", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "programmeMode", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "programme", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "school", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "faculty", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "email", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "nationality", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "gender", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "fmiddleInitial", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "ApplicantType", c => c.String(nullable: false));
        }
    }
}
