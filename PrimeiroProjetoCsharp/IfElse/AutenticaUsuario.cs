using System.ComponentModel.Design;

namespace Desafio;

class AutenticaUsuario
{
    string username = "";
    List<string> usuarios = new List<string>();

    public string login()
    {
        while(true)
        {
            Console.Write("Digite seu nome de usuário: ");
            username = Console.ReadLine()!;
             if (username == "admin")
            {
                return $"Bem-vindo, {username}!";
            }
            else
            {
                Console.WriteLine("Usuário não cadastrado. Escolha uma opção no menu:");
                return menu()!;
            }
        }
    }

    public string cadastrarUsuario()
    {
        usuarios.Add(username);

        return $"Novo usuário {username} cadastrado com sucesso!";
    }

    public string acessarComoConvidado()
    {
        return "Acesso concedido como convidado.";
    }

    public string sairDoSistema()
    {
        return "Saindo do sistema. Até logo!";
    }

    public string menu()
    {
        string resposta;

        do
        {
            Console.WriteLine("\nO que você deseja?");
            Console.WriteLine("1 - Cadastrar novo usuário");
            Console.WriteLine("2 - Acessar como convidado");
            Console.WriteLine("3 - Sair do sistema\n");
            resposta = Console.ReadLine()!;

            switch (resposta)
            {
                case "1": 
                    return cadastrarUsuario();
                case "2": 
                    return acessarComoConvidado();
                case "3": 
                    return sairDoSistema();
                default: 
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        } while (true);
    }

    public void Executar()
    {
        Console.WriteLine(login());
    }
}
