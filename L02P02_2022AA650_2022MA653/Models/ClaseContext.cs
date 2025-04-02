using Microsoft.EntityFrameworkCore;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class ClaseContext: DbContext
    {
        public ClaseContext(DbContextOptions<ClaseContext> options) : base(options) { }
        public DbSet<clientes> Clientes { get; set; }
        public DbSet<autores> autores { get; set; }
        public DbSet<categorias> Categorias { get; set; }
        public DbSet<libros> Libros { get; set; }
        public DbSet<pedido_encabezado> PedidoEncabezados { get; set; }
        public DbSet<pedido_detalle> PedidoDetalles { get; set; }
        public DbSet<comentarios_libros> ComentariosLibros { get; set; }
    }
}
