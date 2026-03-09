namespace Desafio;

class ClassificaFaixaEtaria
{
    int idade;

    public void faixaEtaria()
    {
        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine("Faixa etária infantil.");
        }
        else if(idade <= 17)
        {
            Console.WriteLine("Faixa etária adolescente.");
        }
        else if(idade <= 59)
        {
            Console.WriteLine("Faixa etária adulta.");
        }
        else
        {
            Console.WriteLine("Faixa etária idosa.");
        }
    }
}
