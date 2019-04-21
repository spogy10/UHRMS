namespace UHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify_Student_Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BoardingApplicationForms", "studentId", "dbo.Students");
            DropIndex("dbo.BoardingApplicationForms", new[] { "studentId" });
            DropPrimaryKey("dbo.BoardingApplicationForms");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.BoardingApplicationForms", "studentId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Students", "studentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.BoardingApplicationForms", "studentId");
            AddPrimaryKey("dbo.Students", "studentId");
            CreateIndex("dbo.BoardingApplicationForms", "studentId");
            AddForeignKey("dbo.BoardingApplicationForms", "studentId", "dbo.Students", "studentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BoardingApplicationForms", "studentId", "dbo.Students");
            DropIndex("dbo.BoardingApplicationForms", new[] { "studentId" });
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.BoardingApplicationForms");
            AlterColumn("dbo.Students", "studentId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.BoardingApplicationForms", "studentId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Students", "studentId");
            AddPrimaryKey("dbo.BoardingApplicationForms", "studentId");
            CreateIndex("dbo.BoardingApplicationForms", "studentId");
            AddForeignKey("dbo.BoardingApplicationForms", "studentId", "dbo.Students", "studentId");
        }
    }
}
