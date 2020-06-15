namespace GigHub2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OvverideConventionforGigsOnceMore1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false));
        }
    }
}
