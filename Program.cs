using System;

namespace CreditCardValidation
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            bool isValid = false;
            int[] PAN = new int[16];
            string strPAN = "";
            do
            {
                int tot = 0;
                for (int i = 0; i < 16; i++)
                {
                    PAN[i] = rand.Next(0, 10);
                    strPAN += PAN[i].ToString();
                    //Console.WriteLine(PAN[i]);
                    if (i % 2 == 0)
                        tot += 2 * PAN[i];
                    else
                        tot += PAN[i];
                }
                if (tot % 10 == 0)
                    isValid = true;
                else
                {
                    Console.WriteLine("Invalid PAN\n");
                    PAN = new int[16];
                    strPAN = "";
                }
            } while (!isValid);
            Console.WriteLine($"Valid PAN:\n{strPAN}");
        }
    }
}
