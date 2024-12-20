using CadastroAPI.Domain.Core.Interfaces.Repositorys;
using CadastroAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryFisica :RepositoryBase<PessoaFisica>,IRepositoryPessoaFisica
    {
        private readonly SqlContext _context;

        public RepositoryFisica(SqlContext context):base(context)
        {
            _context = context;
        }
    }
}
