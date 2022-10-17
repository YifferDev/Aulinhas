using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Class
{
    class Funcionario
    {


       public string Sexo, Resposta;

       public int Nprs, Nprn;

        public Funcionario(string sexo, string resposta, int nprs, int nprn)
        {
            Sexo = sexo;
            Resposta = resposta;
            Nprs = 0;
            Nprn = 0;
        }

        public Funcionario()
        {

        }
    }
}
