namespace Financeiro.Application.Model.Autenticacao
{
    public class DadosUsuarioModel
    {
        public class Request
        {
            public string Identificador { get; set; }
        }
        public class Response
        {
            public Response(string email, string nome)
            {
                Email = email;
                Nome = nome;
            }

            public string Email { get; private set; }
            public string Nome { get; private set; }
        }
    }
}
