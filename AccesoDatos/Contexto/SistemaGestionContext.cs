using Microsoft.EntityFrameworkCore;
using Entidades;

namespace AccesoDatos.Contexto
{
    public class SistemaGestionContext : DbContext
    {
        public SistemaGestionContext(DbContextOptions<SistemaGestionContext> options)
            : base(options)
        {
        }

        // DbSets (uno por tabla)
        public DbSet<CategoriaProducto> CategoriasProductos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteDireccion> ClientesDirecciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<ExistenciaInventario> ExistenciasInventario { get; set; }
        public DbSet<ItemOrdenCompra> ItemsOrdenCompra { get; set; }
        public DbSet<ItemOrdenTrabajo> ItemsOrdenTrabajo { get; set; }
        public DbSet<MovimientoInventario> MovimientosInventario { get; set; }
        public DbSet<OrdenCompra> OrdenesCompra { get; set; }
        public DbSet<OrdenTrabajo> OrdenesTrabajo { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ProveedorDireccion> ProveedoresDirecciones { get; set; }
        public DbSet<RecepcionCompra> RecepcionesCompra { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VarianteProducto> VariantesProductos { get; set; }
        public DbSet<ZonaHoraria> ZonasHorarias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}