using System;

namespace DiceGame
{
	class Program
	{
		static void Main(string[] args)
		{
			//mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
			//mõlemad mängijad viskavad täringuid;
			//programm kontrollib, kumb mängija viskas rohkem;
			//mängija, kes viskas rohkem, ongi mängu võtja;
			//*täringuid visatakse kolm korda;
			//programm kuulutab võitjat.



			int a = 0;

			while (a < 3)
			{
					Random rnd = new Random();

					int cpuScore = 0;
					int userScore = 0;
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine(i + 1);
						//arvuti vise
						int cpuRandom = rnd.Next(1, 6);
						//kasutaja vise
						int userRandom = rnd.Next(1, 6);

				

						Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

						if (cpuRandom < userRandom)
						{
						Console.WriteLine("See kord Kasutaja on võitnud. Palju õnne!");
						userScore = userScore + 1;
						}
						else if (cpuRandom > userRandom)
						{
						Console.WriteLine("See kord Arvuti on võitnud. Palju õnne!");
						cpuScore = cpuScore + 1;
						}
						else
						{
						Console.WriteLine("Viik!");
						}
						
						a++;
					}

					Console.WriteLine("Mängu tulemus:");
					Console.WriteLine($"Mängu skoor: Arvuti {cpuScore} - {userScore} Kasutaja");


				if (cpuScore > userScore)
				{
					Console.WriteLine("Arvuti on mängu võitnud.Palju õnne!");
				}
				else if (cpuScore < userScore)
				{
					Console.WriteLine("Kasutja on mängu võitnud.Palju õnne!");
				}
				else
				{
					Console.WriteLine("Viik!");
				}
			}
			
		}
	}
}
