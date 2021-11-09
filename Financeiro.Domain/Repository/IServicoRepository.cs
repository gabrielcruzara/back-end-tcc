using Financeiro.Domain.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IServicoRepository
    {
        Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(string email);
        Task<BaseEntity> CadastraServico(string email, string nomeServico, decimal custoServico, decimal valorCobrado);
    }
}