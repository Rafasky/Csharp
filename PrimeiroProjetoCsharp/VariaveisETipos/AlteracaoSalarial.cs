using System;
using System.Collections.Generic;

namespace Desafio;

class AlteracaoSalarial
{
    decimal salario;
    decimal aumento;
    decimal novoSalario;

    public void reajusteSalarial()
    {
        Console.Write("Digite o salário atual: ");
        salario = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o percentual de aumento: ");
        aumento = Convert.ToDecimal(Console.ReadLine());
        novoSalario = salario + (salario * aumento / 100);
        Console.WriteLine($"O novo salário é: {novoSalario:C}");
    }
}
