namespace Workers_EntityFrameork_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElectroWorkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TailorWorkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TailorWorkers");
            DropTable("dbo.ElectroWorkers");
        }
    }
}
