namespace BusinessDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _fixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "Descr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Branches", "Descr");
        }
    }
}
