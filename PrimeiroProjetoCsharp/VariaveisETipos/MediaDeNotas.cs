using System;
using System.Collections.Generic;

namespace Desafio;

class MediaDeNotas
{
    float notaA = 7.2f;
    float notaB = 8.3f;
    float notaC = 9.1f;

    public void CalcularMedia()
    {
        float media = (notaA + notaB + notaC) / 3;
        Console.WriteLine("A média das notas é: " + media);
    }
}
