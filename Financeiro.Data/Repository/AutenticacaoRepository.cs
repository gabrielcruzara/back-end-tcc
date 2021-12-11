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

       public async Task<DadosUsuario> BuscarDadosUsuario(string email)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<DadosUsuario>("SP_BUSCA_DADOS_USUARIO_POR_EMAIL @EMAIL", new { EMAIL = email });
        }

        public async Task<BaseEntity> CadastraUsuario(string email, string nome, string senha)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_CADASTRA_USUARIO", new { EMAIL = email, NOME = nome, SENHA = senha }, commandType: CommandType.StoredProcedure);
        }

        public async Task<BaseEntity> AlterarSenha(string email, string senhaAntiga, string senhaNova)
        {
            return await sqlConnection.QueryFirstOrDefaultAsync<BaseEntity>("SP_ALTERA_SENHA", new { EMAIL = email, SENHA_ANTIGA = senhaAntiga, SENHA_NOVA = senhaNova }, commandType: CommandType.StoredProcedure);
        }
    }
}
