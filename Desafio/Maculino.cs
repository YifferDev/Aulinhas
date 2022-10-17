using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Class
{
    class Maculino : Funcionario
    {
                  public int  Cpsm,       // Número de pessoas do sexo masculino​

                  Npsmrn;     // Número de pessoas do sexo masculino que responderam não​
           	 
                  public double Ppsmrn;     // Porcentagem de pessoas do sexo masculino que responderam não​

        public Maculino(int cpsm, int npsmrn, double ppsmrn, string sexo, string resposta, int nprs, int nprn) : base (sexo,resposta , nprs, nprn)
        {
            Cpsm = 0;
            Npsmrn = 0;
            Ppsmrn = 0;
        }
        public Maculino()
        {

        }

        public void PorcenMascRespNao()
        {
            if (Cpsm > 0)
            {
                Ppsmrn = ((Npsmrn * 100) / Cpsm);
                Console.WriteLine();
                Console.WriteLine("A porcentagem de pessoas do sexo masculino que participaram da pesquisa e \ndisseram não foi de: {0}%", Ppsmrn);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nenhum homem gostou do produto lançado no mercado...");
            }
        }

    }
}
