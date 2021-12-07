using Financeiro.Domain.Servicos;

namespace Financeiro.Application.Model.Servicos.Dashboard
{
    public class GraficoGanhoDespesaModel
    {
            public GraficoGanhoDespesaModel(GraficoGanhoDespesa grafico)
            {
                Janeiro = grafico.JANEIRO;
                Fevereiro = grafico.FEVEREIRO;
                Marco = grafico.MARÇO;
                Abril = grafico.ABRIL;
                Maio = grafico.MAIO;
                Junho = grafico.JUNHO;
                Julho = grafico.JULHO;
                Agosto = grafico.AGOSTO;
                Setembro = grafico.SETEMBRO;
                Outubro = grafico.OUTUBRO;
                Novembro = grafico.NOVEMBRO;
                Dezembro = grafico.DEZEMBRO;
            }

            public decimal Janeiro { get; set; }
            public decimal Fevereiro { get; set; }
            public decimal Marco { get; set; }
            public decimal Abril { get; set; }
            public decimal Maio { get; set; }
            public decimal Junho { get; set; }
            public decimal Julho { get; set; }
            public decimal Agosto { get; set; }
            public decimal Setembro { get; set; }
            public decimal Outubro { get; set; }
            public decimal Novembro { get; set; }
            public decimal Dezembro { get; set; }
    }
}
