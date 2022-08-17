namespace BusinessDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        DurationStart = c.DateTime(nullable: false),
                        DurationEnd = c.DateTime(nullable: false),
                        PreparationDate = c.DateTime(),
                        Requestor = c.Int(nullable: false),
                        ResponsiblePerson = c.Int(nullable: false),
                        ResponsibleDirector = c.Int(),
                        UnitManager = c.Int(),
                        BranchId = c.Int(),
                        DirectorateId = c.Int(),
                        ComponentId = c.Int(),
                        Comment = c.String(),
                        DesignationId = c.Int(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        EmailAddress = c.String(),
                        MobileNumber = c.String(),
                        OfficeNumber = c.String(),
                        DirectorateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        VenueId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VenueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "BranchId", "dbo.Branches");
            DropIndex("dbo.Bookings", new[] { "BranchId" });
            DropTable("dbo.Venues");
            DropTable("dbo.Persons");
            DropTable("dbo.Branches");
            DropTable("dbo.Bookings");
        }
    }
}
