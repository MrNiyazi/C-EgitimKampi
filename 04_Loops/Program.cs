﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //int i;
            //for (i=1; i<=5;  i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i<=20;  i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<=50 ; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana Yazılmasını istediğiniz adedi giriniz");
            //int finisValue = int.Parse(Console.ReadLine());

            //for (int i = 1;  i <= finisValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cuhuriyet");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapısı
            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        totalValue+=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if(i%7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i= 1; i <= 24; i++)
            //{
            //    bacterium *= 22;
            //    Console.WriteLine(i + ".Saat Sonunda:" + bacterium);
            //}
            #endregion

            #region While döngüsü
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Kalvyeden girilen 3 basamaklı sayı
            //Console.Write("Sayıyı Giriniz:");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hunders;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hunders = number / 100;

            //sum = ones + tens + hunders;

            //Console.WriteLine(sum);


            #endregion
            Console.ReadLine();
        }
    }
}
