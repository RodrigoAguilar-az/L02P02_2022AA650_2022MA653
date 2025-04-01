using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class pedido_encabezado
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("clientes")]
        public int id_cliente { get; set; }
        public clientes clientes { get; set; }

        public int cantidad_libros { get; set; }
        public decimal total { get; set; }
    }
}
