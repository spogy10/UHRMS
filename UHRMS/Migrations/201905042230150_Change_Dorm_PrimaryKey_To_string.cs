namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Dorm_PrimaryKey_To_string : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckInForms", "Dorm_dormId", "dbo.Dorms");
            DropIndex("dbo.CheckInForms", new[] { "Dorm_dormId" });
            DropPrimaryKey("dbo.Dorms");
            AlterColumn("dbo.CheckInForms", "Dorm_dormId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Dorms", "dormId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Dorms", "dormId");
            CreateIndex("dbo.CheckInForms", "Dorm_dormId");
            AddForeignKey("dbo.CheckInForms", "Dorm_dormId", "dbo.Dorms", "dormId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckInForms", "Dorm_dormId", "dbo.Dorms");
            DropIndex("dbo.CheckInForms", new[] { "Dorm_dormId" });
            DropPrimaryKey("dbo.Dorms");
            AlterColumn("dbo.Dorms", "dormId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CheckInForms", "Dorm_dormId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Dorms", "dormId");
            CreateIndex("dbo.CheckInForms", "Dorm_dormId");
            AddForeignKey("dbo.CheckInForms", "Dorm_dormId", "dbo.Dorms", "dormId", cascadeDelete: true);
        }
    }
}
