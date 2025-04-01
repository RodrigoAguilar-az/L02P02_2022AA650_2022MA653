using System.ComponentModel.DataAnnotations;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class autores
    {
        [Key]
        public int id { get; set; }
        public string autor { get; set; }
    }
}
