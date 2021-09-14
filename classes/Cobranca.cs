
namespace aula_7_programacao_orientada_objetos.classes {
    public class Cobranca
    {
        public int Codigo {get; private set;}

        public string DataEmissao {get; private set;}

        public string DataVencimento {get; private set;}

        public double Valor {get; private set;}

        public string DataPagamento {get; private set;}

        public Cobranca(int codigo, string dataEmissao, string dataVencimento, double valor, string dataPagamento) 
        {
            this.Codigo = codigo;
            this.DataEmissao = dataEmissao;
            this.DataVencimento = dataVencimento;
            this.Valor = valor;
            this.DataPagamento = dataPagamento;
        }

    }
}