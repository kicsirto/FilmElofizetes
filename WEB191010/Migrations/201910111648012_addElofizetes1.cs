namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addElofizetes1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElofizetesTipus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dij = c.Int(nullable: false),
                        IdotartamHonapban = c.Int(nullable: false),
                        Kedvezmeny = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Ugyfels", "elofizetesTipus_Id", c => c.Int());
            CreateIndex("dbo.Ugyfels", "elofizetesTipus_Id");
            AddForeignKey("dbo.Ugyfels", "elofizetesTipus_Id", "dbo.ElofizetesTipus", "Id");
            DropColumn("dbo.Ugyfels", "elofizetesTipus_Dij");
            DropColumn("dbo.Ugyfels", "elofizetesTipus_IdotartamHonapban");
            DropColumn("dbo.Ugyfels", "elofizetesTipus_Kedvezmeny");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ugyfels", "elofizetesTipus_Kedvezmeny", c => c.String());
            AddColumn("dbo.Ugyfels", "elofizetesTipus_IdotartamHonapban", c => c.Int(nullable: false));
            AddColumn("dbo.Ugyfels", "elofizetesTipus_Dij", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ugyfels", "elofizetesTipus_Id", "dbo.ElofizetesTipus");
            DropIndex("dbo.Ugyfels", new[] { "elofizetesTipus_Id" });
            DropColumn("dbo.Ugyfels", "elofizetesTipus_Id");
            DropTable("dbo.ElofizetesTipus");
        }
    }
}
