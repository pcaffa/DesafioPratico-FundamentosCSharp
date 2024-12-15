using static System.Net.Mime.MediaTypeNames;
using DesafioPratico_FundamentosCSharp.Exercicios;

class Program
{
    static void Main()
    {
        Console.Write("Digite o numero do exercico de 1 a 6: ");
        var exercicoEscolhido = Console.ReadLine();

        switch (exercicoEscolhido)
        {
            case "1" :
                Exercicio1.MensagemBoasVindas();
                break;
            case "2":
                Exercicio2.ExibirNomeSobrenome();
                break;
            case "3":
                Exercicio3.OperacoesMatematicas();
                break;
            case "4":
                Exercicio4.ContatorDeCaracter();
                break;
            case "5":
                Exercicio5.ValidaPlacaVeiculo();
                break;
            case "6":
                Exercicio6.Datas();
                break;
            default :
                Console.Write("Exercício não encontrado!");
                break;
        }
        
    }
}
