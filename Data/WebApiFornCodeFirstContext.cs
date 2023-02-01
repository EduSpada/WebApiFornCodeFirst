
using Microsoft.EntityFrameworkCore;
using WebApiFornCodeFirst.Model;

namespace WebApiFornCodeFirst.Data
{
    public class WebApiFornCodeFirstContext : DbContext
    {
        public WebApiFornCodeFirstContext (DbContextOptions<WebApiFornCodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedor { get; set; } = default!;

        public DbSet<Endereco> Endereco { get; set; }

    }
}
