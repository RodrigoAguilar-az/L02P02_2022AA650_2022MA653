using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class ComentarioLibro
    {
        [Key]
        public int Id { get; set; }
        public int IdLibro { get; set; }
        [Required]
        public string Comentarios { get; set; }
        [Required, StringLength(50)]
        public string Usuario { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("IdLibro")]
        public libros Libro { get; set; }
    }
}
