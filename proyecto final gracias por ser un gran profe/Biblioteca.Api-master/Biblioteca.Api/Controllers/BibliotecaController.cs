#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;
        private Libro Libro;
        private Autor autor;
        private Estudiante estudiante;
        private Prestamo prestamo;

        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        //Libro
        [HttpGet]
        public async Task<ActionResult> ConsultarLibro()
        {
            return Ok(await _context.Libros.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AgregarLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }
        [HttpPut]
        public async Task<ActionResult> ActualizarLibro(Libro libro)
        {
            _context.Update(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }
        [HttpDelete]
        public async Task<ActionResult> EliminarLibro(Libro libro)
        {
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        //Autor
        [HttpGet]
        public async Task<ActionResult> ConsultarAutor()
        {
            return Ok(await _context.Autores.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AgregarAutor(Autor autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
            return Ok(autor);
        }
        [HttpPut]
        public async Task<ActionResult> ActualizarAutor(Autor autor)
        {
            _context.Update(autor);
            await _context.SaveChangesAsync();
            return Ok(autor);
        }
        [HttpDelete]
        public async Task<ActionResult> EliminarAutor(Autor autor)
        {
            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();
            return Ok(autor);
        }

        //Estudiante
        [HttpGet]
        public async Task<ActionResult> ConsultarEstudiante()
        {
            return Ok(await _context.Estudiantes.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AgregarEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }
        [HttpPut]
        public async Task<ActionResult> ActualizarEstudiante(Estudiante estudiante)
        {
            _context.Update(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }
        [HttpDelete]
        public async Task<ActionResult> EliminarEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }

        //Prestamo
        [HttpGet]
        public async Task<ActionResult> ConsultarPrestamo()
        {
            return Ok(await _context.Prestamos.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AgregarPrestamo(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
            return Ok(prestamo);
        }
        [HttpPut]
        public async Task<ActionResult> ActualizarPrestamo(Prestamo prestamo)
        {
            _context.Update(prestamo);
            await _context.SaveChangesAsync();
            return Ok(prestamo);
        }
        [HttpDelete]
        public async Task<ActionResult> EliminarPrestamo(Prestamo prestamo)
        {
            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();
            return Ok(prestamo);
        }

    }
}
