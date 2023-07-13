using System;

class Program
{
    static void Main()
    {
        // Vetor com o valor de faturamento diário
        decimal[] faturamentoDiario = { 100.5m, 200.8m, 150.2m, 300.1m, 50.3m, 400.7m, 250.4m, 180.9m, 90.6m, 120.0m, 180.5m, 220.3m };

        // Calcular o menor valor de faturamento
        decimal menorValor = CalcularMenorValor(faturamentoDiario);
        Console.WriteLine("Menor valor de faturamento: {0}", menorValor);

        // Calcular o maior valor de faturamento
        decimal maiorValor = CalcularMaiorValor(faturamentoDiario);
        Console.WriteLine("Maior valor de faturamento: {0}", maiorValor);

        // Calcular o número de dias com faturamento superior à média anual
        int diasAcimaMedia = CalcularDiasAcimaMedia(faturamentoDiario);
        Console.WriteLine("Número de dias com faturamento acima da média anual: {0}", diasAcimaMedia);
    }

    static decimal CalcularMenorValor(decimal[] faturamentoDiario)
    {
        decimal menorValor = decimal.MaxValue;

        for (int i = 0; i < faturamentoDiario.Length; i++)
        {
            if (faturamentoDiario[i] < menorValor)
            {
                menorValor = faturamentoDiario[i];
            }
        }

        return menorValor;
    }

    static decimal CalcularMaiorValor(decimal[] faturamentoDiario)
    {
        decimal maiorValor = decimal.MinValue;

        for (int i = 0; i < faturamentoDiario.Length; i++)
        {
            if (faturamentoDiario[i] > maiorValor)
            {
                maiorValor = faturamentoDiario[i];
            }
        }

        return maiorValor;
    }

    static int CalcularDiasAcimaMedia(decimal[] faturamentoDiario)
    {
        decimal soma = 0;
        int diasComFaturamentoAcimaMedia = 0;

        for (int i = 0; i < faturamentoDiario.Length; i++)
        {
            soma += faturamentoDiario[i];
        }

        decimal mediaAnual = soma / faturamentoDiario.Length;

        for (int i = 0; i < faturamentoDiario.Length; i++)
        {
            if (faturamentoDiario[i] > mediaAnual)
            {
                diasComFaturamentoAcimaMedia++;
            }
        }

        return diasComFaturamentoAcimaMedia;
    }
}
