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
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.categorias.Add(categoria);
                _context.SaveChanges();
                    TempData["sucess"] = "Categoria Criada com Sucesso!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var categorias = _context.categorias.Find(id);
            if (categorias == null)
                return NotFound();
            return View(categorias);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.categorias.Update(categoria);
                _context.SaveChanges();
                    TempData["sucess"] = "Categoria Editada com Sucesso!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var categorias = _context.categorias.Find(id);
            if (categorias == null)
                return NotFound();
            return View(categorias);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {
            var categorias = _context.categorias.Find(id);
            if (categorias == null)
                return NotFound();
            _context.categorias.Remove(categorias);
            _context.SaveChanges();
                TempData["sucess"] = "Categoria Deletada com Sucesso!";
            return RedirectToAction("Index");
        }
    }
}
