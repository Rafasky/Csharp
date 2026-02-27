using System;
using System.Collections.Generic;

namespace ScreenSound;

class MenuInicial
{
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

    public void adcionaBandas()
    {
        bandasRegistradas.Add("Kiss", new List<int> { 10, 8, 6 });
        bandasRegistradas.Add("Judas Priest", new List<int>());
    }

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
                RegistrarBanda();
                break;
            case 2:
                MostrarBandas();
                break;
            case 3:
                AvaliarUmaBanda();
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
        ExibirTituloDaOpcao("Registrar uma banda");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    public void MostrarBandas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Mostrar todas as bandas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine(banda);
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    public void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar uma banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Digite a nota que deseja dar para a banda {nomeDaBanda}: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"A nota {nota} foi registrada para a banda {nomeDaBanda} com sucesso.");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada. Por favor, registre a banda antes de avaliá-la.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string sinaisDeIgual = string.Empty.PadLeft(quantidadeDeLetras, '=');

        Console.WriteLine(sinaisDeIgual);
        Console.WriteLine(titulo);
        Console.WriteLine(sinaisDeIgual + "\n");
    }

    public void IniciaJogo()
    {
        adcionaBandas();
        ExibirOpcoesDoMenu();
    }
}
