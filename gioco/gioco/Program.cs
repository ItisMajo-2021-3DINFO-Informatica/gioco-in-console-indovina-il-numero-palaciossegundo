using System;

namespace gioco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GiocoAltoBasso");
            
            Random N = new Random();
            int num = N.Next(1, 100);
            int t = 1;
            int i = 0;
            int punteggio = 200;
            while (t != num)
            {
                Console.WriteLine("Scrivi un numero: ");
                i++;
                t = Convert.ToInt32(Console.ReadLine());
                if(t < num)
                {
                    Console.WriteLine(""+ "numero piu alto" + "");
                }
                else if(t >num)
                {
                    Console.WriteLine("" + "numero piu basso" + "");
                }
                
            }
            Console.WriteLine("Il punteggio è di " + (punteggio - i * 10));
        }
    }
}
