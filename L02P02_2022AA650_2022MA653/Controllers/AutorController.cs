using L02P02_2022AA650_2022MA653.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2022AA650_2022MA653.Controllers
{
    public class AutorController : Controller
    {
        private readonly ClaseContext _context;

        public AutorController(ClaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var autores = _context.autores.ToList();
            return View(autores);
        }

        public IActionResult Seleccionar(int id)
        {
            var autor = _context.autores.FirstOrDefault(a => a.id == id);
            if (autor == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Libro", new { idAutor = id });

        }
    }
}
