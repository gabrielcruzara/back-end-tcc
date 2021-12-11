using Financeiro.Domain.Dashboard;
using Financeiro.Domain.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Domain.Repository
{
    public interface IServicoRepository
    {
        Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(string email);

        Task<BaseEntity> CadastraServico(string email, string nomeServico, decimal? custoServico, decimal? valorCobrado);

        Task<BaseEntity> EditarServico(int identificadorServico, string nomeServico, decimal? custoServico, decimal? valorCobrado);

        Task<BaseEntity> ExcluirServico(int identificadorServico);

        Task<BaseEntity> IniciaServico(string email, int identificadorServico);

        Task<IEnumerable<Execucao>> ServicoExecucao(string email);

        Task<IEnumerable<TotalServico>> TotalServicos(string email);

        Task<BaseEntity> AdicionarServico(int identificadorHistoricoServico);

        Task<BaseEntity> DiminuirServico(int identificadorHistoricoServico);

        Task<BaseEntity> ConcluirServico(int identificadorHistoricoServico, string observacao, int quantidade);

        Task<BaseEntity> ExcluirExecucaoServico(int identificadorHistoricoServico);

        #region Relatórios

        Task<IEnumerable<ServicosConcluidos>> ListaServicosConcluido(string email);

        #endregion

        #region Dashboard
        Task<IEnumerable<GraficoGanhoDespesa>> ListaGanhosDespesas(string email);

        Task<IEnumerable<LucroMensal>> BuscaLucroMensal(string email);
        #endregion
    }
}