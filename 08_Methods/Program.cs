﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metolar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametre Metotlar
            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Ali ");

            //void CustomerCard(string name, string surNmae)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surNmae);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ali", "");
            //CustomerCard("Ali", "Kılıç");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametre Metotlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametre Metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "-Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametre Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama
            //int ExamResult(string student, int exam1,  int exam2, int exam3)
            //{
                
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    string sonuc = student + "İsimli öğrenci geçti" + "Ortalama: " + result;
            //    if (result >= 50)
            //    {
            //        return result;
            //    }
            //    else
            //    {
            //        return result;
            //    } 
            //}
            //Console.WriteLine(ExamResult("Ali", 50, 70, 45));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion
            //Console.Read();
        }
    }
}
