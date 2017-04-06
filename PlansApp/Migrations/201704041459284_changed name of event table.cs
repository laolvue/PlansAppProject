namespace PlansApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changednameofeventtable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Events", newName: "Eventfuls");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Eventfuls", newName: "Events");
        }
    }
}
