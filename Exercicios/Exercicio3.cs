namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio3
{
    public static void OperacoesMatematicas()
    {
        double val1;
        double val2;

        Console.Write("Digite o primeiro valor (pode ser um inteiro ou um double ex: 1,5): ");
        while (!double.TryParse(Console.ReadLine(),out val1))
        {
            Console.WriteLine("Insira apenas números");
        };

        Console.Write("Digite o segundo valor (pode ser um inteiro ou um double ex: 1,5): ");
        while (!double.TryParse(Console.ReadLine(), out val2))
        {
            Console.WriteLine("Insira apenas números");
        };

        double soma = val1 + val2;
        double subtracao = val1 - val2;
        double multiplicacao = val1 * val2;
        double divisao = val2 == 0 ? 0 : val1 / val2;
        double media = soma / 2;

        Console.WriteLine("");
        Console.WriteLine("A soma entre esses dois números é: " + soma);
        Console.WriteLine("A subtração entre os dois números é: " + subtracao);
        Console.WriteLine("A multiplicação entre os dois números é: " + multiplicacao);
        Console.WriteLine("A divisão entre os dois números é: " + divisao);
        Console.WriteLine("A média entre os dois números é: " + media);
    }
}
