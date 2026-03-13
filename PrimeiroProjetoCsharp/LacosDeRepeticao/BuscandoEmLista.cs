namespace Desafio;

class BuscandoEmLista
{
    List<string> nomeAlunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Mariana" };
    string nome;

    public void PesquisaAluno()
    {
        Console.Write("Digite o nome do aluno: ");
        nome = Console.ReadLine()!;
    }

    public void ProcuraAluno()
    {
        for (int i = 0; i < nomeAlunos.Count; i++)
        {
            if (nomeAlunos[i].Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Aluno encontrado na posição {i} da lista.");
                break;
            }
            if (i == nomeAlunos.Count - 1)
            {
                Console.WriteLine("Aluno não está presente na lista.");
            }
        }
    }   
    
    public void BuscaEmLista()
    {
        PesquisaAluno();
        ProcuraAluno();
    }
}
