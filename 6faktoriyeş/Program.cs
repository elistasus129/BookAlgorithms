using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6faktoriyeş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sayi;
            int fak = 1;
            Console.Write("Sayıyı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = sayi; i > 1; i--)
            {
                fak = fak * i;
            }
            Console.Write("Faktoriyel = " + fak);
            Console.ReadLine();
        }
    }
}
