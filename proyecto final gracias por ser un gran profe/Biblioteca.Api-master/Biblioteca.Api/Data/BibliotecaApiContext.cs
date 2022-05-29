#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Data
{
    public class BibliotecaApiContext : DbContext
    {
        public BibliotecaApiContext (DbContextOptions<BibliotecaApiContext> options)
            : base(options)
        {
        }

        public DbSet<Biblioteca.Api.Modelo.Libro> Libros { get; set; }
        public DbSet<Biblioteca.Api.Modelo.Autor> Autores { get; set; }
        public DbSet<Biblioteca.Api.Modelo.Estudiante> Estudiantes { get; set; }
        public DbSet<Biblioteca.Api.Modelo.Prestamo> Prestamos { get; set; }

    }
}
