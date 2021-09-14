using System;
using System.Collections.Generic;

namespace aula_7_programacao_orientada_objetos.classes {

    public class Cliente
    {
        public string Nome {get; private set;}

        public int Codigo {get; private set;}

        public string Fone {get; private set;}

        public List<Cobranca> Cobrancas {get; private set;}

        public Cliente(string nome, int codigo, string fone) {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Fone = fone;
            this.Cobrancas = new List<Cobranca>();
        }

        public void SalvarCobranca(Cobranca cobranca) {
            Cobrancas.Add(cobranca);
        }

        public void ListarDadosDoCliente() {
            Console.WriteLine("Nome: " + this.Nome + " - Cód: " + this.Codigo + "\nFone: " + this.Fone);
            Console.WriteLine("Código |" +   "Data Emissão   |" +  "Data Venc.   |" +  "  Valor    |"  +   "Data Pgto" );
            for(int i = 0; i < Cobrancas.Count; i++) {
                Console.WriteLine(Cobrancas[i].Codigo + "   |"+ Cobrancas[i].DataEmissao + "    |" + Cobrancas[i].DataVencimento + "    |" + Cobrancas[i].Valor + "  |" + Cobrancas[i].DataPagamento);
            }
        }
    }
}