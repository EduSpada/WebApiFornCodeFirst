using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFornCodeFirst.Data;
using WebApiFornCodeFirst.Model;

namespace WebApiFornCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresByCidadeController : ControllerBase
    {
        private readonly WebApiFornCodeFirstContext _context;

        public FornecedoresByCidadeController(WebApiFornCodeFirstContext context)
        {
            _context = context;
        }

        // GET: api/FornecedoresByCidade
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEndereco()
        {
            return await _context.Endereco.ToListAsync();
        }*/

        // GET: api/FornecedoresByCidade/Cidade
        [HttpGet("{cidade}")]
        public async Task<ActionResult<Endereco>> GetEndereco(string cidade)
        {
            var endereco = await _context.Endereco.FirstOrDefaultAsync(m => m.Cidade == cidade);

            if (endereco == null)
            {
                return NotFound();
            }

            return endereco;
        }

        // PUT: api/FornecedoresByCidade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutEndereco(int id, Endereco endereco)
        {
            if (id != endereco.IdEndereco)
            {
                return BadRequest();
            }

            _context.Entry(endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        // POST: api/FornecedoresByCidade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*[HttpPost]
        public async Task<ActionResult<Endereco>> PostEndereco(Endereco endereco)
        {
            _context.Endereco.Add(endereco);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEndereco", new { id = endereco.IdEndereco }, endereco);
        }*/

        // DELETE: api/FornecedoresByCidade/5
        /*[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEndereco(int id)
        {
            var endereco = await _context.Endereco.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            _context.Endereco.Remove(endereco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnderecoExists(int id)
        {
            return _context.Endereco.Any(e => e.IdEndereco == id);
        }*/
    }
}
