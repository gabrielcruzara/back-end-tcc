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

        public async Task<IEnumerable<CadastroServico>> BuscarServicosUsuario(int identificadorUsuario)
        {
            return await sqlConnection.QueryAsync<CadastroServico>("SP_LISTA_SERVICOS_USUARIO", new { ID_USUARIO = identificadorUsuario }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> CadastraServico(int identificadorUsuario, string nomeServico, decimal custoServico, decimal valorCobrado)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_CADASTRA_SERVICO", new { ID_USUARIO = identificadorUsuario, NOME_SERVICO = nomeServico, CUSTO_SERVICO = custoServico, VALOR_COBRADO = valorCobrado }, commandType: CommandType.StoredProcedure);
        }
    }
}
