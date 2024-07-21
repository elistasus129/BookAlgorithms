using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayının_kareleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2= Convert.ToInt32(Console.ReadLine());
            int sonuc= Convert.ToInt32(Math.Pow(sayi1,2))+Convert.ToInt32(Math.Pow(sayi2, 2));
            Console.WriteLine($"Sonuç:{sonuc}");
        }
    }
}
