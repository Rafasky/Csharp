using System;
using System.Collections.Generic;

namespace Desafio;

internal class Aula03_NumerosParesEImpares
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            Console.WriteLine($"{numeros[i]} é um número par.");
        }
        else
        {
            Console.WriteLine($"{numeros[i]} é um número ímpar.");
        }
    }
}
