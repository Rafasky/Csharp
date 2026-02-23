using System;
using System.Collections.Generic;

namespace PrimeiroProjetoCsharp
{
    internal class DesafioNumeroSecreto
    {
        Random gerador = new Random();

        void jogar()
        {
            int numeroSecreto = gerador.Next(0, 101);
            Console.WriteLine("Faça um palpite do número secreto: ");
            string palpiteString = Console.ReadLine()!;
            int palpiteInt = int.Parse(palpiteString);

            if (palpiteInt < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior");
            }
            else if (palpiteInt > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor");
            }
            else
            {
                Console.WriteLine("Parabéns, você acertou o número secreto!");
            }
        }
    }
}
