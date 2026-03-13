namespace Desafio;

class SenhasDeAtendimento
{
    int senha = 000;
    string acao;
    List<string> senhasGeradas = new List<string>();
    public void Acoes()
    {
        Console.WriteLine("\nEscolha uma ação:\n");
        Console.WriteLine("1 - Gerar nova senha");
        Console.WriteLine("2 - Chamar próximo cliente");
        Console.WriteLine("3 - Sair\n");
        acao = Console.ReadLine()!;

        switch (acao)
        {
            case "1":
                GerarSenha();
                Acoes();
                break;
            case "2":
                ChamarProximaSenha();
                Acoes();
                break;
            case "3":
                Console.WriteLine("Encerrando o programa...");
                break;
            default:
                Console.WriteLine("Opção inválida,~~ Tente novamente.");
                Acoes();
                break;
        }
    }

    public void GerarSenha()
    {
        while (senha < 999)
        {
            senha++;
            string senhaFormat = senha.ToString("D3");
            Console.WriteLine($"Senha gerada: {senhaFormat}");
            senhasGeradas.Add(senhaFormat);
            senha = Convert.ToInt32(senhaFormat);
            break;
        }
        if (senha >= 999)
        {
            senha = 000;
        }
    }

    public void ChamarProximaSenha()
    {
        if (senhasGeradas.Count == 0)
        {
            Console.WriteLine("Nenhuma senha para chamar. Por favor, gere uma nova senha.");
        }
        else
        {
            Console.WriteLine($"Senha chamada: {senhasGeradas[0]}");
            senhasGeradas.RemoveAt(0);
        }
    }
}
