using Microsoft.EntityFrameworkCore;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class ClaseContext: DbContext
    {
        public ClaseContext(DbContextOptions<ClaseContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<PedidoEncabezado> PedidoEncabezados { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<ComentarioLibro> ComentariosLibros { get; set; }
    }
}
