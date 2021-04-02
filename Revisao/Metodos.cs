using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class Metodos
    {

        public int Deposito(int _saldo, int _deposito)
        {
            return _saldo + _deposito;
        }
        public int Saque(int _saldo, int _saque)
        {
            if (_saque > _saldo)
            {
                Console.WriteLine("Saldo insuficiente, tente novamente.");
            }
            return _saldo - _saque;
        }
        public int Consulta(int _saldo)
        {
            return _saldo;
        }

        public void Valida()
        {
            int saldo = 1000;
            Metodos user = new Metodos();
            Cadastro pessoa = new Cadastro();

            pessoa.Usuario(); //Isso aqui colei o main aqui e deu certo. Jesus desceu sobre mim e me discerniu.

            string[] list = { pessoa.Nome, Convert.ToString(pessoa.Idade), pessoa.Endereco }; // LISTA DO TIPO STRING SOLICITADAAAAAAAAA

            int valida = 0;
            while (valida != 99)
            {
                Console.WriteLine("Digite [1] para depósitos, [2] para saques, [3] para consulta de dados, [99] para sair:");
                valida = Convert.ToInt32(Console.ReadLine());
                if (valida == 1)
                {
                    Console.WriteLine("Digite o valor a ser depositado:");
                    int deposito = Convert.ToInt32(Console.ReadLine());
                    saldo = user.Deposito(saldo, deposito);
                }
                else if (valida == 2)
                {
                    Console.WriteLine("Digite o valor a ser sacado:");
                    int saque = Convert.ToInt32(Console.ReadLine());
                    saldo = user.Saque(saldo, saque);
                }
                else if (valida == 3)
                {
                    Console.WriteLine("O seu saldo atual é: " + user.Consulta(saldo));
                }

            }

            Console.WriteLine("Certo, você digitou 99, deseja visualizar os dados[1] ou alterar[2], para sair[99]?");
            valida = Convert.ToInt32(Console.ReadLine());
            while (valida != 99)
            {

                if (valida == 1)
                {
                    Console.WriteLine($"Nome : {list[0]}, idade : {list[1]} e endereco : {list[2]}");
                }
                else if (valida == 2)
                {

                    Console.WriteLine("Digite para alterar nome [0], idade [1], endereco[2]");
                    int valida2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Dado atual {list[valida2]}, digite o que gostaria de alterar:");
                    list[valida2] = Console.ReadLine();
                    Console.WriteLine($"Dados atualizados: Nome : {list[0]}, idade : {list[1]} e endereco : {list[2]}");
                }
                Console.WriteLine("Certo, você digitou 99, deseja visualizar os dados[1] ou alterar[2], para sair[99]?");
                valida = Convert.ToInt32(Console.ReadLine());
            }

        }

    }

}
