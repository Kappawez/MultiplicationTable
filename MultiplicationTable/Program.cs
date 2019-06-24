using System;


namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stage1(3);
            MultiplicationTable(3,10);
        }

        private static void Stage1(int maxA)
        {
            for (int i = 1; i <= maxA; i++)
            {
                Console.WriteLine($"{i} * {maxA} = {i * maxA}");
            }
        }

        private static void MultiplicationTable(int maxA, int maxB)
        {
            for (int i = 1 ; i <= maxA; i++)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                // skriver med Unicode

                Console.WriteLine("\u250f\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                                   "\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                                   "\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                                   "\u2501\u2501\u2501\u2501\u2513");
                Console.WriteLine($"\u2503 Multiplication table for {i}  \u2503");
                Console.WriteLine("\u2517\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                    "\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                    "\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501" +
                    "\u2501\u2501\u2501\u2501\u251b");

                for (int a = 1; a <= maxB; a++)
                {
                    
                    Console.WriteLine($"{i} * {a} = {i * a}");
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
