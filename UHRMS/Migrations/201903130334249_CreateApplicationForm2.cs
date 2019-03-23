namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationForm2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoardingApplicationForms", "country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoardingApplicationForms", "country");
        }
    }
}
