using System;

namespace Francesco1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 163, resto;
            string binario = "";
            while (Num > 0)
            {
                resto = Num % 2;
                Num /= 2;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero è {binario}");
            Console.ReadLine();
        }
    }
}
