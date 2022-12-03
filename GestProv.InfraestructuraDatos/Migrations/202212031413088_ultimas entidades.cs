namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultimasentidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FechaCompra = c.String(maxLength: 10),
                        Monto = c.Double(nullable: false),
                        FechaEstimadaEntrega = c.String(maxLength: 10),
                        FechaRealEntrega = c.String(maxLength: 10),
                        Factura = c.String(maxLength: 60),
                        Proveedor_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedores", t => t.Proveedor_Id)
                .Index(t => t.Proveedor_Id);
            
            CreateTable(
                "dbo.Equipamientos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                        DiasGarantia = c.Long(nullable: false),
                        Categoria_Id = c.Long(),
                        Compra_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .ForeignKey("dbo.Compras", t => t.Compra_Id)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Compra_Id);
            
            CreateTable(
                "dbo.OrdenesDeServicio",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 45),
                        FechaSolicitud = c.String(maxLength: 10),
                        FechaEstimadaResolucion = c.String(maxLength: 10),
                        FechaRealResolucion = c.String(maxLength: 10),
                        Tecnico_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tecnicos", t => t.Tecnico_Id)
                .Index(t => t.Tecnico_Id);
            
            CreateTable(
                "dbo.Sucursales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NombreCalle = c.String(maxLength: 50),
                        Altura = c.String(maxLength: 50),
                        Piso = c.String(maxLength: 45),
                        Telefono = c.String(maxLength: 30),
                        Mail = c.String(maxLength: 50),
                        Ciudad_Id = c.Long(),
                        Proveedor_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciudades", t => t.Ciudad_Id)
                .ForeignKey("dbo.Proveedores", t => t.Proveedor_Id)
                .Index(t => t.Ciudad_Id)
                .Index(t => t.Proveedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sucursales", "Proveedor_Id", "dbo.Proveedores");
            DropForeignKey("dbo.Sucursales", "Ciudad_Id", "dbo.Ciudades");
            DropForeignKey("dbo.OrdenesDeServicio", "Tecnico_Id", "dbo.Tecnicos");
            DropForeignKey("dbo.Equipamientos", "Compra_Id", "dbo.Compras");
            DropForeignKey("dbo.Equipamientos", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Compras", "Proveedor_Id", "dbo.Proveedores");
            DropIndex("dbo.Sucursales", new[] { "Proveedor_Id" });
            DropIndex("dbo.Sucursales", new[] { "Ciudad_Id" });
            DropIndex("dbo.OrdenesDeServicio", new[] { "Tecnico_Id" });
            DropIndex("dbo.Equipamientos", new[] { "Compra_Id" });
            DropIndex("dbo.Equipamientos", new[] { "Categoria_Id" });
            DropIndex("dbo.Compras", new[] { "Proveedor_Id" });
            DropTable("dbo.Sucursales");
            DropTable("dbo.OrdenesDeServicio");
            DropTable("dbo.Equipamientos");
            DropTable("dbo.Compras");
            DropTable("dbo.Categorias");
        }
    }
}
