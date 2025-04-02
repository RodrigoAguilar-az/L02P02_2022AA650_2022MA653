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

            var comentarios = _context.ComentariosLibros
                .Where(c => c.id_libro == idLibro)
                .ToList();

            ViewBag.Libro = libro.nombre;
            ViewBag.Autor = libro.nombre;

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

            var nuevoComentario = new comentarios_libros
            {
                id_libro = idLibro,
                comentarios = comentarioTexto,
                usuario = "Usuario Demo",
                created_at = DateTime.Now
            };

            _context.ComentariosLibros.Add(nuevoComentario);
            _context.SaveChanges();

            return RedirectToAction("Index", new { idLibro });
        }
    }
}
