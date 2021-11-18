using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IServicoService
    {
        Task<BaseModel<List<BuscarServicosModel.Response>>> BuscarServicosUsuario();

        Task<BaseModel> CadastraServico(CadastroServicoModel.Request request);

        Task<BaseModel> EditarServico(CadastroServicoModel.Request request);

        Task<BaseModel> ExcluirServico(CadastroServicoModel.Request request);

        Task<BaseModel> IniciaServico(ServicoModel.Inicia request);

        Task<BaseModel<List<ServicoModel.Execucao>>> ServicoExecucao();

        //Task<BaseModel<ServicoModel.Total>> TotalServicos();
    }
}
