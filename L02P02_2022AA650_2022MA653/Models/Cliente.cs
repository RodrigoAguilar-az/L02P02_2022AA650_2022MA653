using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [Required, StringLength(255)]
        public string Apellido { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
        [Required, StringLength(255)]
        public string Direccion { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<PedidoEncabezado> Pedidos { get; set; }
    }
}
