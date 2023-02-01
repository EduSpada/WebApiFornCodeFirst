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
    public class FornecedoresByCnpjController : ControllerBase
    {
        private readonly WebApiFornCodeFirstContext _context;

        public FornecedoresByCnpjController(WebApiFornCodeFirstContext context)
        {
            _context = context;
        }

        // GET: api/FornecedoresByCnpj/cnpj
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<Fornecedor>> Get(string cnpj)
        {
            var fornecedor = await _context.Fornecedor.FirstOrDefaultAsync(m => m.Cnpj == cnpj);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return fornecedor;
        }

        private bool FornecedorExists(int id)
        {
            return _context.Fornecedor.Any(e => e.IdFornecedor == id);
        }
    }
}
