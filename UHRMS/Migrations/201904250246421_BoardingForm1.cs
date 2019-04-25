namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoardingForm1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BoardingApplicationForms", "DOB", c => c.DateTime());
            AlterColumn("dbo.BoardingApplicationForms", "expectedToStart", c => c.DateTime());
            AlterColumn("dbo.BoardingApplicationForms", "expectedToDepart", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BoardingApplicationForms", "expectedToDepart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "expectedToStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BoardingApplicationForms", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
