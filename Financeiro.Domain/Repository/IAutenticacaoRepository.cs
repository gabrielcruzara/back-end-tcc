using Financeiro.Domain.Autenticacao;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IAutenticacaoRepository
    {
        Task<DadosUsuario> BuscarDadosUsuario(string identificador);
        //Task<BaseEntity> Autenticar(string login, string senha);
    }
}
