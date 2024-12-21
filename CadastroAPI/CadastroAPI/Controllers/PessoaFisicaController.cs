using CadastroAPI.Application.DTO;
using CadastroAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAPI.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/fisica")]
    public class PessoaFisicaController : Controller
    {
        private readonly IAppServiceFisica _appServiceFisica;

        public PessoaFisicaController(IAppServiceFisica appServiceFisica)
        {
            _appServiceFisica = appServiceFisica;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appServiceFisica.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appServiceFisica.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PessoaFisicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _appServiceFisica.Add(peDTO);
                return Ok("Pessoa Física Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PessoaFisicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _appServiceFisica.Update(peDTO);
                return Ok("Pessoa Física Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaFisicaDTO peDTO)
        {
            try
            {
                if (peDTO == null)
                    return NotFound();

                _appServiceFisica.Remove(peDTO);
                return Ok("Pessoa Física Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
       
    }
}
