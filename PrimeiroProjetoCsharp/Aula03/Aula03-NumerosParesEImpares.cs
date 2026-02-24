using System;
using System.Collections.Generic;

namespace Desafio;

class NumerosParesEImpares
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public void VerificarParesEImparesComFor()
    {
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

    public void VerificarParesEImparesComForEach()
    {
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }
        }
    }
}
