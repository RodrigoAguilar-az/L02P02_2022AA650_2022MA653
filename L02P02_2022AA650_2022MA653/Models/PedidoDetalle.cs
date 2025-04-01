using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdLibro { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("IdPedido")]
        public PedidoEncabezado PedidoEncabezado { get; set; }
        [ForeignKey("IdLibro")]
        public Libro Libro { get; set; }
    }
}
