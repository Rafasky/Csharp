namespace Desafio;

class AcessoAreaRestrita
{
    string senha = "42";
    int nivelAcesso;

    public void VerificarAcesso()
    {
        Console.Write("Digite a senha de acesso: ");
        string senhaDeAcesso = Console.ReadLine()!;
        Console.Write("Digite o nível de acesso: ");
        nivelAcesso = int.Parse(Console.ReadLine()!);

        if (senha == senhaDeAcesso && nivelAcesso > 5)
        {
            Console.WriteLine("Acesso concedido.");
        }
        else
        {
            Console.WriteLine("Acesso negado. Senha ou nível de acesso inválidos.");
        }
    }
}
