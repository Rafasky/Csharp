namespace Desafio;

class OrganizaLivros
{
    public void organizar()
    {
        Console.WriteLine("Digite o código do livro: ");
        int codigo = int.Parse(Console.ReadLine()!);

        string genero = codigo.ToString()[0] switch
        {
            '1' => "Ficção Científica",
            '2' => "Literatura Clássica",
            '3' => "Fantasia",
            '4' => "Romance",
            '5' => "Suspense/Mistério",
            '6' => "Não Ficção",
            '7' => "Biografias/Memórias",
            '8' => "Distopia",
            '9' => "Infantojuvenil",
            _ => throw new InvalidOperationException("Código inválido.")
        };

        Console.WriteLine($"Gênero: {genero}");
    }
}
