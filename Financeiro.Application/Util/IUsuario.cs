namespace Financeiro.Application.Util
{
    public interface IUsuario
    {
        /// <summary>
        /// Retorna o login do usuário logado
        /// </summary>
        string Email { get; }
    }
}
