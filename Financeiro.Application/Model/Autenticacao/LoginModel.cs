﻿namespace Financeiro.Application.Model.Autenticacao
{
    public class LoginModel
    {
        public class Request
        {
            public string Login { get; set; }
            public string Senha { get; set; }
        }
        public class Response
        {
            public Response(DadosUsuarioModel dadosUsuario, JwtToken token)
            {
                DadosUsuario = dadosUsuario;
                Token = token;
            }

            public DadosUsuarioModel DadosUsuario { get; set; }
            public JwtToken Token { get; private set; }
        }
    }
}
