namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationForm3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoardingApplicationForms", "mailingCountry", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoardingApplicationForms", "mailingCountry");
        }
    }
}
