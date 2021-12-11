using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Model.Servicos.Dashboard;
using Financeiro.Application.Model.Servicos.Relatorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IServicoService
    {
        Task<BaseModel<List<BuscarServicosModel.Response>>> BuscarServicosUsuario();

        Task<BaseModel<List<ServicoModel.Total>>> TotalServicos();

        Task<BaseModel> CadastraServico(CadastroServicoModel.Request request);

        Task<BaseModel> EditarServico(CadastroServicoModel.Request request);

        Task<BaseModel> ExcluirServico(CadastroServicoModel.Request request);

        Task<BaseModel> IniciaServico(ServicoModel.Inicia request);

        Task<BaseModel<List<ServicoModel.Execucao>>> ServicoExecucao();

        Task<BaseModel> AdicionarServico(ServicoModel.AumentaDiminui request);

        Task<BaseModel> DiminuirServico(ServicoModel.AumentaDiminui request);

        Task<BaseModel> ConcluirServico(ServicoModel.ConcluirServico request);

        Task<BaseModel> ExcluirExecucaoServico(ServicoModel.AumentaDiminui request);

        Task<BaseModel<List<ServicosConcluidosModel>>> ListaServicosConcluido();

        Task<BaseModel<List<GraficoGanhoDespesaModel>>> ListaGanhosDespesas();

        Task<BaseModel<List<LucroMensalModel>>> BuscaLucroMensal();
    }
}
