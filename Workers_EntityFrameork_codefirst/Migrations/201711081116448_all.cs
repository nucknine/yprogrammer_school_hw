namespace Workers_EntityFrameork_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PipeWorkers", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PipeWorkers", "Position", c => c.String());
        }
    }
}
