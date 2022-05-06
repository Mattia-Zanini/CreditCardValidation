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
                for (int i = 0; i < PAN.Length; i++)
                {
                    PAN[i] = rand.Next(0, 10);
                    strPAN += PAN[i].ToString();
                    //Console.WriteLine(PAN[i]);
                    if (i % 2 == 0)
                    {
                        int x2 = 2 * PAN[i];
                        if(x2 > 9)
                        {
                            /*string magg = x2.ToString();
                            int somma = Convert.ToInt32(magg[0].ToString()) + Convert.ToInt32(magg[1].ToString());*/
                            int somma = x2 - 9;
                            tot += somma;
                        }
                        else
                            tot += x2;
                    }
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
