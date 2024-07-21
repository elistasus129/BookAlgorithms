using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sayılarının_küpleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int toplam = 0;
            for (i = 0; i <= 100; i++)
            {
                toplam = toplam + (i * i * i);
            }

            Console.WriteLine(toplam.ToString());
        }
    }
}
