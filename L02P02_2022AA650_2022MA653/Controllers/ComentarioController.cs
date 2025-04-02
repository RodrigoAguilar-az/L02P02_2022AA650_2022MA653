using L02P02_2022AA650_2022MA653.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace L02P02_2022AA650_2022MA653.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly ClaseContext _context;

        public ComentarioController(ClaseContext context)
        {
            _context = context;
        }
        public IActionResult Index(int idLibro)
        {
            var libro = _context.Libros.FirstOrDefault(l => l.id == idLibro);
            if (libro == null)
            {
                return NotFound();
            }

     
            var autor = _context.autores.FirstOrDefault(a => a.id == libro.id_autor);
            var nombreAutor = autor != null ? autor.autor : "Autor Desconocido";

            var comentarios = _context.ComentariosLibros
                .Where(c => c.id_libro == idLibro)
                .OrderByDescending(c => c.created_at) 
                .ToList();

            ViewBag.Libro = libro.nombre;
            ViewBag.Autor = nombreAutor; 
            ViewBag.LibroId = idLibro;

            return View(comentarios);
        }

        [HttpPost]
        public IActionResult AgregarComentario(int idLibro, string comentarioTexto)
        {
            if (string.IsNullOrWhiteSpace(comentarioTexto))
            {
                TempData["Error"] = "El comentario no puede estar vacío.";
                return RedirectToAction("Index", new { idLibro });
            }

            // para que se elija un nombre
            string[] nombresUsuarios = {
        "Ana García", "Carlos López", "María Rodríguez", "Juan Martínez",
        "Sofía Fernández", "David Sánchez", "Laura González", "Miguel Torres",
        "Elena Ramírez", "Pablo Díaz", "Carmen Pérez", "José Ruiz"
    };

            Random random = new Random();
            int indiceAleatorio = random.Next(0, nombresUsuarios.Length);
            string nombreAleatorio = nombresUsuarios[indiceAleatorio];

            var nuevoComentario = new comentarios_libros
            {
                id_libro = idLibro,
                comentarios = comentarioTexto,
                usuario = nombreAleatorio,
                created_at = DateTime.Now
            };

            _context.ComentariosLibros.Add(nuevoComentario);
            _context.SaveChanges();

            var libro = _context.Libros.FirstOrDefault(l => l.id == idLibro);
            if (libro == null)
            {
                return NotFound();
            }

            var autor = _context.autores.FirstOrDefault(a => a.id == libro.id_autor);
            var nombreAutor = autor != null ? autor.autor : "Autor Desconocido";

            var comentarios = _context.ComentariosLibros
                .Where(c => c.id_libro == idLibro)
                .OrderByDescending(c => c.created_at)
                .ToList();

            ViewBag.Libro = libro.nombre;
            ViewBag.Autor = nombreAutor;
            ViewBag.LibroId = idLibro;

            return View("Comentado", comentarios);
        }



        public IActionResult Comentado(int idLibro)
        {
            var libro = _context.Libros.FirstOrDefault(l => l.id == idLibro);
            if (libro == null)
            {
                return NotFound();
            }

            var autor = _context.autores.FirstOrDefault(a => a.id == libro.id_autor);
            var nombreAutor = autor != null ? autor.autor : "Autor Desconocido";

            var comentarios = _context.ComentariosLibros
                .Where(c => c.id_libro == idLibro)
                .OrderByDescending(c => c.created_at)
                .ToList();

            ViewBag.Libro = libro.nombre;
            ViewBag.Autor = nombreAutor;

            return View(comentarios);
        }


    }
}
