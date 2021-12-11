namespace Financeiro.Application.Model.Autenticacao
{
    public class AlterarSenha
    {
        public class Altera
        {
            public string Email { get; set; }
            public string SenhaAtual { get; set; }
            public string NovaSenha { get; set; }
        }
    }
}
