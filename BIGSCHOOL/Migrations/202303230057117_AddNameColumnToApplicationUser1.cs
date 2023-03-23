namespace BIGSCHOOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Courses", "Datatime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Datatime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Courses", "DateTime");
        }
    }
}
