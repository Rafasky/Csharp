using System;
using System.Collections.Generic;

namespace Desafio
{
    class EstoqueLoja
    {
        Dictionary<string, int> estoque = new Dictionary<string, int>
        {
            ["Camiseta"] = 50,
            ["Calça"] = 30,
            ["Tênis"] = 20
        };

        public void ExibirEstoque()
        {
            Console.WriteLine("Estoque da Loja:\n");
            foreach (var item in estoque)
            {
                Console.WriteLine($"{item.Key}: {item.Value} unidades");
            }
        }
    }
}
