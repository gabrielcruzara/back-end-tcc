
using Financeiro.Domain.Servicos;

namespace Financeiro.Application.Model.Servicos.Relatorios
{
    public class ServicosConcluidosModel
    {
        public ServicosConcluidosModel(ServicosConcluidos servico)
        {
            IdentificadorHistoricoServico = servico.ID_HISTORICO_SERVICO;
            IdentificadorServico = servico.ID_SERVICO;
            NomeServico = servico.NOME_SERVICO;
            Quantidade = servico.QUANTIDADE;
            CustoServico = servico.CUSTO_SERVICO;
            ValorCobrado = servico.VALOR_COBRADO;
            Observacao = servico.OBSERVACAO;
            HoraInicio = servico.HORA_INICIO;
            HoraFinal = servico.HORA_FINAL;
        }

        public int IdentificadorHistoricoServico { get; set; }
        public int IdentificadorServico { get; set; }
        public string NomeServico { get; set; }
        public int Quantidade { get; set; }
        public decimal CustoServico { get; set; }
        public decimal ValorCobrado { get; set; }
        public string Observacao { get; set; }     
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
    }
}
