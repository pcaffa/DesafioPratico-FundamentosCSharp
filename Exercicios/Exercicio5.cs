namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio5
{
    public static void ValidaPlacaVeiculo()
    {
        Console.Write("Digite a placa do veículo para saber se ela é válida: ");
        string placa = Console.ReadLine();

        if (placa?.Length == 7)
            UsandoIf(placa);
        else
            Console.WriteLine("Falso");
    }

    private static bool IsNumero(string valor)
    {
        return valor.All(Char.IsDigit);
    }

    private static bool IsLetra(string valor)
    {
        return valor.All(Char.IsLetter);
    }

    private static void UsandoIf(string placa)
    {
        string primeiraParte = placa.Substring(0, 3);
        string segundaParte = placa.Substring(3, 4);

        if (IsLetra(primeiraParte) && IsNumero(segundaParte))
            Console.WriteLine("Verdadeiro");
        else
            Console.WriteLine("Falso");
    }
    private static void UsandoForeach (string placa)
    {
        bool placaValida = false;
        int contador = 0;

        foreach (char c in placa)
        {
            contador++;

            if (contador > 3 && Char.IsLetter(c))
            {
                placaValida = false;
                break;
            }
            else if (contador <= 3 && Char.IsDigit(c))
            {
                placaValida = false;
                break;
            }
            else
                placaValida = true;
        }

        if(!placaValida)
            Console.WriteLine("Falso");
        else
            Console.WriteLine("Verdadeiro");

    }
}
