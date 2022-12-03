namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pruebaentidadesnuevas2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paises");
        }
    }
}
