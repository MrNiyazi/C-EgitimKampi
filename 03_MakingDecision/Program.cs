using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkent Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülke Giriniz:");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "turkiye")
            //{
            //    Console.Write("Veriler doğru");
            //}

            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if (number == 10)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış ");
            //}
            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine("Ortalaması:" +  average);

            //if (average>0 & average<50) 
            //{
            //    result = "Kaldı";
            //}
            //if (average>50 & average < 70)
            //{
            //    result = "Geçti";
            //}
            //if(average>70 & average < 85)
            //{
            //    result = "Teşekkür";
            //}
            //if(average>85 & average > 100)
            //{
            //    result = "Takdir";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz:");
            //city = Console.ReadLine();

            //if (city =="adana" | city=="ankara" | city=="bursa" | city=="giresun")
            //{
            //    Console.WriteLine("ŞEHİR MEVCUT");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayı ile 2. sayı bölümünden kalan:" + result);

            //Console.Write("Lütfen sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tek");
            //}

            //char team;
            //Console.Write("Lütfen takım Sembolünü giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Char Değişkenleri ile Karar Yapıları
            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemakler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçeçekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");

            //string menuItem;
            //Console.Write("Detayı Görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Tabağı");
            //}
            //if(menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Merco");
            //    Console.WriteLine("2-Ezogelin");
            //}
            //if(menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Karışık");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçeçekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //}
            #endregion

            #region Switch case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs");break;
            //    case 6: Console.Write("Haziran");break;
            //    case 7: Console.Write("Temmuz");break;
            //    case 8: Console.Write("Ağustos");break;
            //    case 9: Console.Write("Eylül");break;
            //    case 10: Console.Write("Ekim");break;
            //    case 11: Console.Write("Kasım");break;
            //    case 12: Console.Write("aralık");break;
            //}
            #endregion

            #region Switch Case Hesap Makinası
            int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniz İşlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam:" + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkarma:" + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma:" + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölme:" + result);
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
