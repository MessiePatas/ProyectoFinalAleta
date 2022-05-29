using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public int Pagina { get; set; }
    }
}
