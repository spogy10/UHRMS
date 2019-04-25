namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoardingForm_Complete_Attribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoardingApplicationForms", "FormComplete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BoardingApplicationForms", "FormComplete");
        }
    }
}
