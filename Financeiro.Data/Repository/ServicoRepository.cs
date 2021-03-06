using Dapper;
using Financeiro.Domain;
using Financeiro.Domain.Dashboard;
using Financeiro.Domain.Repository;
using Financeiro.Domain.Servicos;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Financeiro.Data.Repository
{
    public class ServicoRepository : BaseRepository, IServicoRepository
    {
        public ServicoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(string email)
        {
            return await sqlConnection.QueryAsync<CadastroServico>("SP_LISTA_SERVICOS_USUARIO", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> CadastraServico(string email, string nomeServico, decimal? custoServico, decimal? valorCobrado)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_CADASTRA_SERVICO", new { EMAIL_USUARIO = email, NOME_SERVICO = nomeServico, CUSTO_SERVICO = custoServico, VALOR_COBRADO = valorCobrado }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> EditarServico(int identificadorServico, string nomeServico, decimal? custoServico, decimal? valorCobrado)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_ATUALIZA_SERVICO", new { ID_SERVICO = identificadorServico, NOME_SERVICO = nomeServico, CUSTO_SERVICO = custoServico, VALOR_COBRADO = valorCobrado }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> ExcluirServico(int identificadorServico)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_EXCLUI_SERVICO", new { ID_SERVICO = identificadorServico }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> IniciaServico(string email, int identificadorServico)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_INICIA_SERVICO", new { EMAIL_USUARIO = email, ID_SERVICO = identificadorServico }, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Execucao>> ServicoExecucao(string email)
        {
            return await sqlConnection.QueryAsync<Execucao>("SP_LISTA_SERVICOS_EM_EXECUCAO", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TotalServico>> TotalServicos(string email)
        {
            return await sqlConnection.QueryAsync<TotalServico>("SP_TOTAIS_POR_USUARIO", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> AdicionarServico(int identificadorHistoricoServico)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_AUMENTA_QUANTIDADE_SERVICO", new { ID_HISTORICO_SERVICO = identificadorHistoricoServico }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> DiminuirServico(int identificadorHistoricoServico)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_DIMINUI_QUANTIDADE_SERVICO", new { ID_HISTORICO_SERVICO = identificadorHistoricoServico }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> ConcluirServico(int identificadorHistoricoServico, string observacao, int quantidade)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_CONCLUI_SERVICO_EM_EXECUCAO", new { ID_HISTORICO_SERVICO = identificadorHistoricoServico, OBSERVACAO = observacao, QUANTIDADE = quantidade}, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> ExcluirExecucaoServico(int identificadorHistoricoServico)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_EXCLUI_EXECUCAO_SERVICO", new { ID_HISTORICO_SERVICO = identificadorHistoricoServico}, commandType: CommandType.StoredProcedure);
        }
        #region Relatórios

        public async Task<IEnumerable<ServicosConcluidos>> ListaServicosConcluido(string email)
        {
            return await sqlConnection.QueryAsync<ServicosConcluidos>("SP_LISTA_SERVICOS_CONCLUIDOS", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region Dashboard

        public async Task<IEnumerable<GraficoGanhoDespesa>> ListaGanhosDespesas(string email)
        {
            return await sqlConnection.QueryAsync<GraficoGanhoDespesa>("SP_DASH_TOTAL_MENSAL", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<LucroMensal>> BuscaLucroMensal(string email)
        {
            return await sqlConnection.QueryAsync<LucroMensal>("SP_DASH_LUCRO_MENSAL", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }
        #endregion
    }
}
