using System;

namespace CreditCardValidation
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            bool isValid = false;
            string[] PAN = GeneratePAN();
            do
            {
                int tot = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        string ch = PAN[i][j].ToString();
                        //Console.WriteLine(ch);
                        if (j % 2 == 0)
                            tot += 2 * Convert.ToInt32(ch);
                        else
                            tot += Convert.ToInt32(ch);
                    }
                }
                if (tot % 10 == 0)
                    isValid = true;
                else
                {
                    Console.WriteLine("Invalid PAN\n");
                    PAN = GeneratePAN();
                }
            } while (!isValid);
            Console.WriteLine($"Valid PAN:\n{PAN[0]} {PAN[1]} {PAN[2]} {PAN[3]}");
        }
        static string[] GeneratePAN()
        {
            string[] PAN = new string[4];
            for (int i = 0; i < 4; i++)
            {
                PAN[i] = rand.Next(1111, 10000).ToString();
                //Console.WriteLine("Generated PAN: " + PAN[i]);
            }
            return PAN;
        }
    }
}
