using System;

namespace uppgift_4_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nSkriv in en sträng: "); string input1 = Console.ReadLine();
            Console.Write("\nSkriv in två tecken (t.ex. \"ac\" eller \"lk\"): "); string input2 = Console.ReadLine();

            char[] tecken = input2.ToCharArray();

            if (input1.Contains(tecken[0]) && input1.Contains(tecken[1]))
            {
                Console.WriteLine("\nDin sträng innehåller båda dina två tecken.");
            }
            else if (input1.Contains(tecken[0]) || input1.Contains(tecken[1]))
            {
                Console.WriteLine("\nDin sträng innehåller ett av dina två tecken.");
            }
            else
            {
                Console.WriteLine("\nDin sträng innehåller inte någon av dina två tecken.");
            }
        }
    }
}
