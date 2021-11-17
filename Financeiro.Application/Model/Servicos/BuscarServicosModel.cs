namespace Financeiro.Application.Model.Servicos
{
    public class BuscarServicosModel
    {
        public partial class Response 
        {
            public Response(int identificadorServico, string email, string nomeServico, decimal custoServico, decimal valorCobrado)
            {
                IdentificadorServico = identificadorServico;
                Email = email;
                NomeServico = nomeServico;
                CustoServico = custoServico;
                ValorCobrado = valorCobrado;
            }

            public int IdentificadorServico { get; set; }
            public string Email { get; set; }
            public string NomeServico { get; set; }
            public decimal CustoServico { get; set; }
            public decimal ValorCobrado { get; set; }
        }
    }
}
