namespace PlansApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcalendarEventstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalendarEvents",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        StartAt = c.DateTime(nullable: false),
                        EndAt = c.DateTime(nullable: false),
                        IsFullDay = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalendarEvents");
        }
    }
}
