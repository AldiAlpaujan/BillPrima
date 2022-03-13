using System;

namespace BillPrima
{
    class Program
    {
        static void MencariBilPrima()
        {
            int bilangan;
            int jumlahDibagi = 0;
            bool prima = true;

            Console.Write("Masukan Bilangan : ");
            bilangan = Convert.ToInt32(Console.ReadLine());

            if (bilangan <= 1)
            {
                Console.WriteLine($"{bilangan} Adalah bukan bilangan prima");
            }
            else
            {
                for (int i = 1; i <= bilangan; i++)
                {
                    if (bilangan % i == 0)
                    {
                        jumlahDibagi += 1;
                    }
                    if (jumlahDibagi > 2)
                        prima = false;
                    else
                        prima = true;
                }
                if (prima)
                {
                    Console.WriteLine($"{bilangan} Adalah bilangan prima");
                }
                else
                {
                    Console.WriteLine($"{bilangan} Adalah bukan bilangan prima");
                }
            }
                

            MencariBilPrima();
        }
        static void Main(string[] args)
        {
            MencariBilPrima();
        }
    }
}
