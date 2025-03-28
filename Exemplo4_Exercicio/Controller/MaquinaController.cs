using Microsoft.AspNetCore.Mvc;
using Exemplo4_Exercicio.Model;
using Exemplo4_Exercicio.database;
using Microsoft.EntityFrameworkCore;

namespace Exemplo4_Exercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaquinaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MaquinaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Maquina>> Get()
        {
            return await _context.Maquina.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Maquina>> GetById(int id)
        {
            var maquina = await _context.Maquina.FindAsync(id);
            if (maquina == null) return NotFound();
            return maquina;
        }

        [HttpPost]
        public async Task<ActionResult<Maquina>> Post([FromBody] Maquina maquina)
        {
            _context.Maquina.Add(maquina);
            await _context.SaveChangesAsync();
            return maquina;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Maquina>> Put(int id, [FromBody] Maquina maquina)
        {
            var existente = await _context.Maquina.FindAsync(id);
            if (existente == null) return NotFound();

            existente.tipo = maquina.tipo;
            existente.velocidade = maquina.velocidade;
            existente.harddisk = maquina.harddisk;
            existente.placarede = maquina.placarede;
            existente.memoriaram = maquina.memoriaram;
            existente.fk_usuario = maquina.fk_usuario;

            await _context.SaveChangesAsync();
            return existente;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existente = await _context.Maquina.FindAsync(id);
            if (existente == null) return NotFound();

            _context.Maquina.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}