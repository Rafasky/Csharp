using System;
using System.Collections.Generic;

namespace Desafio;

class RegistroDoacoes
{
    double valorRecebidoDoacao;
    bool doacaoAnonima;
    string? tipoConta;
        
    public void valorDoacao() {
        Console.Write("Digite o valor a doar: ");
        valorRecebidoDoacao = double.Parse(Console.ReadLine()!);
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

    public void verificaTipoConta()
    {
        Console.Write("Digite o tipo de conta (P para conta poupança, C para conta corrente): ");
        char tipo = char.Parse(Console.ReadLine()!);
        if (tipo == 'p' || tipo == 'P')
        {
            tipoConta = "Conta poupança";
        }
        else if(tipo == 'c' || tipo == 'C')
        {
            tipoConta = "Conta corrente";
        }
        else
        {
            verificaTipoConta();
        }
    }

    public void realizaDoacao()
    {
        valorDoacao();
        verificaAnonimidade();
        verificaTipoConta();

        Console.WriteLine($"\nValor recebido: R${valorRecebidoDoacao}");
        Console.WriteLine($"Doação anônima: {(doacaoAnonima ? "Sim" : "Não")}");
        Console.WriteLine($"Tipo de conta: {tipoConta}");
    }
}

