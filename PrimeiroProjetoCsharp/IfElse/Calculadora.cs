namespace Desafio;

class Calculadora
{
    double num1;
    double num2;
    char operacao;
    List<char> operacoes = new List<char> { '+', '-', '*', '/' };

    public void calcular()
    {
        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("Escolha a operação que quer fazer: ");
        operacao = char.Parse(Console.ReadLine()!);

        if (operacoes.Contains(operacao))
        {
            realizaOperacao();
        }
        else
        {
            Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
        }
    }

    public void realizaOperacao()
    {
        double resultado = operacao switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Não é possível dividir por zero."),
            _ => throw new InvalidOperationException("Operação inválida.")
        };
        Console.WriteLine($"O resultado da operação {num1} {operacao} {num2} é: {resultado}");
    }
}
