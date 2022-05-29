using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Estudiante
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public int Prestamos { get; set; }
    }
}