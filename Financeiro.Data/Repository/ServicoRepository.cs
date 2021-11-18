using Dapper;
using Financeiro.Domain;
using Financeiro.Domain.Autenticacao;
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

        public async Task<BaseEntity> CadastraServico(string email, string nomeServico, decimal custoServico, decimal valorCobrado)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_CADASTRA_SERVICO", new { EMAIL_USUARIO = email, NOME_SERVICO = nomeServico, CUSTO_SERVICO = custoServico, VALOR_COBRADO = valorCobrado }, commandType: CommandType.StoredProcedure);
        }

         public async Task<IEnumerable<TotalServico>> ListaTotalServicos(string email)
        {
            return await sqlConnection.QueryAsync<TotalServico>("SP_TOTAL_DE_SERVICOS_POR_USUARIO", new { EMAIL_USUARIO = email }, commandType: CommandType.StoredProcedure);
        }
    }
}
