
using Financeiro.Domain.Servicos;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IServicoRepository
    {
        Task<CadastroServico> BuscarServicosUsuario();
    }
}
