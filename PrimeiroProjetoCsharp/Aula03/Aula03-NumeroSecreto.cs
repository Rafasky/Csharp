using System;
using System.Collections.Generic;

namespace Desafio;

public class DesafioNumeroSecreto
{
    Random gerador = new Random();

    public void Jogar()
    {
        int numeroSecreto = gerador.Next(0, 101);
        int tentativas = 0;
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("\nFaça um palpite do número secreto: ");
            string palpiteString = Console.ReadLine()!;
            int palpiteInt = int.Parse(palpiteString);
            tentativas++;

            if (palpiteInt < numeroSecreto)
            {
                Console.WriteLine("\nO número secreto é MAIOR");
            }
            else if (palpiteInt > numeroSecreto)
            {
                Console.WriteLine("\nO número secreto é MENOR");
            }
            else
            {
                Console.WriteLine("\nParabéns, você acertou o número secreto!");
                Console.WriteLine($"Você aertou em {tentativas} tentativas.");
                acertou = true;
            }
        }
    }
}
