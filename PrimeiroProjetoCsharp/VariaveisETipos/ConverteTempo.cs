using System;
using System.Collections.Generic;

namespace Desafio;

class ConverteTempo
{
    int minutos;
    int horas;
    int minutosHoras;

    public void converterMinutosParaHoras()
    {
        Console.Write("Digite o tempo em minutos: ");
        minutos = int.Parse(Console.ReadLine()!);
        horas = minutos / 60;
        minutosHoras = minutos % 60;
        Console.WriteLine($"{minutos} minutos equivalem a {horas} horas e {minutosHoras} minutos.");
    }
}
