using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach(string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            //foreach (int number in numbers)
            //{
            //    if(number %2 == 1)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //int total = 0;
            //foreach (int k in numbers)
            //{
            //    total += k;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,
            //};
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region Örnek Sınav Sistemi
            Console.WriteLine("**** C# Eğitim Kampı Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine();
            #endregion

            Console.Read();

        }
    }
}
