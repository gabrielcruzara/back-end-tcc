﻿
namespace Financeiro.Domain.Servicos
{
    public class ServicosConcluidos : CadastroServico
    {
        public int ID_HISTORICO_SERVICO { get; set; }
        public int QUANTIDADE { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FINAL { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
