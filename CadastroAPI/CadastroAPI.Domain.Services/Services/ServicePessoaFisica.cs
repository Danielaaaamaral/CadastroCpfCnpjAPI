

using CadastroAPI.Domain.Core.Interfaces.Repositorys;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Model;

namespace CadastroAPI.Domain.Services.Services
{
    public class ServicePessoaFisica : ServiceBase<PessoaFisica>,IServiceFisica
    {
        public readonly IRepositoryPessoaFisica _repositoryFisica;

        public ServicePessoaFisica(IRepositoryPessoaFisica repositoryFisica):base(repositoryFisica) 
        {
            _repositoryFisica = repositoryFisica;
        }
    }
}
