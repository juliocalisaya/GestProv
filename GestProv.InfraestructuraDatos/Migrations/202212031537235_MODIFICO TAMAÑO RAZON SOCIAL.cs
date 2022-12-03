namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MODIFICOTAMAÑORAZONSOCIAL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proveedores", "RazonSocial", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proveedores", "RazonSocial", c => c.String(maxLength: 20));
        }
    }
}
