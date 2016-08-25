namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dummy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "DateTtime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "DateTtime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "DateTime");
        }
    }
}
