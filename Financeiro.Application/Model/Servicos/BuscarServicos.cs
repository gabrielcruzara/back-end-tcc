namespace Financeiro.Application.Model.Servicos
{
    public class BuscarServicos
    {
        public partial class Request
        {
            public int IdentificadorUsuario { get; set; }
        }

        public partial class Response 
        {
            public Response(int identificadorServico, int identificadorUsuario, string nomeServico, decimal custoServico, decimal valorCobrado)
            {
                IdentificadorServico = identificadorServico;
                IdentificadorUsuario = identificadorUsuario;
                NomeServico = nomeServico;
                CustoServico = custoServico;
                ValorCobrado = valorCobrado;
            }

            public int IdentificadorServico { get; set; }
            public int IdentificadorUsuario { get; set; }
            public string NomeServico { get; set; }
            public decimal CustoServico { get; set; }
            public decimal ValorCobrado { get; set; }
        }
    }
}
