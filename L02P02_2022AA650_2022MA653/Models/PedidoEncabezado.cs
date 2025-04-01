using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class PedidoEncabezado
    {
        [Key]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int CantidadLibros { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        public ICollection<PedidoDetalle> Detalles { get; set; }
    }
}
