using Newtonsoft.Json;


namespace CadastroAPI.Application.DTO
{
    public class PessoaJuridicaDTO
    {
        [JsonProperty("id")]
        public Guid id { get; set; }
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }
        [JsonProperty("razaoSocial")]
        public string RazaoSocial { get; set; }
        [JsonProperty("dataFundacao")]
        public DateTime DataFundacao { get; set; }
        [JsonProperty("nomeFantasia")]
        public string NomeFantasia { get; set; }
        [JsonProperty("atividadeDesenvolvida")]
        public string AtividadeDesenvolvida { get; set; }
    }
}
