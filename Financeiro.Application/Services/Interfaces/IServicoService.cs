using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IServicoService
    {
        Task<BaseModel<List<BuscarServicos.Response>>> BuscarServicosUsuario(BuscarServicos.Request request);
        Task<BaseModel> CadastraServico(CadastroServicoModel.Request request);
    }
}
