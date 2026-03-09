namespace Desafio;

class CalculaDiametro
{
    double pi = 3.14159;
    double raio;

    public void CalcularDiametro()
    {
        Console.Write("Digite o valor do raio: ");
        raio = Convert.ToDouble(Console.ReadLine());
        double area = pi * raio * raio;
        double perimetro = 2 * pi * raio;
        Console.WriteLine($"Raio: {raio:F2}");
        Console.WriteLine($"Área do círculo: {area:F2}");
        Console.WriteLine($"Diâmetro do círculo: {perimetro:F2}");
    }
}
