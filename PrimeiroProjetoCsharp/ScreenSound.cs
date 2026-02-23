using System;
using System.Collections.Generic;

namespace PrimeiroProjetoCsharp
{
    internal class ScreenSound
    {
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

        void ExibirMensagemMensagemDeBoasVindas()
        {
            Console.WriteLine(@"
            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
            ");
            Console.WriteLine(mensagemDeBoasVindas);
        }

        void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    Console.WriteLine("Registrar uma banda");
                    break;
                case 2:
                    Console.WriteLine("Mostrar todas as bandas");
                    break;
                case 3:
                    Console.WriteLine("Avaliar uma banda");
                    break;
                case 4:
                    Console.WriteLine("Exibir a média de uma banda");
                    break;
                case -1:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    ExibirOpcoesDoMenu();
                    break;
            }
        }

        ExibirMensagemMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();

    }
}
