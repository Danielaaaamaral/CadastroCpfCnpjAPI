using CadastroAPI.Domain.Core.Interfaces.Repositorys;
using CadastroAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryJuridica : RepositoryBase<PessoaJuridica>, IRepositoryPessoaJuridica
    {
        private readonly SqlContext _context;

        public RepositoryJuridica(SqlContext context) : base(context)
        {
            _context = context;
        }
    }

}
