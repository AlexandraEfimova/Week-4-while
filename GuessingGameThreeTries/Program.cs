using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on 3 kaitset, kui kasutajal ei ole suutnud kolme katsega numbrit ära arvata,siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit ühte korda.


            Random rnd = new Random();
            
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta numberit:");
                int myNumber = Convert.ToInt32(Console.ReadLine());
                int cpuNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuskik number on {cpuNumber}");
                if ( myNumber == cpuNumber )
                {
                   
                    Console.WriteLine("Palju õnne! Sa oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Kahjuks, vale number. {3 - i} katset on jäänud.");
                    
                }

            }
            if (i == 3)
            {
                Console.WriteLine("Kasutasid kõiki katseid. Mängu võidab arvuti.");
            }
        }

    }
}
