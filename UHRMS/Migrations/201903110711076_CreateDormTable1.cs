namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDormTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dorms", "dormtype", c => c.String());
            DropColumn("dbo.Dorms", "dormName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dorms", "dormName", c => c.String());
            DropColumn("dbo.Dorms", "dormtype");
        }
    }
}
