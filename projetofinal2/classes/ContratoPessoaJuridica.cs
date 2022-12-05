using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace projetofinal2.classes
{
    class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }

        public ContratoPessoaJuridica()
        {
        }

        public ContratoPessoaJuridica(string cNPJ, string inscricaoEstadual, int numero, string contratante, double valor, int prazoMeses) : base(numero, contratante, valor, prazoMeses)
        {
            CNPJ = cNPJ;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override double CalcularPrestacao()
        {
            return base.CalcularPrestacao() + 3;
        }
        public override void ExibirInfo()
        {
            Console.WriteLine("Valor do contrato: R$" + Valor.ToString("F2") + "// Prazo: " + PrazoMeses + " Meses // Prestação: " + CalcularPrestacao().ToString("F2"));
        }
    }
}
