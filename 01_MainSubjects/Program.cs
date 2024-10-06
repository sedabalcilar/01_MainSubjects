using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("merhaba dünya");
            //Console.Write("selams");
            //Console.Read();

            //Console.WriteLine("*** Yemek Kategorileri ***");
            //Console.WriteLine();
            //Console.WriteLine("1_Çorbalar");
            //Console.WriteLine("2_Ana yemekler");
            //Console.WriteLine("3_Soğuk başlangıçlar");
            //Console.WriteLine("4_Salatalar");
            //Console.WriteLine("5_Tatlılar");
            //Console.WriteLine("6_İçecekler");

            #endregion
            #region String Değişkenler
            //1-String
            //değişken_türü değişken_adı

            //string name;
            //name = "Seda";
            //Console.Write(name);

            //string customerName, customerSurname, customerPhone, customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Kaya";
            //customerPhone = "+90 1010";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("---- 1. Rezervasyon Kart ----");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri:"+" "+customerName+" "+customerSurname);
            //Console.WriteLine("Email Adresi:"+" "+customerEmail);
            //Console.WriteLine("İletişim::"+" "+customerPhone);
            //Console.WriteLine("Adres:"+" "+district+"/"+city);
            //Console.WriteLine("----------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Yılmaz";
            //customerPhone = "+90 2020 20 20";
            //customerEmail = "deneme2@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("---- 2. Rezervasyon Kart ----");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri:" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("Email Adresi:" + " " + customerEmail);
            //Console.WriteLine("İletişim::" + " " + customerPhone);
            //Console.WriteLine("Adres:" + " " + district + "/" + city);
            //Console.WriteLine("----------------------------------");
            #endregion
            #region Int Değişkenler
            //2. İnt 
            //int number =24;
            //Console.WriteLine(number);

            //int hamburgerPRice = 60;
            //int cokePrice = 20;
            //int waterPrice = 5;
            //int fricePrice = 50;
            //int pizzaPrice = 100;
            //int lemonadePrice = 30;

            //Console.WriteLine("*** Restoran Menü Fiyatı ***");
            //Console.WriteLine();
            //Console.WriteLine("Hamburger:" + hamburgerPRice + "TL");
            //Console.WriteLine("pizza:" + pizzaPrice + "TL");
            //Console.WriteLine("kola:" + cokePrice + "TL");
            //Console.WriteLine("limonata:" + lemonadePrice + "TL");
            //Console.WriteLine("su:" + waterPrice + "TL");
            //Console.WriteLine("kızartma:" + fricePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("*** Restoran Menü Fiyatı ***");
            
            //Console.WriteLine();

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friceCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalhamburgerPRice;
            //int totalcokePrice;
            //int totalwaterPrice;
            //int totalFricePrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 2;
            //waterCount = 3;
            //friceCount = 2;
            //pizzaCount = 4;
            //lemonadeCount = 4;

            //totalhamburgerPRice = hamburgerCount * hamburgerPRice;
            //totalwaterPrice = waterCount * waterPrice;
            //totalcokePrice= cokeCount * cokePrice;
            //totalFricePrice = friceCount * fricePrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;


            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Hamburger Tutarı:"+ totalhamburgerPRice);
            //Console.WriteLine("Su Tutarı:"+ totalwaterPrice);
            //Console.WriteLine("Kola Tutarı:"+ totalcokePrice);
            //Console.WriteLine("Pizza Turtarı:"+totalPizzaPrice );
            //Console.WriteLine("limonata tutarı:"+totalLemonadePrice);
            //Console.WriteLine("Kızartma Tutarı:"+ totalFricePrice);
            //Console.WriteLine();

            //int totalPrice = totalcokePrice + totalFricePrice + totalhamburgerPRice + totalLemonadePrice + totalPizzaPrice + totalwaterPrice;

            //Console.WriteLine("Toplam ödenecek tutar:" + totalPrice+ "TL");

            #endregion
            #region Double Değişkenler
            //double number;
            //number=4.85;
            //Console.WriteLine(number);

            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.89;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;


            Console.WriteLine("--- Elma Birim Fİyatı:" + applePrice);
            Console.WriteLine("--- Portakal Birim Fİyatı:" + orangePrice);
            Console.WriteLine("--- Çilek Birim Fİyatı:" + strawberryPrice);
            Console.WriteLine("--- Domates Birim Fİyatı:" + potatoPrice);
            Console.WriteLine("--- Patates Birim Fİyatı:" + tomatoPrice);


            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice =strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + " Bieim Fiyatı:"+" " + applePrice +" "+ " -Gramaj:" + appleGram + " -  Toplam Tutar:"+ " "+ appleTotalPrice );
            Console.WriteLine("Alınan Ürün: Portakal - " + " Bieim Fiyatı:" + orangePrice + " - Gramaj:" + orangeGram + " -  Toplam Tutar:"+" "+ orangeTotalPrice );
            Console.WriteLine("Alınan Ürün: Çilek - " + " Bieim Fiyatı:" + strawberryPrice + " - Gramaj:" + strawberryGram + " -  Toplam Tutar:"+ " "+strawberryTotalPrice );
            Console.WriteLine("Alınan Ürün: Patates - " + " Bieim Fiyatı:" + potatoPrice + " - Gramaj:" + potatoGram + " -  Toplam Tutar:"+" "+ potatoTotalPrice );
            Console.WriteLine("Alınan Ürün: Domates - " + " Bieim Fiyatı:" + tomatoPrice + " - Gramaj:" + tomatoGram + " -  Toplam Tutar:"+" "+ tomatoTotalPrice );


            double shoppingTotalPRice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine("toplam alışveriş tutarı: " + shoppingTotalPRice);
            #endregion
            #region Char Değişkenler
            //ABCDEFH
            //DEF
            //"  '

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passangerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir:  ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Yolcu kimlik no: "+passengerIdentityNumber +"-"+"Yolcu Ad Soyad: "+ " "+passangerName+passengerSurname+" "+"Yaş: "+ passengerAge+" "+"Adres: "+passengerDistrict +"/"+passengerCity );


















            #endregion
            #region Klavyeden Tamsayı Girişleri ve Dönüşümler
            //ABC598409dkgşl

            //int shoesPrice, computerPrice, chairPrice, tvPRice;
            //shoesPrice = 1000;
            //computerPrice = 30000;
            //chairPrice = 5000;
            //tvPRice = 130000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız yakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPRice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödenecek tutar: "+ totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("1.sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;


            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğiniz cindiyet: " + gender);









            #endregion



            Console.Read();

        }
    }
}
