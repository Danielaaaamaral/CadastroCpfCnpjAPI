

using Newtonsoft.Json;

namespace CadastroAPI.Application.DTO
{
    public class PessoaFisicaDTO
    {
        [JsonProperty("id")]
        public Guid id { get; set; }
        [JsonProperty("cpf")]
        public string cpf { get; set; }
        [JsonProperty("nome")]
        public string nome { get; set; }
        [JsonProperty("dataNascimento")]
        public DateTime dataNascimento { get; set; }
        [JsonProperty("genero")]
        public string genero { get; set; }
        [JsonProperty("estadoCivil")]
        public string estadoCivil { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
    }
}
