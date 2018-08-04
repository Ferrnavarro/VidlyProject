namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnameinMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MyProperty", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
