using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Model.Servicos.Relatorios;
using Financeiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Financeiro.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]

    public class ServicoController : ControllerBase
    {
        private readonly IServicoService _servicoService;
        private readonly ILogger<ServicoController> _logger;

        public ServicoController(IServicoService servicoService, ILogger<ServicoController> logger)
        {
            _servicoService = servicoService;
            _logger = logger;
        }

        [HttpGet("buscar-servicos")]
        public async Task<ActionResult<BaseModel<BuscarServicosModel.Response>>> BuscarServicosUsuario()
        {
            try
            {
                var response = await _servicoService.BuscarServicosUsuario();
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new StatusCodeResult(400);
            }
        }

        [HttpPost("cadastrar-servicos")]
        public async Task<ActionResult<BaseModel>> CadastrarServicos([FromBody] CadastroServicoModel.Request request)
        {
            try
            {
                var response = await _servicoService.CadastraServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpPut("editar-servico")]
        public async Task<ActionResult<BaseModel>> EditarServico([FromBody] CadastroServicoModel.Request request)
        {
            try
            {
                var response = await _servicoService.EditarServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpDelete("excluir-servico")]
        public async Task<ActionResult<BaseModel>> ExcluirServico([FromQuery] CadastroServicoModel.Request request)
        {
            try
            {
                var response = await _servicoService.ExcluirServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpPost("inicia-servico")]
        public async Task<ActionResult<BaseModel>> IniciaServico([FromBody] ServicoModel.Inicia request)
        {
            try
            {
                var response = await _servicoService.IniciaServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpGet("buscar-servicos-execucao")]
        public async Task<ActionResult<BaseModel<ServicoModel.Execucao>>> ServicoExecucao()
        {
            try
            {
                var response = await _servicoService.ServicoExecucao();
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new StatusCodeResult(400);
            }
        }

        [HttpPut("aumentar-servico")]
        public async Task<ActionResult<BaseModel>> AdicionarServico([FromBody] ServicoModel.AumentaDiminui request)
        {
            try
            {
                var response = await _servicoService.AdicionarServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpDelete("diminuir-servico")]
        public async Task<ActionResult<BaseModel>> DiminuirServico([FromQuery] ServicoModel.AumentaDiminui request)
        {
            try
            {
                var response = await _servicoService.DiminuirServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpPut("concluir-servico")]
        public async Task<ActionResult<BaseModel>> ConcluirServico([FromBody] ServicoModel.ConcluirServico request)
        {
            try
            {
                var response = await _servicoService.ConcluirServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpDelete("excluir-servico-execucao")]
        public async Task<ActionResult<BaseModel>> ExcluirExecucaoServico([FromQuery] ServicoModel.AumentaDiminui request)
        {
            try
            {
                var response = await _servicoService.ExcluirExecucaoServico(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
                return new StatusCodeResult(400);
            }
        }

        [HttpGet("lista-servicos-concluidos")]
        public async Task<ActionResult<BaseModel<ServicosConcluidosModel>>> ListaServicosConcluido()
        {
            try
            {
                var response = await _servicoService.ListaServicosConcluido();
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new StatusCodeResult(400);
            }
        }
    }
}
