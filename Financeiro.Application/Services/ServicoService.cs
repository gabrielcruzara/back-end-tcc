using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Services.Interfaces;
using Financeiro.Application.Util;
using Financeiro.Domain.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Financeiro.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IUsuario _usuario;

        public ServicoService(IServicoRepository servicoRepository, IUsuario usuario)
        {
            _servicoRepository = servicoRepository;
            _usuario = usuario;
        }

        public async Task<BaseModel<List<BuscarServicosModel.Response>>> BuscarServicosUsuario()
        {
            var response = new List<BuscarServicosModel.Response>();
            var servicos = await _servicoRepository.BuscarServicosUsuario(_usuario.Email);

            foreach (var servico in servicos)
            {
                response.Add(new BuscarServicosModel.Response(servico.ID_SERVICO, servico.ID_USUARIO, servico.NOME_SERVICO, servico.CUSTO_SERVICO, servico.VALOR_COBRADO));
            }

            return new BaseModel<List<BuscarServicosModel.Response>>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, response);
        }

        public async Task<BaseModel> CadastraServico(CadastroServicoModel.Request request)
        {
            var query = await _servicoRepository.CadastraServico(_usuario.Email, request.NomeServico, request.CustoServico, request.ValorCobrado);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

    }
}
