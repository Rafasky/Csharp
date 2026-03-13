namespace Desafio;

class NumeroSecreto
{
    public void numSecreto()
    {
        int numChute;
        const int numSecreto = 7;

        do
        {
            Console.Write("Digite um número entre 1 e 10: ");
            numChute = int.Parse(Console.ReadLine()!);

            Console.WriteLine(numChute == numSecreto ? "Parabéns! Você acertou o número secreto!" : "Tente novamente!");
        } while (numChute != numSecreto);
    }
}
