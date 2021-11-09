namespace Financeiro.Application.Model.Autenticacao
{
    public class DadosUsuarioModel
    {
            public DadosUsuarioModel(string email, string nome, int id)
            {
                Email = email;
                Nome = nome;
                Id = id;
            }

            public string Email { get; private set; }
            public string Nome { get; private set; }
            public int Id { get; set; }
    }
}
