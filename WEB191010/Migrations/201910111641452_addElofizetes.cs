namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addElofizetes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ugyfels", "Hirlevel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ugyfels", "elofizetesTipus_Dij", c => c.Int(nullable: false));
            AddColumn("dbo.Ugyfels", "elofizetesTipus_IdotartamHonapban", c => c.Int(nullable: false));
            AddColumn("dbo.Ugyfels", "elofizetesTipus_Kedvezmeny", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ugyfels", "elofizetesTipus_Kedvezmeny");
            DropColumn("dbo.Ugyfels", "elofizetesTipus_IdotartamHonapban");
            DropColumn("dbo.Ugyfels", "elofizetesTipus_Dij");
            DropColumn("dbo.Ugyfels", "Hirlevel");
        }
    }
}
