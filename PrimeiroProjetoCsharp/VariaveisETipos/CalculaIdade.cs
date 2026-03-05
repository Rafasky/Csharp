using System;
using System.Collections.Generic;

namespace Desafio;

class CalculaIdade
{
    int anoAtual = DateTime.Now.Year;
    public void CalculaIdadeUser()
    {
        Console.Write("Digite o ano em que nasceu: ");
        string entrada = Console.ReadLine()!;
        int anoQueNasceu = int.Parse(entrada);
        int idade = anoAtual - anoQueNasceu;
        Console.WriteLine($"A sua idade é de: {idade} anos.");
    }
}
