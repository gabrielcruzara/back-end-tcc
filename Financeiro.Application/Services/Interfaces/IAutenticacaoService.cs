using Financeiro.Application.Model;
using Financeiro.Application.Model.Autenticacao;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IAutenticacaoService
    {
        Task<BaseModel<LoginModel.Response>> Autenticar(LoginModel.Request request);
        Task<BaseModel<DadosUsuarioModel.Response>> BuscarDadosUsuario(DadosUsuarioModel.Request request);
    }
}
