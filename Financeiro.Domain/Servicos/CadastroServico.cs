namespace Financeiro.Domain.Servicos
{
    public class CadastroServico
    {
        public int ID_SERVICO { get; set; }
        public int ID_USUARIO { get; set; }
        public string NOME_SERVICO { get; set; }
        public decimal CUSTO_SERVICO { get; set; }
        public decimal VALOR_COBRADO { get; set; }
    }
}
