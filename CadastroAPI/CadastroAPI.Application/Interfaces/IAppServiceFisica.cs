

using CadastroAPI.Application.DTO;

namespace CadastroAPI.Application.Interfaces
{
    public interface IAppServiceFisica
    {
        void Add(PessoaFisicaDTO obj);

        PessoaFisicaDTO GetById(int id);

        IEnumerable<PessoaFisicaDTO> GetAll();

        void Update(PessoaFisicaDTO obj);

        void Remove(PessoaFisicaDTO obj);

        void Dispose();
    }
}
