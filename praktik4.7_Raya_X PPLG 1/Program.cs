using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik4._7_Raya_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("Predikat: A");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Predikat: B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Predikat: B");
            }
            else
            {
                Console.WriteLine("Predikat: D");
            }
        }
    }
}
