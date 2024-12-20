

using CadastroAPI.Application.DTO;

namespace CadastroAPI.Application.Interfaces
{
    public interface IAppServiceJuridica
    {

        void Add(PessoaJuridicaDTO obj);

        PessoaJuridicaDTO GetById(int id);

        IEnumerable<PessoaJuridicaDTO> GetAll();

        void Update(PessoaJuridicaDTO obj);

        void Remove(PessoaJuridicaDTO obj);

        void Dispose();
    }
}
