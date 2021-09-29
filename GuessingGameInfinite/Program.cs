using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Sisesta numbrit:");
                int MyNumber = Convert.ToInt32(Console.ReadLine());
                int cpuNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuskik number on {cpuNumber}");
                if (MyNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Sa oled mängu võitnud!");
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine("Kahjuks, sa ei ole mängu võitnud. Proovi uuesti.");
                }
                    
                   
            }
            
         

            
            
               
               
                
            
            
                
                
                
                
            
        }
    }
}
