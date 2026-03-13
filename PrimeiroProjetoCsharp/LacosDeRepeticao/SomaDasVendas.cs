namespace Desafio;

class SomaDasVendas
{
    public void vendas()
    {
        int valorVenda;
        int valorTotal = 0;

        do
        {
            Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
            valorVenda = int.Parse(Console.ReadLine()!);

            valorTotal += valorVenda;
        } while (valorVenda != 0);

        Console.WriteLine($"\nTotal de vendas do dia: {valorTotal:C}");
    }
}
