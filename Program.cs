using System;

namespace Atividade1
{

	class Program
	{

		static void Main()
		{

			// Seção de Varíaveis
			int contInt = 0, contRept = 0, contV = 0, contF = 0, contRelev = 0, contInstr = 0, contRand=0;
			bool userChoices = false;
			string chave;
			DateTime dtStart;
			TimeSpan difTimes;



			// Variável de atribuição de tempo
			dtStart = DateTime.Now;


			Console.WriteLine("Horário de Início: "+dtStart); contInstr++;
			contInt += 1; contInstr++; // Início de Contagem de Interações com Usuários.

			while (contRept != 1000) // Repetição 1
			{
				contInstr++; // Contador de Instruções
				contRelev++; // Contador de Instruções Relevantes
				contRept++; // Contador de Repetições
				Console.WriteLine("V ou F"); contInt += 1; contInstr++; 
				chave = Console.ReadLine(); contInt += 1; contInstr++;

				
				if ((chave == "V") || (chave == "v")) { userChoices = true; contV++; // Ramificação 1 
					Console.WriteLine("Verdadeiro!"); contInt++; contInstr++; // Contador de Verdadeiros
					contRelev++; contInstr++;
				}
				else 
				{
					if ((chave == "F") || (chave == "f")) // Ramificação 2
					{
						userChoices = false; contF++; contInstr++; // Contador de Falsos
						Console.WriteLine("Falso"); contInt++; contInstr++;
						contRelev++; contInstr++;
					}
					else { Console.WriteLine("Declaracao Invalida!"); contInt ++; contRelev++; contInstr++; } // Ramificação 3
				}
			}

            while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 2"); // 1000 Iterações
			} contRand = 0; // Repetição 2
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 3");
			} contRand = 0; // Repetição 3
			 while (contRand != 10) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 4");
			} contRand = 0; // Repetição 4
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 5");
			} contRand = 0; // Repetição 5
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 6");
			} contRand = 0; // Repetição 6
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 7");
			} contRand = 0; // Repetição 7
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 8");
			} contRand = 0; // Repetição 8
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 9");
			} contRand = 0; // Repetição 9
			 while (contRand != 1000) { 
				contInstr++; contRept++; contRand++;
				Console.WriteLine("Repeticao 10");
			} contRand = 0; // Repetição 10



			Console.WriteLine("Tempo final de Execucao: "+DateTime.Now); contInt += 1;
			difTimes = DateTime.Now - dtStart;
			Console.WriteLine("Tempo gasto na Execucao: " + difTimes); contInt++;

			Console.WriteLine("Controle de Repeticoes: "+contRept); contInt += 1;
			Console.WriteLine("Controle de Verdadeiros: " + contV); contInt += 1;
			Console.WriteLine("Controle de Falsos: " + contF); contInt += 1;
			Console.WriteLine("Controle de Interacoes: "+ contInt);
			Console.WriteLine("Controle de Total de Instrucoes: " + contInstr);
		}

	}
}