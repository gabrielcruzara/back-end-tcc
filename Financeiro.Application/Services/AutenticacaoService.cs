using Financeiro.Application.Configurations;
using Financeiro.Application.Model;
using Financeiro.Application.Model.Autenticacao;
using Financeiro.Application.Services.Interfaces;
using Financeiro.Application.Util;
using Financeiro.Domain.Autenticacao;
using Financeiro.Domain.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Financeiro.Application.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IAutenticacaoRepository _autenticacaoRepository;
        private readonly SignInConfigurations _signingConfigurations;
        private readonly TokenConfigurations _tokenConfigurations;
        private readonly IUsuario _usuario;

        public AutenticacaoService(IAutenticacaoRepository autenticacaoRepository, IUsuario usuario, SignInConfigurations signingConfigurations, TokenConfigurations tokenConfigurations)
        {
            _autenticacaoRepository = autenticacaoRepository;
            _signingConfigurations = signingConfigurations;
            _tokenConfigurations = tokenConfigurations;
            _usuario = usuario;
        }
     

        public async Task<BaseModel<LoginModel.Dados>> Autenticar(LoginModel.Login request)
        {
            var registro = await _autenticacaoRepository.Autenticar(request.Email, request.Senha);

            if (registro.COD_ERRO == 0)
            {
                var dadosLogin = await _autenticacaoRepository.BuscarDadosUsuario(request.Email);
                
                var loginModel = new LoginModel.Dados(DadosUsuarioAdapter(dadosLogin), GerarToken(request.Email, _signingConfigurations, _tokenConfigurations));
                
                return new BaseModel<LoginModel.Dados>(sucesso: true, mensagem: Mensagens.LoginRealizadoComSucesso, loginModel);
            }
            
            return new BaseModel<LoginModel.Dados>(sucesso: false, mensagem: Mensagens.LoginInvalido);
        }

       /* public async Task<BaseModel<DadosUsuarioModel.Response>> BuscarDadosUsuario(DadosUsuarioModel.Request request)
{
            var query = await _autenticacaoRepository.BuscarDadosUsuario(request.Identificador);
            var response = new DadosUsuarioModel.Response(query.NOME, query.EMAIL);

            return new BaseModel<DadosUsuarioModel.Response>(sucesso: true, mensagem: Mensagens.OperacaoRealizadaComSucesso, dados: response);
        }*/

        public async Task<BaseModel> CadastraUsuario(CadastroModel.Cadastro request)
        {
            var query = await _autenticacaoRepository.CadastraUsuario(request.Email, request.Nome, request.Senha);
            var mensagem = new ValidationResult[] { new ValidationResult(query.MSG_ERRO) };

            if (query.COD_ERRO != 0)
            {
                return new BaseModel(false, Mensagens.OperacaoRealizadaSemSucesso, null, mensagem);
            }

            return new BaseModel(true, Mensagens.OperacaoRealizadaComSucesso, null, mensagem);
        }

        #region Jwt Utils
        private JwtToken GerarToken(string Usuario, SignInConfigurations signingConfigurations, TokenConfigurations tokenConfigurations)
        {
            ClaimsIdentity identity = new ClaimsIdentity(
                new GenericIdentity(Usuario, "Login"),
                new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N"))
                }
            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

            // Calcula o tempo máximo de validade do refresh token
            // (o mesmo será invalidado automaticamente pelo Redis)
            TimeSpan finalExpiration = TimeSpan.FromSeconds(tokenConfigurations.FinalExpiration);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfigurations.Issuer,
                Audience = tokenConfigurations.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });
            var token = handler.WriteToken(securityToken);

            var resultado = new JwtToken(
                created: dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration: dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken: token,
                refreshToken: Guid.NewGuid().ToString().Replace("-", String.Empty)
            );

            return resultado;
        }

        /*private DadosUsuarioModel DadosUsuarioAdapter(DadosUsuario dados)
        {
            return new DadosUsuarioModel(dados.);
        }*/

        private DadosUsuarioModel DadosUsuarioAdapter(DadosUsuario dados)
        {
            return new DadosUsuarioModel(dados.EMAIL, dados.NOME);
        }
        #endregion
    }
}
