
using Financeiro.Domain.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IServicoRepository
    {
        Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(int identificadorUsuario);
        Task<BaseEntity> CadastraServico(int identificadorUsuario, string nomeServico, decimal custoServico, decimal valorCobrado);
    }
}