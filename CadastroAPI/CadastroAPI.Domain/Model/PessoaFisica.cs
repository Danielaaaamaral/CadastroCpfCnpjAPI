
using CadastroAPI.Domain.Model;

namespace CadastroAPI.Domain.Model
{
    public class PessoaFisica :PessoaBase
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set;}
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }

        public PessoaFisica(string cpf, string nome, DateTime dataNascimento, string genero, string estadoCivil, string email)
        {
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            Genero = genero;
            EstadoCivil = estadoCivil;
            Email = email;
        }
    }
}
