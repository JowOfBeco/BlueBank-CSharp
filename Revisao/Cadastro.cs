using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class Cadastro
    {
        public string Nome;
        public string Senha;
        public string Idade;
        public string Endereco;

        public void User(string _nome, string _senha, string _idade, string _endereco)
        {
            Nome = _nome;
            Senha = _senha;
            Idade = _idade;
            Endereco = _endereco;
        }
        public void MostrarDados(string _nome, int _idade, string _endereco)
        {

            Console.WriteLine("Vamos imprimir seus dados!");
            Console.WriteLine(_nome, _idade, _endereco);
        }

        public void Usuario()
        {
            Console.WriteLine("Cadastro de usuário iniciado.");
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a senha:");
            Senha = Console.ReadLine();
            while (Senha.Length < 6)
            {
                Console.WriteLine("Digite uma senha com mais que 6 digitos:");
                Senha = Console.ReadLine();
            }
            Console.WriteLine("Digite a idade:");
            Idade = Console.ReadLine();
            Console.WriteLine("Digite o endereco:");
            Endereco = Console.ReadLine();
        }
    }
}
