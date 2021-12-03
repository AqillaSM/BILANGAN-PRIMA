using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka : ");
            int Angka = Convert.ToInt16(Console.ReadLine);

            if (Angka < 2)
            {
                Console.WriteLine("Bukan Bilangan Prima");
            }
            else
            {
                int Perulangan = 2;
                while (Angka % Perulangan != 0)
                {
                    Perulangan++;
                }

                if (Angka == Perulangan)
                {
                    Console.WriteLine("Bilangan Prima");
                }
                else
                {
                    Console.WriteLine("Bukan Bilangan Prima");
                }
            }


        }
    }
}
