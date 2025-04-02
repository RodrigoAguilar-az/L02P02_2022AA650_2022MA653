using L02P02_2022AA650_2022MA653.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2022AA650_2022MA653.Controllers
{
    public class LibroController : Controller
    {
        private readonly ClaseContext _context;

        public LibroController(ClaseContext context)
        {
            _context = context;
        }

        //public IActionResult SeleccionarLibro()
        //{
        //    int idAutor = 1; // ID fijo para prueba

        //    var libros = _context.Libros
        //                         .Where(l => l.id_autor == idAutor)
        //                         .ToList();

        //    var autor = _context.autores.FirstOrDefault(a => a.id == idAutor);

        //    ViewBag.AutorNombre = autor?.autor ?? "Autor Desconocido";

        //    return View(libros);
        //}

        public IActionResult Index(int idAutor)
        {
            var libros = _context.Libros.Where(l => l.id_autor == idAutor).ToList();
            var autor = _context.autores.FirstOrDefault(a => a.id == idAutor);

            ViewBag.Autor = autor?.autor ?? "Desconocido";
            return View(libros);
        }

        public IActionResult Seleccionar(int idLibro)
        {
            var libro = _context.Libros.FirstOrDefault(l => l.id == idLibro);
            if (libro == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Comentarios", new { idLibro = idLibro });
        }

    }
}
