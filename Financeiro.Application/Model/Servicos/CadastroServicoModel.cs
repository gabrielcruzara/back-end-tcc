namespace Financeiro.Application.Model.Servicos
{
    public class CadastroServicoModel
    {
        public partial class Response
        {
            public Response(string nomeServico, int custoServico, int valorCobrado)
            {
                NomeServico = nomeServico;
                CustoServico = custoServico;
                ValorCobrado = valorCobrado;
            }

            public string NomeServico { get; set; }
            public int CustoServico { get; set; }
            public int ValorCobrado { get; set; }
        }
    }
}
