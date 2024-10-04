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

            //Console.WriteLine("***** Fiyat Listesi ****");
            //double applePrice, orongePrice, strawberryPrice, poatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orongePrice = 20.95;
            //strawberryPrice = 45;
            //poatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orongePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı:" + poatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, poatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //poatoGram = 4.859;
            //tomatoGram = 3.745;

            //double totalPrice = (applePrice * appleGram) + (orangeGram * orongePrice) + (strawberryGram * strawberryPrice) + (poatoGram * poatoPrice) + (tomatoPrice * tomatoGram);
            //double appletotalPrice = (applePrice * appleGram);

            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);
            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice +
            //    "-Gramaj:" + appleGram + "-Toplam Tutar:" + appletotalPrice);


            //Console.WriteLine("Toplam Fiyat:" + totalPrice);

            #endregion

            #region char değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişi

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Sayısı ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir:");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Numarası:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine(passengerName + " " + passengerSurname + " " + passengerDistrict + "/" +passengerCity + " " + passengerAge + " " + passengerIdentityNumber );
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri
            //int shoesPrice, computerPrice, chaairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chaairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chaairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chaairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chaairPrice * chaairCount + tvPrice * tvCount;
            //Console.WriteLine("toplam fiyat:"+totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3;
            //Console.Write("1. Sınav notunu giriniz:");
            //exam1= double.Parse(Console.ReadLine());
            //Console.Write("2.Sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3.Sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //double ort= (exam1 + exam2 + exam3)/3;

            //Console.WriteLine("");
            //Console.WriteLine("Ortalamanız:" + ort);
            #endregion

            #region Klavyeden Karakte Girişleri


            
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);
            #endregion


            Console.Read();
        }
    }
}
