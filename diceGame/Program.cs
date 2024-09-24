using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace diceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* while (true)
            {
                Console.WriteLine("Trykk på en tilfeldig knapp for å rulle terning: ");
                Console.ReadKey();
                Console.WriteLine();

                playerRandomNum = random.Next(1, 7);
                enemyRandomNum = random.Next(1, 7);

                Console.WriteLine($"Du fikk {playerRandomNum}, motstander fikk {enemyRandomNum}");
                Thread.Sleep(200); */


            int enemyRandomNum;
            int playerRandomNum;

            int score = 0;
            int sjanse = 1;

            Random random = new Random();
            for (int i = 0; i < sjanse; i++)
            {
              Console.WriteLine("Trykk på en tilfeldig knapp for å rulle terning: ");
                Console.ReadKey();
                Console.WriteLine("\n");
                playerRandomNum = random.Next(1, 7);
                Console.Write("Du fikk " + playerRandomNum);

                enemyRandomNum = random.Next(1, 7);
                Console.Write(" Motstander fikk " + enemyRandomNum);
                Console.WriteLine();

                if (enemyRandomNum > playerRandomNum)
                {
                    Console.WriteLine("Du tapte dessverre!");
                    score = 0;
                    Console.WriteLine("Din streak: " + score);

                    Console.WriteLine("Vil du starte på nytt? trykk \"1 + [enter]\" " + "for å avslutte trykk: [enter]");
                    bool isValid = int.TryParse(Console.ReadLine(), out int svar);

                    if (isValid)
                    {
                        if (svar == 1)
                        {
                          sjanse++;
                          Console.WriteLine("Starter på nytt ..");
                        }
                    }
                    else
                    {
                      Console.WriteLine("Takk for at du spilte!");
                      break;
                    }
                }
                else if (enemyRandomNum == playerRandomNum)
                {
                    Console.WriteLine("Det ble uavgjort!");
                    sjanse++;
                    Console.WriteLine("Din streak: " + score);
                }
                else
                {
                    Console.WriteLine("Du vant!");
                    sjanse++;
                    score++;
                    Console.WriteLine("Din streak: " + score);
                }
                Console.WriteLine();
            }
        }
    }
}
