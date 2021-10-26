using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Services.Interfaces;
using Financeiro.Domain.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public async Task<BaseModel<List<BuscarServicos.Response>>> BuscarServicosUsuario(BuscarServicos.Request request)
        {
            var response = new List<BuscarServicos.Response>();
            var servicos = await _servicoRepository.BuscarServicosUsuario(request.IdentificadorUsuario);

            foreach (var servico in servicos)
            {
                response.Add(new BuscarServicos.Response(servico.ID_SERVICO, servico.ID_USUARIO, servico.NOME_SERVICO, servico.CUSTO_SERVICO, servico.VALOR_COBRADO));
            }

            return new BaseModel<List<BuscarServicos.Response>>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, response);
        }

        public async Task<BaseModel> CadastraServico(CadastroServicoModel.Request request)
        {
            var query = await _servicoRepository.CadastraServico(request.IdentificadorUsuario, request.NomeServico, request.CustoServico, request.ValorCobrado);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

    }
}
