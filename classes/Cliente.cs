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
    }
}