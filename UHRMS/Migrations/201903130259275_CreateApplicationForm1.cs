namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationForm1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoardingApplicationForms", "gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoardingApplicationForms", "gender");
        }
    }
}
