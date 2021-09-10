using Financeiro.Application.Model;
using Financeiro.Application.Model.Autenticacao;
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
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoService _autenticacaoService;
        private readonly ILogger<AutenticacaoController> _logger;

        public AutenticacaoController(IAutenticacaoService autenticacaoService, ILogger<AutenticacaoController> logger)
        {
            _autenticacaoService = autenticacaoService;
            _logger = logger;
        }

        /// <summary>
        /// Método de buscar dados do usuario no sistema
        /// </summary>
        /// <returns>Busca dados do usuario</returns>
        [HttpGet("busca-dados-usuario")]
        public async Task<ActionResult<BaseModel<DadosUsuarioModel.Response>>> BuscarDadosUsuario([FromQuery] DadosUsuarioModel.Request request)
        {
            try
            {
                var response = await _autenticacaoService.BuscarDadosUsuario(request);
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
