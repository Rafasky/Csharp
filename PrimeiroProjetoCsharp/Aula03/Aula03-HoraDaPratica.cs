using System;
using System.Collections.Generic;

namespace Desafio;

public class HoraDaPratica
{
    double numUm;
    double numDois;
    string entrada;

    public void ColetaDados()
    {
        Console.Write("Digite o primeiro número: ");
        entrada = Console.ReadLine()!;
        numUm = int.Parse(entrada);

        Console.Write("Digite o segundo número: ");
        entrada = Console.ReadLine()!;
        numDois = int.Parse(entrada);

        Console.WriteLine("");
    }

    public void Adicao()
    {
       Console.WriteLine(numUm + numDois);
    }

    public void Subtracao()
    {
        Console.WriteLine(numUm - numDois);
    }

    public void Multiplicacao()
    {
        Console.WriteLine(numUm * numDois);
    }

    public void Divisao()
    {
        Console.WriteLine(numUm / numDois);
    }

    public void ExecutaOperacoes()
    {
        ColetaDados();
        Adicao();
        Subtracao();
        Multiplicacao();
        Divisao();
    }
}
