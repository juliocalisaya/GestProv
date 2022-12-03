namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaEntidadProveedor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NombreyApellido = c.String(maxLength: 50),
                        RazonSocial = c.String(maxLength: 20),
                        CUIT = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedores");
        }
    }
}
