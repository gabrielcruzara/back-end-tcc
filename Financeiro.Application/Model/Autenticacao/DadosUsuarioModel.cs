namespace Financeiro.Application.Model.Autenticacao
{
    public class DadosUsuarioModel
    {
            public DadosUsuarioModel(string email, string nome)
            {
                Email = email;
                Nome = nome;
            }

            public string Email { get; private set; }
            public string Nome { get; private set; }
    }
}
