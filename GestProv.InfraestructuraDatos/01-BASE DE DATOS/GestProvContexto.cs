using GestProv.Dominio._01_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProv.InfraestructuraDatos._01_BASE_DE_DATOS
{
    public class GestProvContexto : DbContext
    {
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<OrdenDeServicio> OrdenesDeServicio { get; set; }
        public DbSet<Equipamiento> Equipamientos { get; set; }
        public GestProvContexto() : base("name=GestProv")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            //TABLA PROVEEDORES------------------------------------------------------

            modelBuilder
                .Entity<Proveedor>()
                .ToTable("Proveedores");

            modelBuilder
                .Entity<Proveedor>()
                .ToTable("Proveedores")
                .Property(d => d.NombreyApellido).HasMaxLength(50);

            modelBuilder
                .Entity<Proveedor>()
                .ToTable("Proveedores")
                .Property(d => d.RazonSocial).HasMaxLength(50);

            modelBuilder
                .Entity<Proveedor>()
                .ToTable("Proveedores")
                .Property(d => d.CUIT).HasMaxLength(15);

            //TABLA TECNICOS------------------------------------------------------

            modelBuilder
                .Entity<Tecnico>()
                .ToTable("Tecnicos")
                .Property(d => d.Nombre).HasMaxLength(50);

            modelBuilder
                .Entity<Tecnico>()
                .ToTable("Tecnicos")
                .Property(d => d.Apellido).HasMaxLength(50);

            modelBuilder
                .Entity<Tecnico>()
                .ToTable("Tecnicos")
                .Property(d => d.DNI).HasMaxLength(12);

            modelBuilder
                .Entity<Tecnico>()
                .ToTable("Tecnicos")
                .Property(d => d.Mail).HasMaxLength(50);

            modelBuilder
                .Entity<Tecnico>()
                .ToTable("Tecnicos")
                .Property(d => d.Telefono).HasMaxLength(30);

            //TABLA PAISES------------------------------------------------------

            modelBuilder
                .Entity<Pais>()
                .ToTable("Paises");

            modelBuilder
                .Entity<Pais>()
                .ToTable("Paises")
                .Property(d => d.Nombre).HasMaxLength(50);

            //TABLA PROVINCIAS------------------------------------------------------

            modelBuilder
                .Entity<Provincia>()
                .ToTable("Provincias");

            modelBuilder
                .Entity<Provincia>()
                .ToTable("Provincias")
                .Property(d => d.Nombre).HasMaxLength(50);

            //TABLA CIUDADES------------------------------------------------------

            modelBuilder
                .Entity<Ciudad>()
                .ToTable("Ciudades");

            modelBuilder
                .Entity<Ciudad>()
                .ToTable("Ciudades")
                .Property(d => d.Nombre).HasMaxLength(50);

            //TABLA SUCURSALES------------------------------------------------------

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales");

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .Property(d => d.NombreCalle).HasMaxLength(50);

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .Property(d => d.Altura).HasMaxLength(50);

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .Property(d => d.Piso).HasMaxLength(45);

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .Property(d => d.Telefono).HasMaxLength(30);

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .Property(d => d.Mail).HasMaxLength(50);

            modelBuilder
                .Entity<Sucursal>()
                .ToTable("Sucursales")
                .HasRequired(x => x.Proveedor)
                .WithMany(c => c.Sucursales)
                .WillCascadeOnDelete(true);

            //TABLA CATEGORIAS------------------------------------------------------

            modelBuilder
                .Entity<Categoria>()
                .ToTable("Categorias");

            modelBuilder
                .Entity<Categoria>()
                .ToTable("Categorias")
                .Property(d => d.Nombre).HasMaxLength(50);

            //TABLA COMPRAS------------------------------------------------------

            modelBuilder
                .Entity<Compra>()
                .ToTable("Compras");

            modelBuilder
                .Entity<Compra>()
                .ToTable("Compras")
                .Property(d => d.FechaCompra).HasMaxLength(10);

            modelBuilder
                .Entity<Compra>()
                .ToTable("Compras")
                .Property(d => d.FechaEstimadaEntrega).HasMaxLength(10);

            modelBuilder
                .Entity<Compra>()
                .ToTable("Compras")
                .Property(d => d.FechaRealEntrega).HasMaxLength(10);

            modelBuilder
                .Entity<Compra>()
                .ToTable("Compras")
                .Property(d => d.Factura).HasMaxLength(60);

            //TABLA ORDENES DE SERVICIO------------------------------------------

            modelBuilder
                .Entity<OrdenDeServicio>()
                .ToTable("OrdenesDeServicio");

            modelBuilder
                .Entity<OrdenDeServicio>()
                .ToTable("OrdenesDeServicio")
                .Property(d => d.Descripcion).HasMaxLength(45);

            modelBuilder
                .Entity<OrdenDeServicio>()
                .ToTable("OrdenesDeServicio")
                .Property(d => d.FechaSolicitud).HasMaxLength(10);

            modelBuilder
                .Entity<OrdenDeServicio>()
                .ToTable("OrdenesDeServicio")
                .Property(d => d.FechaEstimadaResolucion).HasMaxLength(10);

            modelBuilder
                .Entity<OrdenDeServicio>()
                .ToTable("OrdenesDeServicio")
                .Property(d => d.FechaRealResolucion).HasMaxLength(10);

            //TABLA EQUIPAMIENTOS------------------------------------------------------

            modelBuilder
                .Entity<Equipamiento>()
                .ToTable("Equipamientos");


            modelBuilder
                .Entity<Equipamiento>()
                .ToTable("Equipamientos")
                .HasRequired(x => x.Categoria);

            modelBuilder
                .Entity<Equipamiento>()
                .ToTable("Equipamientos")
                .Property(d => d.Nombre).HasMaxLength(50);

            modelBuilder
                .Entity<Equipamiento>()
                .ToTable("Equipamientos")
                .HasRequired(x => x.Compra)
                .WithMany(c => c.Equipamientos)
                .WillCascadeOnDelete(true);


        }


        // EVENTOS -------------------------------------------------------------------------------
        public void GuardarCambios()
        {
            SaveChanges();
        }

        //TABLA PROVEEDORES------------------------------------------------------
        public List<Proveedor> ObtenerProveedores()
        {
            return Proveedores.ToList();
        }

        public List<Proveedor> ObtenerProveedoresActivos()
        {
            return Proveedores.Where(x => x.Estado.Equals(true)).OrderBy(c => c.NombreyApellido).ToList();
        }
        public void AltaProveedor(Proveedor proveedor)
        {
            Proveedores.Add(proveedor);
        }

        //TABLA TECNICOS------------------------------------------------------
        public List<Tecnico> ObtenerTecnicos()
        {
            return Tecnicos.ToList();
        }

        public List<Tecnico> ObtenerTecnicosActivos()
        {
            return Tecnicos.Where(x => x.Estado.Equals(true)).ToList();
        }
        public void AltaTecnico(Tecnico tecnico)
        {
            Tecnicos.Add(tecnico);
        }

        //TABLA PAISES------------------------------------------------------

        public List<Pais> ObtenerPaises()
        {
            return Paises.OrderBy(x => x.Nombre).ToList();
        }

        //TABLA PROVINCIAS------------------------------------------------------

        public List<Provincia> ObtenerProvincias(Pais pais)
        {
            return Provincias.Where(c => c.Pais.Id.Equals(pais.Id)).OrderBy(x => x.Nombre).ToList();
        }

        //TABLA CIUDADES------------------------------------------------------

        public List<Ciudad> ObtenerCiudades(Provincia provincia)
        {
            return Ciudades.Where(x => x.Provincia.Id.Equals(provincia.Id)).OrderBy(x => x.Nombre).ToList();
        }

        //TABLA SUCURSALES------------------------------------------------------

        public List<Sucursal> ObtenerSucursales(Proveedor proveedor)
        {
            return Sucursales.Where(c => c.Proveedor.Id.Equals(proveedor.Id)).ToList();
        }
        public void AltaSucursal(Sucursal sucursal)
        {
            Sucursales.Add(sucursal);
        }
        public void BajaSucursal(Sucursal sucursal)
        {
            Sucursales.Remove(sucursal);
            GuardarCambios();
        }
        //TABLA CATEGORIAS------------------------------------------------------

        public List<Categoria> ObtenerCategorias()
        {
            return Categorias.ToList();
        }

        //TABLA COMPRAS------------------------------------------------------

        public List<Compra> ObtenerCompras()
        {
            return Compras.ToList();
        }
        public void AltaCompra(Compra compra)
        {
            Compras.Add(compra);
        }


        public void BajaCompra(Compra objetivo)
        {
            Compras.Remove(objetivo);
            SaveChanges();
        }


        //TABLA ODERNES DE SERVICIO---------------------------------------------

        public List<OrdenDeServicio> ObtenerOrdenesServicio()
        {
            return OrdenesDeServicio.ToList();
        }
        public void AltaOrdenDeServicio(OrdenDeServicio orden)
        {
            OrdenesDeServicio.Add(orden);
        }
        public void BajaOrdenDeServicio(OrdenDeServicio orden)
        {
            OrdenesDeServicio.Remove(orden);
            GuardarCambios();
        }

        //TABLA EQUIPAMIENTO------------------------------------------------------

        public List<Equipamiento> ObtenerEquipamientos()
        {
            return Equipamientos.ToList();
        }

        public List<Equipamiento> ObtenerEquipamientosDeCompra(Compra compra)
        {
            return Compras.Find(compra.Id).Equipamientos;
        }

        public Equipamiento AltaEquipamiento(Equipamiento nuevo)
        {
            Equipamiento agregado = Equipamientos.Add(nuevo);
            SaveChanges();
            return agregado; 
        }

    }
}
