using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class pedido_detalle
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("pedido_encabezado")]
        public int id_pedido { get; set; }
        public pedido_encabezado pedido_encabezado { get; set; }

        [ForeignKey("libros")]
        public int id_libro { get; set; }
        public libros libros { get; set; }

        public DateTime created_at { get; set; }
    }
}
