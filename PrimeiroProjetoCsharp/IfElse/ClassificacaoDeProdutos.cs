namespace Desafio;

class ClassificacaoDeProdutos
{
    string Perecivel = "1";
    string NaoPerecivel = "2";

    public void ClassificarProduto()
    {
        Console.WriteLine("Digite o tipo do produto: ");
        Console.WriteLine("1 - Perecível");
        Console.WriteLine("2 - Não Perecível\n");
        string tipoProduto = Console.ReadLine()!;
        if (tipoProduto == Perecivel)
        {
            Console.WriteLine("O produto é perecível.");
        }
        else if (tipoProduto == NaoPerecivel)
        {
            Console.WriteLine("O produto é não perecível.");
        }
        else
        {
            Console.WriteLine("Tipo de produto inválido.");
        }
    }
}
