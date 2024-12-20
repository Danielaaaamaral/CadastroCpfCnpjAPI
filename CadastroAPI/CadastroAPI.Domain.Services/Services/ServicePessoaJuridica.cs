
using CadastroAPI.Domain.Core.Interfaces.Repositorys;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Model;


namespace CadastroAPI.Domain.Services.Services
{
    public class ServicePessoaJuridica : ServiceBase<PessoaJuridica>, IServiceJuridica
    {

        public readonly IRepositoryPessoaJuridica _repositoryJuridica;

        public ServicePessoaJuridica(IRepositoryPessoaJuridica repositoryJuridica) : base(repositoryJuridica)
        {
            _repositoryJuridica = repositoryJuridica;
        }
    }
}
