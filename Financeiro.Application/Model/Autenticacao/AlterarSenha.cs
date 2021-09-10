using Financeiro.Domain;

namespace Financeiro.Application.Model.Autenticacao
{
    public class AlterarSenha
    {
        public class Request
        {
            public string Login { get; set; }
            public string SenhaAtual { get; set; }
            public string NovaSenha { get; set; }
            public string CPF { get; set; }
            public string DataNascimento { get; set; }
        }

        public class Response : BaseEntity
        {
            public Response(int codErro, string msgErro)
            {
                CodErro = codErro;
                MsgErro = msgErro;
            }
        }
    }
}
