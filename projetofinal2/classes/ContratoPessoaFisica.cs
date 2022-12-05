using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal2.classes
{
    class ContratoPessoaFisica : Contrato
    {
        public string CPF { get; set; }
        public int Idade { get; set; }

        public ContratoPessoaFisica()
        {
        }

        public ContratoPessoaFisica(string cPF, int idade, int numero, string contratante, double valor, int prazoMeses) : base (numero, contratante, valor, prazoMeses)
        {
            CPF = cPF;
            Idade = idade;
        }

        public override double CalcularPrestacao()
        {
            if (Idade <= 30)
            {
                return base.CalcularPrestacao() + 1;
            } 
             
            else if (Idade <= 40 && Idade > 30)
            {
                return base.CalcularPrestacao() + 2;
            }

            else if (Idade <= 50 && Idade > 40)
            {
                return base.CalcularPrestacao() + 3;
            }

            else
            {
                return base.CalcularPrestacao() + 4;
            }
        }
        public override void ExibirInfo()
        {
            Console.WriteLine("Valor do contrato: R$" + Valor.ToString("F2") + "// Prazo: " + PrazoMeses + " Meses // Prestação: " + CalcularPrestacao().ToString("F2"));
        }
    }
}
