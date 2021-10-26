using Financeiro.Application.Model;
using Financeiro.Application.Model.Servicos;
using Financeiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]


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
        public async Task<ActionResult<BaseModel<BuscarServicos.Response>>> BuscarServicosUsuario([FromQuery] BuscarServicos.Request request)
        {
            try
            {
                var response = await _servicoService.BuscarServicosUsuario(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, request);
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
    }
}
