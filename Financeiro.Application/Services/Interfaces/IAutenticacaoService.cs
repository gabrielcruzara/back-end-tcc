using Financeiro.Application.Model;
using Financeiro.Application.Model.Autenticacao;
using System.Threading.Tasks;

namespace Financeiro.Application.Services.Interfaces
{
    public interface IAutenticacaoService
    {
        Task<BaseModel<LoginModel.Dados>> Autenticar(LoginModel.Login request);

        Task<BaseModel> CadastraUsuario(CadastroModel.Cadastro request);
    }
}
