namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoardingApplicationForms", "ApplicationScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoardingApplicationForms", "ApplicationScore");
        }
    }
}
