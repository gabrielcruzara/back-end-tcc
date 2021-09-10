using Financeiro.Core.Extensions;
using System;

namespace Financeiro.Application.Model
{
    public class EnumModel
    {
        public EnumModel()
        {

        }

        public EnumModel(Enum enumItem)
        {
            this.Codigo = enumItem.GetEnumValue();
            this.Nome = enumItem.GetEnumName();
            this.Descricao = enumItem.GetEnumDescription();
        }
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
