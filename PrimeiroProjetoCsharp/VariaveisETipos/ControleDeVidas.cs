using System;
using System.Collections.Generic;

namespace Desafio;

class ControleDeVidas
{
    int vidas = 5;

    public void perdeVida()
    {
        vidas--;
    }

    public void ganhaVida()
    {
        vidas++;
    }

    public void joga()
    {
        perdeVida();
        ganhaVida();
        ganhaVida();

        Console.WriteLine($"Vidas restantes: {vidas}");
    }
}
