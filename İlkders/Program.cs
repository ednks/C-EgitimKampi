using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Selam");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");


            //usingler kütüphane işlemini görüyor. Neyi kullanacaksan ilgili kütüphaneye eklemek gerekir.
            //namespace proje ismi

            //Yazdırma Komutları
            // console.write yazdım mesela yanında mor renkli küp çktı bu onun method olduğunu gösterir. Parantez içine ise methodun çıktıları yazılır.
            //console.read ise açılan sayfanın(starta bastıktan sonra) beklemesini sağlıyor vve entera basana kadar kalıyor
            //console.writeline selamı yanına yazıyor ama imleci alta atıyor.



            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            string name;
            name = "Edanur";
            Console.Write(name);
            //değişken türü yazarken ilk kelimenin harfi küçük ikincisi büyük olmalı
                       string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";
            Console.WriteLine("***** Rezervasyon Kartı ******");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 500 400 80 70";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";


            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //int : tam sayı türündeki değişkenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 250;
            int cokePrice = 35;
            int waterPrice= 10;
            int friesPrice = 90;
            int pizzaPrice = 200;
            int lemonadePrice = 40;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0; //0 burda başlangıç sayısı
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
                waterCount = 3;
                friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            cokeCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice ;
            totalWaterPrice = waterCount * waterPrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice= totalCokePrice+totalFriesPrice+totalLemonadePrice+totalWaterPrice+totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam: " + totalPrice + "TL");
            #endregion

            Console.Read();
        
        
        }
    }
}








