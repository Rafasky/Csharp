using System;
using System.Collections.Generic;

namespace Desafio;

class ConverteDistancias
{
    double milhas, km;

    public void converterMilhasParaKm()
    {
        Console.Write("Digite a distância em milhas: ");
        milhas = double.Parse(Console.ReadLine()!);
        km = milhas * 1.60934;
        Console.WriteLine($"{milhas} milhas equivalem a {km} quilômetros.");
    }

    public void converterKmParaMilhas()
    {
        Console.Write("Digite a distância em quilômetros: ");
        km = double.Parse(Console.ReadLine()!);
        milhas = km / 1.60934;
        Console.WriteLine($"{km} quilômetros equivalem a {milhas} milhas.");
    }
}
