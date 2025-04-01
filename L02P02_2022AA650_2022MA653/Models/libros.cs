using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class libros
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string url_imagen { get; set; }

        [ForeignKey("autores")]
        public int id_autor { get; set; }
        public autores autores { get; set; }

        [ForeignKey("categorias")]
        public int id_categoria { get; set; }
        public categorias categorias { get; set; }

        public decimal precio { get; set; }
        public char estado { get; set; }
    }
}
