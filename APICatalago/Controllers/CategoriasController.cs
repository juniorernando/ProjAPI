using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjAPI.Context;
using ProjAPI.Models;

namespace ProjAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Produtos")]

        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return _context.Categorias.Include(x => x.Produtos).ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return _context.Categorias.ToList();
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]

        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada");
            }

            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult Post ( Categoria categoria)
        {
            if(categoria is null)
            
                return BadRequest("Categoria inválida");
            
            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("Categoria inválida");
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Categoria> Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada");
            }

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return categoria;
        }
        
    }
}
