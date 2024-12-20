using AutoMapper;
using CadastroAPI.Application.DTO;
using CadastroAPI.Application.Interfaces;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Model;


namespace CadastroAPI.Application.Services
{
    public class IAppServicePessoaJuridica :IAppServiceJuridica
    {
        private readonly IServiceJuridica _serviceJuridica;
        private readonly IMapper mapper;

        public IAppServicePessoaJuridica(IServiceJuridica serviceJuridica, IMapper mapper)
        {
            _serviceJuridica = serviceJuridica;
            this.mapper = mapper;
        }

        public void Add(PessoaJuridicaDTO obj)
        {
            var pessoaf = mapper.Map<PessoaJuridica>(obj);
            _serviceJuridica.Add(pessoaf);
        }

        public void Dispose()
        {
            _serviceJuridica.Dispose();
        }

        public IEnumerable<PessoaJuridicaDTO> GetAll()
        {
            var pe = _serviceJuridica.GetAll();
            var peDto = mapper.Map<IEnumerable<PessoaJuridicaDTO>>(pe);
            return peDto;
        }

        public PessoaJuridicaDTO GetById(int id)
        {
            var p = _serviceJuridica.GetById(id);
            var pDto = mapper.Map<PessoaJuridicaDTO>(p);
            return pDto;
        }

        public void Remove(PessoaJuridicaDTO obj)
        {
            var pe = mapper.Map<PessoaJuridica>(obj);
            _serviceJuridica.Remove(pe);
        }

        public void Update(PessoaJuridicaDTO obj)
        {
            var pe = mapper.Map<PessoaJuridica>(obj);
            _serviceJuridica.Update(pe);
        }
    }
}
