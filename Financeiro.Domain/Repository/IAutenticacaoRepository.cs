using Financeiro.Domain.Autenticacao;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IAutenticacaoRepository
    {
        Task<BaseEntity> Autenticar(string email, string senha);

        Task<DadosUsuario> BuscarDadosUsuario(string email);

        Task<BaseEntity> CadastraUsuario(string email, string nome, string senha);

        Task<BaseEntity> AlterarSenha(string email, string senhaAntiga, string senhaNova);
    }
}
