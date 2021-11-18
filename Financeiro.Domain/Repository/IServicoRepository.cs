using Financeiro.Domain.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IServicoRepository
    {
        Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(string email);

        Task<BaseEntity> CadastraServico(string email, string nomeServico, decimal custoServico, decimal valorCobrado);

        Task<BaseEntity> EditarServico(int identificadorServico, string nomeServico, decimal custoServico, decimal valorCobrado);

        Task<BaseEntity> ExcluirServico(int identificadorServico);

        Task<BaseEntity> IniciaServico(string email, int identificadorServico);

        Task<IEnumerable<Execucao>> ServicoExecucao(string email);

        Task<TotalServico> TotalServicos(string email);
    }
}