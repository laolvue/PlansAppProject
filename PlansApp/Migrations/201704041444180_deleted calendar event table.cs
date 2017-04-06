namespace PlansApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedcalendareventtable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CalendarEvents");
        }
        
        public override void Down()
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
    }
}
