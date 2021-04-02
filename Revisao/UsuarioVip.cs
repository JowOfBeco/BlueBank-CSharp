using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class UsuarioVip : Cadastro
    {
        public void UserVip(string _nome, string _senha, string _idade, string _endereco)
        {
            Nome = _nome;
            Senha = _senha;
            Idade = _idade;
            Endereco = _endereco;
        }
    }
}
//Classe incompleta ainda.