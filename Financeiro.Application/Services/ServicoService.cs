using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Model.Servicos.Relatorios;
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
                response.Add(new BuscarServicosModel.Response(servico.ID_SERVICO, servico.EMAIL_USUARIO, servico.NOME_SERVICO, servico.CUSTO_SERVICO, servico.VALOR_COBRADO));
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

        public async Task<BaseModel> EditarServico(CadastroServicoModel.Request request)
        {
            var query = await _servicoRepository.EditarServico(request.identificadorServico, request.NomeServico, request.CustoServico, request.ValorCobrado);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel> ExcluirServico(CadastroServicoModel.Request request)
        {
            var query = await _servicoRepository.ExcluirServico(request.identificadorServico);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel> IniciaServico(ServicoModel.Inicia request)
        {
            var query = await _servicoRepository.IniciaServico(_usuario.Email, request.IdentificadorServico);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel<List<ServicoModel.Execucao>>> ServicoExecucao()
        {
            var response = new List<ServicoModel.Execucao>();
            var servicos = await _servicoRepository.ServicoExecucao(_usuario.Email);

            foreach (var servico in servicos)
            {
                response.Add(new ServicoModel.Execucao(servico.ID_HISTORICO_SERVICO, servico.NOME_SERVICO, servico.CUSTO_SERVICO, servico.VALOR_COBRADO, servico.QUANTIDADE, servico.HORA_INICIO, servico.OBSERVACAO));
            }

            return new BaseModel<List<ServicoModel.Execucao>>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, response);
        }

        public async Task<BaseModel> AdicionarServico(ServicoModel.AumentaDiminui request)
        {
            var query = await _servicoRepository.AdicionarServico(request.IdentificadorHistoricoServico);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel> DiminuirServico(ServicoModel.AumentaDiminui request)
        {
            var query = await _servicoRepository.DiminuirServico(request.IdentificadorHistoricoServico);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel> ConcluirServico(ServicoModel.ConcluirServico request)
        {
            var query = await _servicoRepository.ConcluirServico(request.IdentificadorHistoricoServico, request.Observacao, request.Quantidade);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel> ExcluirExecucaoServico(ServicoModel.AumentaDiminui request)
        {
            var query = await _servicoRepository.ExcluirExecucaoServico(request.IdentificadorHistoricoServico);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        public async Task<BaseModel<List<ServicosConcluidosModel>>> ListaServicosConcluido()
        {
            var response = new List<ServicosConcluidosModel>();
            var servicos = await _servicoRepository.ListaServicosConcluido(_usuario.Email);

            foreach (var servico in servicos)
            {
                response.Add(new ServicosConcluidosModel(servico));
            }

            return new BaseModel<List<ServicosConcluidosModel>>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, response);
        }

        /*public async Task<BaseModel<ServicoModel.Total>> TotalServicos()
        {
            var dados = new ServicoModel();

            var query = await _servicoRepository.TotalServicos(_usuario.Email);

            new ServicoModel.Total(query.QTDSERVICOS);

            return new BaseModel<ServicoModel.Total>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, dados);
        }*/
    }
}
