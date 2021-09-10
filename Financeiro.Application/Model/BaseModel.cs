using Financeiro.Core.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Application.Model
{
    public class BaseModel<T>
    {
        public BaseModel()
        {

        }

        public BaseModel(bool sucesso, Mensagens mensagem)
        {
            this.Sucesso = sucesso;
            this.Mensagem = new EnumModel
            {
                Codigo = mensagem.GetEnumValue(),
                Nome = mensagem.GetEnumName(),
                Descricao = mensagem.GetEnumDescription()
            };
        }
        public BaseModel(bool sucesso, Mensagens mensagem, T dados) : this(sucesso, mensagem) => this.Dados = dados;

        public BaseModel(bool sucesso, Mensagens mensagem, T dados, ValidationResult[] resultadoValidacao) : this(sucesso, mensagem, dados) => this.ResultadoValidacao = resultadoValidacao;

        public T Dados { get; set; }

        public EnumModel Mensagem { get; set; }

        public ValidationResult[] ResultadoValidacao { get; set; }

        public bool Sucesso { get; set; }

    }

    public partial class BaseModel : BaseModel<dynamic>
    {

        public BaseModel() : base()
        {

        }

        public BaseModel(bool sucesso, Mensagens mensagem) : base(sucesso, mensagem)
        {

        }

        public BaseModel(bool sucesso, Mensagens mensagem, dynamic dados) : base(sucesso, mensagem) => this.Dados = dados;

        public BaseModel(bool sucesso, Mensagens mensagem, dynamic dados, ValidationResult[] resultadoValidacao) : base(sucesso, mensagem)
        {
            this.Dados = dados;
            this.ResultadoValidacao = resultadoValidacao;
        }
    }
}

