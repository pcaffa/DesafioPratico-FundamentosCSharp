using System.Globalization;

namespace DesafioPratico_FundamentosCSharp.Exercicios;
public static class Exercicio6
{
    public static void Datas()
    {
        DateTime dataAtual = DateTime.Now;

        //Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        Console.WriteLine(dataAtual.ToString("dddd d/MM/yyyy  HH:mm:ss",
                  CultureInfo.CreateSpecificCulture("pt-BR")));

        //Apenas a data no formato "01/03/2024".
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

        //Apenas a hora no formato de 24 horas.
        Console.WriteLine(dataAtual.ToString("HH:mm:ss"));

        //A data com o mês por extenso.
        Console.WriteLine(dataAtual.ToString("dd MMMM yyyy"));

    }
}
