using System;
using System.Collections.Generic;

namespace Desafio
{
    class Quiz
    {
        Dictionary<string, List<dynamic>> quiz = new Dictionary<string, List<dynamic>>();

        string resposta;
        
        public void perguntas()
        {
            Console.WriteLine("Bem-vindo ao Quiz de Programação!");

            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine()!;
            quiz[nome] = new List<dynamic>();

            Console.Write("Qual sua idade? ");
            resposta = Console.ReadLine()!;
            int idade = int.Parse(resposta);
            quiz[nome].Add(idade);

            Console.Write("O que você está cursando? ");
            string curso = Console.ReadLine()!;
            quiz[nome].Add(curso);
        }

        public void exibirResultados()
        {
            foreach (var resposta in quiz)
            {
                Console.WriteLine($"{resposta.Key}, {resposta.Value[0]} anos, cursa {resposta.Value[1]}");
            } 
        }
    }
}
