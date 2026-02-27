using System;
using System.Collections.Generic;

namespace ScreenSound;

class MenuInicial
{
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    List<string> listaDeBandas = new List<string>();

    public void ExibeLogo()
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

    public void ExibirOpcoesDoMenu()
    {
        ExibeLogo();
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
                RegistrarBanda();
                break;
            case 2:
                Console.WriteLine("Mostrar todas as bandas");
                MostrarBandas();
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

    public void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("===========================================================");
        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        listaDeBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    public void MostrarBandas()
    {
        Console.Clear();
        Console.WriteLine("===========================================================");
        Console.WriteLine("\nLista de bandas registradas:");
        foreach (string banda in listaDeBandas)
        {
            Console.WriteLine(banda);
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    public void AvaliarBanda()
    {
        Console.WriteLine("Avaliar uma banda");
    }

    public void IniciaJogo()
    {
        ExibirOpcoesDoMenu();
    }
}
