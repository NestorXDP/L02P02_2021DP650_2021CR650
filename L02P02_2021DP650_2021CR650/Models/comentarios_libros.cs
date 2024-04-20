using System.ComponentModel.DataAnnotations;

namespace L02P02_2021DP650_2021CR650.Models
{
    public class comentarios_libros
    {
       
        public int id { get; set; }
        public int id_libro {  get; set; }
        public string? comentarios {  get; set; }
        public string? usuario { get; set; }
        public DateTime? create_at { get; set; }



    }
}
