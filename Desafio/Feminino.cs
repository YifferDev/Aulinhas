using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Class
{
    class Feminino : Funcionario
    {

        public int Cpsf, Npsfrs;    

        public double Ppsfrs;

        public Feminino(int cpsf, int npsfrs, double ppsfrs, string sexo, string resposta, int nprs, int nprn) : base(sexo, resposta, nprs, nprn)
        {
            Cpsf = 0;
            Npsfrs = 0;
            Ppsfrs = 0;
        }

        public Feminino()
        {

        }

        public void PorcenFemiRespSim()
        {
            if (Cpsf > 0)
            {
                Ppsfrs = ((Npsfrs * 100) / Cpsf);
                Console.WriteLine();
                Console.WriteLine("A porcentagem de pessoas do sexo feminino que participaram da pesquisa e \ndisseram sim foi de: {0}%", Ppsfrs);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nenhuma mulher gostou do produto lançado no mercado...");
            }
        }


    }
}
