using Dapper;
using Financeiro.Domain.Autenticacao;
using Financeiro.Domain.Repository;
using Financeiro.Domain.Servicos;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Financeiro.Data.Repository
{
    /*public class ServicoRepository : BaseRepository, IServicoRepository
    {
        public ServicoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<CadastroServico> BuscarServicosUsuario()
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<CadastroServico>("SP_BUSCA_DADOS_USUARIO @ID_USUARIO");
        }
    }*/
}
