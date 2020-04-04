namespace TAG.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "Count");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Count", c => c.Int(nullable: false));
        }
    }
}
