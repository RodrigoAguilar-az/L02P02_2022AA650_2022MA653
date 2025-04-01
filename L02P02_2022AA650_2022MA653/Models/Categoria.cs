using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Nombre { get; set; }
        public ICollection<libros> Libros { get; set; }
    }
}
