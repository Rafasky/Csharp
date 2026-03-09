namespace Desafio;

class ClassificaNotaAluno
{
    double notaAluno;

    public void ClassificarNota()
    {
        Console.Write("Digite a nota da aluno: ");
        notaAluno = Convert.ToDouble(Console.ReadLine());

        if (notaAluno >= 9)
        {
            Console.WriteLine("Nota A");
        }
        else if (notaAluno >= 7)
        {
            Console.WriteLine("Nota B");
        }
        else if (notaAluno >= 5)
        {
            Console.WriteLine("Nota C");
        }
        else
        {
            Console.WriteLine("Nota D");
        }
    }
}
