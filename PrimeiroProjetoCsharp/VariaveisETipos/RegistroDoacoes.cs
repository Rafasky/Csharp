using System;
using System.Collections.Generic;

namespace Desafio;

class RegistroDoacoes
{
    double valorRecebidoDoacao;
    bool doacaoAnonima;
    List<char> tipoConta = ['P', 'C'];
        
    public void realizaDoacao() {
        Console.Write("Digite o valor a doar: ");
        double valorAReceber = double.Parse(Console.ReadLine()!);

        verificaAnonimidade();
    }

    public void verificaAnonimidade()
    {
        Console.Write("Você gostaria de se identificar? (s/n): ");
        string entrada = Console.ReadLine()!;
        if (entrada == "s" || entrada == "S")
        {
            doacaoAnonima = false;
        }
        else if (entrada == "n" || entrada == "N")
        {
            doacaoAnonima = true;
        }
        else
        {
            verificaAnonimidade();
        }
    }
}

