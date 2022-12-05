namespace GestProv.InfraestructuraDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class muchos_a_uno : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipamientos", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Equipamientos", new[] { "Categoria_Id" });
            AlterColumn("dbo.Equipamientos", "Categoria_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Equipamientos", "Categoria_Id");
            AddForeignKey("dbo.Equipamientos", "Categoria_Id", "dbo.Categorias", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipamientos", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Equipamientos", new[] { "Categoria_Id" });
            AlterColumn("dbo.Equipamientos", "Categoria_Id", c => c.Long());
            CreateIndex("dbo.Equipamientos", "Categoria_Id");
            AddForeignKey("dbo.Equipamientos", "Categoria_Id", "dbo.Categorias", "Id");
        }
    }
}
