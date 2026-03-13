namespace Desafio;

class WhileEDoWhile
{
    public void contadorRegressivo()
    {
        int contador = 10;

        while (contador >= 0)
        {
            Console.WriteLine(contador);
            contador--;
        }

        Console.WriteLine("Contagem regressiva concluída!");
    }
}
