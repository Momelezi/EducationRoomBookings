namespace BusinessDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedBrachColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Branches", "Descr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Branches", "Descr", c => c.String());
        }
    }
}
