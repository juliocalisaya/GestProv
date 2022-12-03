namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadesnuevas2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ciudades", "IdProvincia");
            DropColumn("dbo.Provincias", "IdPais");
            DropColumn("dbo.Tecnicos", "IdProveedor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tecnicos", "IdProveedor", c => c.Long(nullable: false));
            AddColumn("dbo.Provincias", "IdPais", c => c.Long(nullable: false));
            AddColumn("dbo.Ciudades", "IdProvincia", c => c.Long(nullable: false));
        }
    }
}
