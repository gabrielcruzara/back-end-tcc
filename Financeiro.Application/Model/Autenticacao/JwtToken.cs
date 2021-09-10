namespace Financeiro.Application.Model.Autenticacao
{
    public class JwtToken
    {
        public JwtToken(string created, string expiration, string accessToken, string refreshToken)
        {
            Created = created;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public string Created { get; private set; }
        public string Expiration { get; private set; }
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }
    }
}
