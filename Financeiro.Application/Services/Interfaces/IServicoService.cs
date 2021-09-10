using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IServicoService
    {
        Task<BaseModel<CadastroServicoModel.Response>> BuscarServicosUsuario();
    }
}
