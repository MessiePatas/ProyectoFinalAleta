using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Autor
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Libros { get; set; }
        public string Categoria { get; set; }
    }
}
