using System;
using System.Collections.Generic;
using aula_7_programacao_orientada_objetos.classes;

class Program
{
    static List<Cliente> Clientes = new List<Cliente>();
    
    static void Main(string[] args) 
    {

        Inicio();
    }


    private static void Inicio() {
        Console.WriteLine("Bem-Vindo!!! \nEscolha uma opção a seguir: \n[1]-Adicionar novo cliente; \n[0]-Sair");
        int opcao = 0;
        do{
            opcao = Convert.ToInt32(Console.ReadLine());

        switch(opcao) {
            case 1: 
                AdicionarNovoCliente();
                break;
            case 2:
                AdicionarNovaCobraca();
                break;    
            case 0:
                Sair();
                break;
            default:
                Console.WriteLine("Opção inválida!!!!");
                break;
            }
        Console.WriteLine("Escolha uma opção a seguir: \n[1]-Adicionar novo cliente; \n[2]-Adicionar Nova Cobraça \n[0]-Sair");

        } while(opcao != 0);
    }

    private static void AdicionarNovoCliente() {

        Console.WriteLine("Informe seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe seu código");
        int codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe seu telefone");
        string telefone = Console.ReadLine();
        
        Cliente cliente = new Cliente(nome, codigo, telefone);
        Clientes.Add(cliente);
    }

    private static void AdicionarNovaCobraca() {

        Console.WriteLine("Qual o cliente que você deseja salvar a cobrança?");
        for(int i = 0; i < Clientes.Count; i++) {
            Console.WriteLine("["+(i+1)+"] - " + Clientes[i].Nome);
        }
        int escolha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o codigo da cobraça");
        int codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a data de emissao");
        string dataEmissao = Console.ReadLine();
        Console.WriteLine("Informe a data de vencimento");
        string dataVencimento = Console.ReadLine();
        Console.WriteLine("Informe o valor da cobraça");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a data de pagamento");
        string dataPagamento = Console.ReadLine();

        Cobranca cobranca = new Cobranca(codigo, dataEmissao, dataVencimento, valor, dataPagamento);
        Clientes[escolha-1].SalvarCobranca(cobranca);
    }

    private static void Sair() {
        Console.WriteLine("Saindo...");
    }
}