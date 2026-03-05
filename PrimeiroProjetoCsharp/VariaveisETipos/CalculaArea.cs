using System;
using System.Collections.Generic;

namespace Desafio;

class CalculaArea
{
    double largura;
    double comprimento;

    public void calcularArea() // deve se usar vírgula, não ponto, para separar os decimais
    {
        Console.Write("Digite a largura do retângulo: ");
        largura = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o comprimento do retângulo: ");
        comprimento = double.Parse(Console.ReadLine()!);
        double area = largura * comprimento;
        Console.WriteLine($"A área do retângulo é: {area:F2}");
    }
}
