namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevocampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proveedores", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proveedores", "Estado");
        }
    }
}
