using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class comentarios_libros
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("libros")]
        public int id_libro { get; set; }
        public libros libros { get; set; }

        public string comentarios { get; set; }
        public string usuario { get; set; }
        public DateTime created_at { get; set; }
    }
}
