using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Services.Interfaces;
using Financeiro.Domain.Repository;
using System.Threading.Tasks;

namespace Financeiro.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _servicoRepository;

        public ServicoService(IServicoRepository servicoRepository)
        {
            _servicoRepository = servicoRepository;
        }

        public async Task<BaseModel<CadastroServicoModel.Response>> BuscarServicosUsuario()
        {
            var query = await _servicoRepository.BuscarServicosUsuario();
            var response = new CadastroServicoModel.Response(query.NOME_SERVICO, query.CUSTO_SERVICO, query.VALOR_COBRADO);

            return new BaseModel<CadastroServicoModel.Response>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, dados: response);
        }
    }
}
