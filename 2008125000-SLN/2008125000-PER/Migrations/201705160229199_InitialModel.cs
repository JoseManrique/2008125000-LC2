namespace _2008125000_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServicioTuristicoes",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false, identity: true),
                        nombreServicio = c.String(),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServicioTuristicoes");
        }
    }
}
