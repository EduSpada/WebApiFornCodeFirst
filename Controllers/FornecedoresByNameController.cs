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
    public class FornecedoresByNameController : ControllerBase
    {
        private readonly WebApiFornCodeFirstContext _context;

        public FornecedoresByNameController(WebApiFornCodeFirstContext context)
        {
            _context = context;
        }

        // GET: api/FornecedoresByName
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedor()
        {
            return await _context.Fornecedor.ToListAsync();
        }

        // GET: api/FornecedoresByName/Name
        [HttpGet("{name}")]
        public async Task<ActionResult<Fornecedor>> GetFornecedor(string name)
        {
            var fornecedor = await _context.Fornecedor.FirstOrDefaultAsync(m => m.Name == name);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return fornecedor;
        }

        // PUT: api/FornecedoresByName/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(int id, Fornecedor fornecedor)
        {
            if (id != fornecedor.IdFornecedor)
            {
                return BadRequest();
            }

            _context.Entry(fornecedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FornecedoresByName
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fornecedor>> PostFornecedor(Fornecedor fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFornecedor", new { id = fornecedor.IdFornecedor }, fornecedor);
        }

        // DELETE: api/FornecedoresByName/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFornecedor(int id)
        {
            var fornecedor = await _context.Fornecedor.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            _context.Fornecedor.Remove(fornecedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FornecedorExists(int id)
        {
            return _context.Fornecedor.Any(e => e.IdFornecedor == id);
        }
    }
}
