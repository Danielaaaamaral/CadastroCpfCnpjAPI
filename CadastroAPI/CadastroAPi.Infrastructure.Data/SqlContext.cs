

using CadastroAPI.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }


        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}
