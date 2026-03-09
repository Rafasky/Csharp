namespace Desafio;

class SistemaDeRecompensa
{
    string cupomRecompensa;

    public void verificaCupomRecompensa()
    {
        Console.Write("Digite o numero do cupom: ");
        cupomRecompensa = Console.ReadLine()!;

        string mensagem = cupomRecompensa.ToUpper() switch
        {
            "DOBRAR" => "Parabéns! Você ganhou 2x EXP por 1 hora.",
            "CURAR" => "Parabéns! Você ganhou poção de cura.",
            "OURO" => "Parabéns! Você ganhou 1000 moedas de ouro.",
            "ESPECIAL" => "Parabéns! Você ganhou item lendário.",
            _ => "Recompensa indisponível."
        };

        Console.WriteLine(mensagem);
    }
}
