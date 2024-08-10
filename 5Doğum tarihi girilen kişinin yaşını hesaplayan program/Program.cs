using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Doğum_tarihi_girilen_kişinin_yaşını_hesaplayan_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int dyili, yas;
                DateTime yil;
                yil = DateTime.Now;
                Console.Write("Doğum yılını giriniz = ");
                dyili = Convert.ToInt32(Console.ReadLine());
                yas = yil.Date.Year - dyili;
                Console.Write("Yaş = " + yas);
                Console.ReadLine();
            }
        }
    }
}