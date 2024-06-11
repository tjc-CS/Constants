using System;

namespace ConsoleApp12
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello year 12 +year 13");
            Console.WriteLine(Cons.MAX_PLAYERS + Cons.NUMBER_OF_CARDS);
            Cons.print();
            int[] cards = new int[Cons.NUMBER_OF_CARDS];
            for(int i = 0; i<Cons.NUMBER_OF_CARDS; i++)
            {
                cards[i] = 1;
            }

        }
    }
}
