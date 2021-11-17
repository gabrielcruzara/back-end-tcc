using System.ComponentModel;

namespace Financeiro.Application.Model
{
    public enum Mensagens
    {
        [Description("Login realizado com sucesso")]
        LoginRealizadoComSucesso = 1,

        [Description("E-mail ou senha inválidos")]
        LoginInvalido = 2,

        [Description("Você deve alterar sua senha")]
        DeveAlterarSenha = 3,

        [Description("Operação realizada com sucesso")]
        OperacaoRealizadaComSucesso = 4,

        [Description("Ocorreu uma falha durante a operação")]
        OperacaoRealizadaSemSucesso = 5,

        [Description("Acesso Liberado !")]
        AcessoPermitido = 6,

        [Description("Acesso Negado !")]
        AcessoNegado = 7,

    }
}
