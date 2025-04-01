using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(255)]
        public string UrlImagen { get; set; }
        public int IdAutor { get; set; }
        public int IdCategoria { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public char Estado { get; set; }

        [ForeignKey("IdAutor")]
        public Autor Autor { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
        public ICollection<ComentarioLibro> Comentarios { get; set; }
    }
}
