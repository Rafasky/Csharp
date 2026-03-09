namespace Desafio;

class VerificaSaldoDaConta
{
    double saldo;

    public void VerificarSaldo()
    {
        Console.Write("Digite o saldo da conta: ");
        saldo = Convert.ToDouble(Console.ReadLine());
        if (saldo < 0)
        {
            Console.WriteLine("Saldo negativo");
        }
        else if (saldo > 0)
        {
            Console.WriteLine("Saldo positivo");
        }
        else
        {
            Console.WriteLine("Saldo zero");
        }
    }
}
