namespace Financeiro.Application.Model.Autenticacao
{
    public class LoginModel
    {
        public partial class Login
        {
            public string Email { get; set; }
            public string Senha { get; set; }
        }

        public class Dados
        {
            public Dados(DadosUsuarioModel dadosUsuario, JwtToken token)
            {
                DadosUsuario = dadosUsuario;
                Token = token;
            }

            public DadosUsuarioModel DadosUsuario { get; set; }
            public JwtToken Token { get; private set; }
        }
    }
}
