using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class categorias
    {
        [Key]
        public int id { get; set; }
        public string categoria { get; set; }
    }
}
