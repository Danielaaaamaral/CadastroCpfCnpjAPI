

using AutoMapper;
using CadastroAPI.Application.DTO;
using CadastroAPI.Domain.Model;

namespace CadastroAPI.Application.Mappers
{
    public class MapperPessoa : Profile
    {
        public MapperPessoa() {
            PessoaMap();
        }
        private void PessoaMap()
        {
            CreateMap<PessoaJuridicaDTO,PessoaJuridica>();
            CreateMap<PessoaFisicaDTO, PessoaFisica>();
        }
    }
}
