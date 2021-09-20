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
        /// Método de autenticação no sistema
        /// </summary>
        /// <param>Login e Senha</param>
        /// <returns>Token de Acesso</returns>
        [HttpPost("login")]
        public async Task<ActionResult<BaseModel<LoginModel.Response>>> Login([FromBody] LoginModel.Request request)
        {
            try
            {
                var response = await _autenticacaoService.Autenticar(request);
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
