

namespace CadastroAPI.Domain.Model
{
    public class PessoaJuridica : PessoaBase
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DataFundacao { get; set; }
        public string NomeFantasia { get; set; }
        public string AtividadeDesenvolvida { get; set; }

        public PessoaJuridica(string cnpj, string razaoSocial, DateTime dataFundacao, string nomeFantasia, string atividadeDesenvolvida)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            DataFundacao = dataFundacao;
            NomeFantasia = nomeFantasia;
            AtividadeDesenvolvida = atividadeDesenvolvida;
        }
    }
}
