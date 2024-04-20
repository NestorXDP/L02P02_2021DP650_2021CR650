using System.ComponentModel.DataAnnotations;

namespace L02P02_2021DP650_2021CR650.Models
{
    public class autores
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de autor")]
        public string? autor { get; set; }
    }
}
