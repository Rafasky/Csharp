using System;
using System.Collections.Generic;

namespace Desafio;

class ConverteTipos
{
    decimal tonelada;
    int toneladaRedonda;
    int veiculosNecessarios;

    public void converterToneladaParaVeiculos()
    {
        Console.Write("Digite a quantidade de toneladas: ");
        tonelada = decimal.Parse(Console.ReadLine()!);
        toneladaRedonda = (int) tonelada;
        veiculosNecessarios = toneladaRedonda;
        Console.WriteLine($"{tonelada} toneladas equivalem a {veiculosNecessarios} veículos necessários para transportar.");
    }
}
