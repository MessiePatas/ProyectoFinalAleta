using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Prestamo
    {
        [Key]
        public int Numero { get; set; }
        public string Libro { get; set; }
        public string Estudiante { get; set; }
        public int iDestudiante { get; set; }
        public int Fecha { get; set; }
    }
}