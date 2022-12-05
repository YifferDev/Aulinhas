using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace projetofinal2.classes
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int PrazoMeses { get; set; }

        public Contrato()
        {
        }

        public Contrato(int numero, string contratante, double valor, int prazoMeses)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            PrazoMeses = prazoMeses;
        }
        
        public virtual double CalcularPrestacao()
        {
            return Valor / PrazoMeses;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Valor do contrato: R$" + Valor.ToString("F2") + "// Prazo: " + PrazoMeses + " Meses // Prestação: " + CalcularPrestacao().ToString("F2"));
        }
    }
}
