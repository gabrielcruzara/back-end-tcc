using Financeiro.Domain.Servicos;

namespace Financeiro.Application.Model.Servicos
{
    public class ServicoModel
    {
        public partial class Inicia
        {
            public int IdentificadorServico { get; set; }
        }

        public partial class Execucao
        {
            public Execucao(int idHistoricoServico, string nomeServico, decimal custoServico, decimal valorCobrado, int quantidade, string horaInicio, string observacao)
            {
                IdHistoricoServico = idHistoricoServico;
                NomeServico = nomeServico;
                CustoServico = custoServico;
                ValorCobrado = valorCobrado;
                Quantidade = quantidade;
                HoraInicio = horaInicio;
                Observacao = observacao;
            }

            public int IdHistoricoServico { get; set; }
            public string NomeServico { get; set; }
            public decimal CustoServico { get; set; }
            public decimal ValorCobrado { get; set; }
            public int Quantidade { get; set; }
            public string HoraInicio { get; set; }
            public string Observacao { get; set; }
        }

        public partial class Total
        {
            public Total(TotalServico servico)
            {
                QuantidadeServico = servico.QTDSERVICOS;
            }

            public int QuantidadeServico { get; set; }
        }

        public partial class AumentaDiminui
        {
            public int IdentificadorHistoricoServico { get; set; }
        }

        public partial class ConcluirServico
        {
            public int IdentificadorHistoricoServico { get; set; }
            public string Observacao { get; set; }
            public int Quantidade { get; set; }
        }
    }
}
