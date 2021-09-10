using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Financeiro.Data.Repository
{
    public abstract class BaseRepository
    {
        private readonly IConfiguration _configuration;
        protected readonly SqlConnection sqlConnection;
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            sqlConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
