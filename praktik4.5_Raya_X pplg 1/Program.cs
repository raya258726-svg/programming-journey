using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik4._5_Raya_X_pplg_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 17)
            {
                Console.WriteLine("Anda sudah dewasa.");
            }
            else
            {
                Console.WriteLine("Anda masih anak-anak.");
            }
        }
    }
}
