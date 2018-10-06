using System;
using System.Data.Entity.Migrations;

namespace ClientProgram.Migrations
{   
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Client_Id = c.Int(nullable: false, identity: true),
                        Client_Code = c.Int(nullable: false),
                        Client_Name = c.String(nullable: false),
                        Client_City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
