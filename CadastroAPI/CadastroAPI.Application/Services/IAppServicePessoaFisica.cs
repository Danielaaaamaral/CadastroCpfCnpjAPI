using AutoMapper;
using CadastroAPI.Application.DTO;
using CadastroAPI.Application.Interfaces;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Model;


namespace CadastroAPI.Application.Services
{
    public class IAppServicePessoaFisica : IAppServiceFisica
    {
        private readonly IServiceFisica _serviceFisica;
        private readonly IMapper mapper;

        public IAppServicePessoaFisica(IServiceFisica serviceFisica, IMapper mapper)
        {
            _serviceFisica = serviceFisica;
            this.mapper = mapper;
        }

        public void Add(PessoaFisicaDTO obj)
        {
            var pessoaf = mapper.Map<PessoaFisica>(obj);
            _serviceFisica.Add(pessoaf);
        }

        public void Dispose()
        {
            _serviceFisica.Dispose();
        }

        public IEnumerable<PessoaFisicaDTO> GetAll()
        {
            var pefisica= _serviceFisica.GetAll();
            var pefisicaDto= mapper.Map<IEnumerable<PessoaFisicaDTO>>(pefisica);
            return pefisicaDto;
        }

        public PessoaFisicaDTO GetById(int id)
        {
            var p=_serviceFisica.GetById(id);
            var pDto=mapper.Map<PessoaFisicaDTO>(p);
            return pDto;
        }

        public void Remove(PessoaFisicaDTO obj)
        {
            var pe = mapper.Map<PessoaFisica>(obj);
            _serviceFisica.Remove(pe);
        }

        public void Update(PessoaFisicaDTO obj)
        {
           var pe= mapper.Map<PessoaFisica>(obj);
            _serviceFisica.Update(pe);
        }
    }
}
