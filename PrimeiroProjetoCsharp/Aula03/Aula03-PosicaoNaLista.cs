using System;
using System.Collections.Generic;

namespace Desafio;

public class Programa
{
    public void PosicaoNaLista()
    {
        int notaMedia = 7;

        if (notaMedia >= 5)
        {
            Console.WriteLine("Aprovado");
        }

        List<string> linguagensDeProgramacao = new List<string> { "C#", "Java", "JavaScript" };
        Console.WriteLine(linguagensDeProgramacao[0]);

        Console.Write("Digite a posição da linguagem que quer: ");
        string posicaoLinguagem = Console.ReadLine()!;
        int posicaoLinguagemInt = int.Parse(posicaoLinguagem);

        Console.WriteLine("A posição da linguagem na lista retorna " + linguagensDeProgramacao[posicaoLinguagemInt]);
    }
}
