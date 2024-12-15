namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio4
{
    public static void ContatorDeCaracter()
    {
        Console.WriteLine("Digite uma ou mais palavras para receber a quantidade de caracteres, lembrando que espaços não serão contabilizados:");
        string textoCompleto = Console.ReadLine();
        string[] textos = textoCompleto.Split(" ");

        string textoSemEspaco = textoCompleto.Replace(" ","");
        if(textoSemEspaco?.Length <= 0)
            Console.WriteLine("Não há caracteres para contar.");
        else

        {
            Console.WriteLine("");

            foreach (string texto in textos)
            {
                Console.WriteLine($"{texto} tem {texto?.Length} caracteres");
            }

            Console.WriteLine("");
            Console.WriteLine($"O texto completo tem {textoSemEspaco?.Length} caracteres.");
        }
    }
}
