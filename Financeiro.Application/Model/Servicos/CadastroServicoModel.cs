namespace Financeiro.Application.Model.Servicos
{
    public class CadastroServicoModel
    {
        public class Request
        {
            public string NomeServico { get; set; }
            public decimal CustoServico { get; set; }
            public decimal ValorCobrado { get; set; }
        }
    }
}
