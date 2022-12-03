namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadesnuevas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                        CodPostal = c.Long(nullable: false),
                        IdProvincia = c.Long(nullable: false),
                        Provincia_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provincias", t => t.Provincia_Id)
                .Index(t => t.Provincia_Id);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                        IdPais = c.Long(nullable: false),
                        Pais_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paises", t => t.Pais_Id)
                .Index(t => t.Pais_Id);
            
            CreateTable(
                "dbo.Tecnicos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                        Apellido = c.String(maxLength: 50),
                        DNI = c.String(maxLength: 12),
                        Mail = c.String(maxLength: 50),
                        Telefono = c.String(maxLength: 30),
                        IdProveedor = c.Long(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Proveedor_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedores", t => t.Proveedor_Id)
                .Index(t => t.Proveedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tecnicos", "Proveedor_Id", "dbo.Proveedores");
            DropForeignKey("dbo.Ciudades", "Provincia_Id", "dbo.Provincias");
            DropForeignKey("dbo.Provincias", "Pais_Id", "dbo.Paises");
            DropIndex("dbo.Tecnicos", new[] { "Proveedor_Id" });
            DropIndex("dbo.Provincias", new[] { "Pais_Id" });
            DropIndex("dbo.Ciudades", new[] { "Provincia_Id" });
            DropTable("dbo.Tecnicos");
            DropTable("dbo.Provincias");
            DropTable("dbo.Ciudades");
        }
    }
}
