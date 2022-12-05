using System;
using System.Collections.Generic;
using System.Globalization;

namespace projetofinal2.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();

            Console.Write("Número de contratos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.Write("O contrato é de pessoa fisica ou juridica (F/J)? ");
                char Ch = char.Parse(Console.ReadLine());

                Console.Write("Número: ");
                int Numero = int.Parse(Console.ReadLine());

                Console.Write("Contratante: ");
                string Contratante = (Console.ReadLine());

                Console.Write("Valor: ");
                double Valor = double.Parse(Console.ReadLine());

                Console.Write("Prazo (em meses): ");
                int PrazoMeses = int.Parse(Console.ReadLine());


                if (Ch == 'F' || Ch == 'f')
                {
                    Console.Write("CPF: ");
                    string CPF = Console.ReadLine();

                    Console.Write("Idade: ");
                    int Idade = int.Parse(Console.ReadLine());

                    list.Add(new ContratoPessoaFisica(CPF, Idade, Numero, Contratante, Valor, PrazoMeses));
                }

                else
                {
                    Console.Write("CNPJ: ");
                    string CNPJ = Console.ReadLine();

                    Console.Write("Inscrição Estadual: ");
                    string InscricaoEstadual = Console.ReadLine();

                    list.Add(new ContratoPessoaJuridica(CNPJ, InscricaoEstadual, Numero, Contratante, Valor, PrazoMeses));
                }
                Console.WriteLine("");
                Console.Write("Contratos");
                Console.WriteLine("");

                foreach (Contrato con in list)
                {
                    con.ExibirInfo();
                }
                Console.WriteLine("");
                Console.WriteLine("----------------------//----------------------");
                Console.WriteLine("");
            }
        }
    }
}
