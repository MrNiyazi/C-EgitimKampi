using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi ****");
            double applePrice, orongePrice, strawberryPrice, poatoPrice, tomatoPrice;

            applePrice = 14.85;
            orongePrice = 20.95;
            strawberryPrice = 45;
            poatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice);
            Console.WriteLine("---- Portakal Birim Fiyatı:" + orongePrice);
            Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice);
            Console.WriteLine("---- Patates Birim Fiyatı:" + poatoPrice);
            Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice);
            
            double appleGram, orangeGram, strawberryGram, poatoGram,tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            poatoGram = 4.859;
            tomatoGram = 3.745;

            double totalPrice = (applePrice * appleGram) + (orangeGram * orongePrice) + (strawberryGram * strawberryPrice) + (poatoGram * poatoPrice) + (tomatoPrice * tomatoGram);
            double appletotalPrice = (applePrice * appleGram);

            Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
                "-Gramaj:" + appleGram + "-Toplam Tutar:" +appletotalPrice);


            Console.WriteLine("Toplam Fiyat:" + totalPrice);

            #endregion


            Console.Read();
        }
    }
}
