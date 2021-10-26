using Dapper;
using Financeiro.Domain;
using Financeiro.Domain.Repository;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System;
using Financeiro.Domain.Autenticacao;
using System.Data;

namespace Financeiro.Data.Repository
{
    public class AutenticacaoRepository : BaseRepository, IAutenticacaoRepository
    {
         public AutenticacaoRepository(IConfiguration configuration) : base(configuration)
         {
         }

       public async Task<BaseEntity> Autenticar(string email, string senha)
       {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_AUTENTICA_USUARIO", new { EMAIL = email, SENHA = senha }, commandType: CommandType.StoredProcedure);
       }

       public async Task<DadosUsuario> BuscarDadosUsuario(string identificador)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<DadosUsuario>("SP_BUSCA_DADOS_USUARIO @ID_USUARIO", new { ID_USUARIO = identificador });
        }
    }
}
