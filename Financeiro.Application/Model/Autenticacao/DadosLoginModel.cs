namespace Financeiro.Application.Model.Autenticacao
{
    public class DadosLoginModel
    {
        public DadosLoginModel(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}
