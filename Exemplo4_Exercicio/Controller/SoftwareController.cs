using Microsoft.AspNetCore.Mvc;
using Exemplo4_Exercicio.Model;
using Exemplo4_Exercicio.database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Exemplo4_Exercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftwareController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SoftwareController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Software>> Get()
        {
            return await _context.Software.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Software>> GetById(int id)
        {
            var software = await _context.Software.FindAsync(id);
            if (software == null) return NotFound();
            return software;
        }

        [HttpPost]
        public async Task<ActionResult<Software>> Post([FromBody] Software software)
        {
            _context.Software.Add(software);
            await _context.SaveChangesAsync();
            return software;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Software>> Put(int id, [FromBody] Software software)
        {
            var existente = await _context.Software.FindAsync(id);
            if (existente == null) return NotFound();

            existente.produto = software.produto;
            existente.harddisk = software.harddisk;
            existente.memoriaram = software.memoriaram;
            existente.id_maquina = software.id_maquina;

            await _context.SaveChangesAsync();
            return existente;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existente = await _context.Software.FindAsync(id);
            if (existente == null) return NotFound();

            _context.Software.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}