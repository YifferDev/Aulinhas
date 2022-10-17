using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
			
			// Exibe uma linha na tela
			Console.WriteLine("\t\t______________________________________________________");
			Console.WriteLine("\t\tCalcula a resposta (sim ou não) em uma pesquisa de satisfação!\n");

			// Declaração de Variáveis

			Desafio.Class.Funcionario f = new Desafio.Class.Funcionario();

			Desafio.Class.Feminino fem = new Desafio.Class.Feminino();

			Desafio.Class.Maculino m = new Desafio.Class.Maculino();

			// Estrutura de repetição for

			for (int cont = 1; cont <= 5; cont++)
			{
				// Solicita e lê os dados do entrevistado(a)
				Console.Write("Informe o sexo, F: (Feminino) ou M: (Masculino): ");
				f.Sexo = Console.ReadLine();

				Console.Write("Informe a resposta, S: (Sim) ou N: (Não): ");
				f.Resposta = Console.ReadLine();

				// Verifica o número de entrevistados que disseram sim ou não
				if ((f.Resposta == "s") || (f.Resposta == "S") || (f.Resposta == "Sim") || (f.Resposta == "SIM") || (f.Resposta == "sim"))
				{
					f.Nprs += 1;  // Poderia ser escrito assim nprs++ ou nprs = nprs + 1;
				}
				else
				{
					f.Nprn += 1;  // Poderia ser escrito assim nprn++ ou nprn = nprn + 1;
				}

				// Verifica o número de entrevistados que são do sexo feminino ou  masculino
				if ((f.Sexo == "F") || (f.Sexo == "f") || (f.Sexo == "feminino") || (f.Sexo == "Feminino") || (f.Sexo == "FEMININO"))
				{
					fem.Cpsf = fem.Cpsf + 1;
				}
				else
				{
					m.Cpsm = m.Cpsm + 1;
				}

				// Verifica o número de entrevistados que são do sexo feminino e responderam sim
				if ((f.Sexo == "F") || (f.Sexo == "f") || (f.Sexo == "feminino") || (f.Sexo == "Feminino") || (f.Sexo == "FEMININO") && (f.Resposta == "S") || (f.Resposta == "Sim") || (f.Resposta == "SIM") || (f.Resposta == "sim"))
				{
					fem.Npsfrs = fem.Npsfrs + 1;
				}

				// Verifica o número de entrevistados que são do sexo masculino e responderam não
				if ((f.Sexo == "M") || (f.Sexo == "m") || (f.Sexo == "masculino") || (f.Sexo == "Masculino") || (f.Sexo == "MASCULINO") && (f.Resposta == "n") || (f.Resposta == "N") || (f.Resposta == "Não") || (f.Resposta == "NÃO") || (f.Resposta == "não"))
				{
					m.Npsmrn = m.Npsmrn + 1;
				}
			}// Fim da estrutura de repetição For

			// Verifica se houve pessoas do sexo feminino entrevistadas
			// E calcula a porcentagem de pessoas entrevistadas que disseram sim
			fem.PorcenFemiRespSim();
			m.PorcenMascRespNao();

			// Exibe o resultado total de pessoas que responderam sim
			Console.WriteLine();
			Console.WriteLine("O total de pessoas que responderam sim foi de: {0} pessoas", f.Nprs);

			// Exibe o resultado total de pessoas que responderam não
			Console.WriteLine();
			Console.WriteLine("O total de pessoas que responderam não foi de: {0} pessoas", f.Nprn);
			Console.WriteLine();

			// Exibe uma linha em branco na tela
			Console.WriteLine();

		} // Fim do método Main

	} // Fim da Classe Pesquisa​

}