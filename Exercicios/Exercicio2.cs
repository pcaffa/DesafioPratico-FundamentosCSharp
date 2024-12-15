namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio2
{
    public static void ExibirNomeSobrenome()
    {
        string nome;
        string sobrenome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o seu sobrenome: ");
        sobrenome = Console.ReadLine();

        Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));
    }
}
