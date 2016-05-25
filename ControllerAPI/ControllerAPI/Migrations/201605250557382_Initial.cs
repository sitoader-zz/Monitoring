namespace ControllerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hosts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IP = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Controllers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IP = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Controllers");
            DropTable("dbo.Hosts");
        }
    }
}