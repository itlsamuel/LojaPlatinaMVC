using LojaPlatinaMVC.Data;
using LojaPlatinaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaPlatinaMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private AplicacaoDbContext _context;

        public CategoriaController(AplicacaoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> categorias = _context.categorias;
            return View(categorias);
        }
    }
}
