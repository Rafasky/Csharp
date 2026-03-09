namespace Desafio;

class SaudacaoPersonalizada
{
    public void decideSaudacao()
    {
        Console.Write("Qual é o momento do dia? (1 - manhã, 2 - tarde ou 3 - noite): ");
        string momentoDoDia = Console.ReadLine()!.ToLower();
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine()!;

        string saudacao = momentoDoDia switch
        {
            "1" => $"Bom dia, {nome}!",
            "2" => $"Boa tarde, {nome}!",
            "3" => $"Boa noite, {nome}!",
            _ => "Momento do dia inválido. Por favor, digite 'manhã', 'tarde' ou 'noite'."
        };

        Console.WriteLine(saudacao);
    }
}
