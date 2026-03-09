using System;
using System.Collections.Generic;

namespace Destino
{
    class SistemaDeLogin
    {
        Dictionary<string, string> Login = new Dictionary<string, string>
        {
            ["admin"] = "admin123",
            ["usuario"] = "senha456",
            ["convidado"] = "convidado789"
        };

        public void VerificarLogin()
        {
            Console.Write("Digite seu nome de usuário: ");
            string usuario = Console.ReadLine()!;
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine()!;

            if (Login.ContainsKey(usuario) && Login[usuario] == senha)
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
            }
        }
    }
}
