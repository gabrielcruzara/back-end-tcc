namespace Financeiro.Application.Model.Autenticacao
{
    public class DadosLoginModel
    {
        public DadosLoginModel(string email, string nome)
        {
            Email = email;
            Nome = nome;
        }

        public string Email { get; private set; }
        public string Nome { get; private set; }
    }
}
