using System;
using System.Collections.Generic;

namespace Desafio
{
    class DicionarioAluno
    {
        public Dictionary<string, List<double>> dicionarioDeAlunos = new Dictionary<string, List<double>>
        {
            ["Alexandre"] = new List<double> {9, 8, 9.5},
            ["Lauro"] = new List<double> {7, 6.5, 8},
            ["Maria"] = new List<double> {10, 9.5, 9.8 }
        };

        public double CalcularMedia(List<double> notas)
        {
            if (notas.Count == 0) return 0;
            return notas.Average();
        }

        public void mediaDaLista(Dictionary<string, List<double>> lista)
        {
            foreach (var aluno in lista)
            {
                double media = CalcularMedia(aluno.Value);
                Console.WriteLine($"A média do {aluno.Key} é: {media:F2}");
            }
        }
    }
}
