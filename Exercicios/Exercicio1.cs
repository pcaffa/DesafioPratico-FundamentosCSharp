namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio1
{
    public static void MensagemBoasVindas()
    {
        string nome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem - vindo(a)!");
    }
}
