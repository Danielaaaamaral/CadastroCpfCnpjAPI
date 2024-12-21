using AutoMapper;
using CadastroAPI.Application.DTO;
using CadastroAPI.Application.Interfaces;
using CadastroAPI.Domain.Core.Interfaces.Services;
using CadastroAPI.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAPI.Controllers
{
    [ApiController]
    [Route("api/juridica")]
    public class PessoaJuridicaController : Controller
    {
        private readonly IAppServiceJuridica _serviceJuridica;
        private readonly IMapper mapper;

        public PessoaJuridicaController(IAppServiceJuridica appServiceJuridica)
        {
            _serviceJuridica = appServiceJuridica;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_serviceJuridica.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_serviceJuridica.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PessoaJuridicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _serviceJuridica.Add(peDTO);
                return Ok("Pessoa Jurídica Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PessoaJuridicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _serviceJuridica.Update(peDTO);
                return Ok("Pessoa Jurídica Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaJuridicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _serviceJuridica.Remove(peDTO);
                return Ok("Pessoa Jurídica Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
       
    }
}
