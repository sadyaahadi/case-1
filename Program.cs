using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region yazdirma komutlari
           /* Console.WriteLine("*****yemek kategorileri*****!");
            Console.WriteLine();
            Console.WriteLine("1- ana yemekler");
            Console.WriteLine("2_ tatlilar");
            Console.WriteLine("3- corbalar");
            Console.WriteLine("4- icecekler");
            Console.WriteLine("5-salatalar");
            Console.WriteLine();
            Console.WriteLine("lutfen birini seciniz:");
            */
            #endregion

           #region string degiskenler

            // degiskenler
            // string 
           // string name;
            //name = "sadya";
            //Console.Write(name);

            // string customerName;
            // string customerSurname;
            // string customerPhone;
            // string customeremail, district, city;
            // customerName = "sadie";
            // customerSurname = "eaddy";
            // customerPhone = "0555 555 55 55";
            // customeremail = "sadie12@gmail.com";
            // district = "fatih";
            // city = "istanbul";
            // Console.WriteLine(" ******rezervasyon kayit*****");
            // Console.WriteLine("------------------------------");
            // Console.WriteLine();
            // Console.WriteLine("Musteri: "+ customerName + " " + customerSurname );
            // Console.WriteLine("iletisim: " + customerPhone );
            // Console.WriteLine("email: " + customeremail);
            // Console.WriteLine("adres: " + district + " / " + city);
            // Console.WriteLine("------------------------------");

            // customerName = "aysegul";
            // customerSurname = "yilmaz";
            // customerPhone= "0546 345 23 45";
            // customeremail="aysegul@gmail.com";
            // district= "avcilar";
            // city= "istanbul";
            // Console.WriteLine("------------------------------");
            // Console.WriteLine();
            // Console.WriteLine("Musteri: "+ customerName + " " + customerSurname );
            // Console.WriteLine("iletisim: " + customerPhone );
            // Console.WriteLine("email: " + customeremail);
            // Console.WriteLine("adres: " + district + " / " + city);
            // Console.WriteLine("------------------------------");


            #endregion

           #region  int degeikeni
        

           //int
        //    int number = 24;
        //    Console.WriteLine(number);

        // int hamburgerprice= 300;
        // int cokeprice= 35;
        // int waterprice= 10;
        // int friesprice= 50;
        // int pizzaprice= 250;
        // int lemonadeprice= 30;

        // Console.WriteLine("*****restaurnant menu price*******");
        // Console.WriteLine();
        // Console.WriteLine("------kola: " + cokeprice + "TL");
        // Console.WriteLine("------hamburger:" + hamburgerprice +"TL");
        // Console.WriteLine("------fries:" + friesprice +"TL");
        // Console.WriteLine("------pizza:" + pizzaprice +"TL");
        // Console.WriteLine("------water:" + waterprice  +"TL");
        // Console.WriteLine("------lemonade:" + lemonadeprice +"TL");

        // Console.WriteLine();
        // int hamburgerCount=3;
        // int cokeCount=3;
        // int waterCount=3;
        // int friesCount=1;
        // int pizzaCount=0;
        // int lemonadeCount=0;


        // int totalhamburgerPrice= 0;
        // int totalcokePrice=0;
        // int totalwaterPrice=0;
        // int totalfriesPrice=0;
        // int totalpizzaPrice=0;
        // int totallemonadePrice=0;

        // totalhamburgerPrice = hamburgerCount*hamburgerprice;
        // totalcokePrice = cokeCount*cokeprice;
        // totalwaterPrice = waterCount*waterprice;
        // totalfriesPrice = friesCount*friesprice;
        // totalpizzaPrice = pizzaCount*pizzaprice;
        // totallemonadePrice = lemonadeCount*lemonadeprice;   
        // Console.WriteLine("hamburger fiyati: " + totalhamburgerPrice + "TL");
        // Console.WriteLine("kola fiyati: " + totalcokePrice + "TL");
        // Console.WriteLine("su fiyati: " + totalwaterPrice + "TL");
        // Console.WriteLine("patates fiyati: " + totalfriesPrice + "TL");
        // Console.WriteLine("pizza fiyati: " + totalpizzaPrice + "TL");
        // Console.WriteLine("limonata fiyati: " + totallemonadePrice + "TL");
        // Console.WriteLine();
        // int totalprice= totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesPrice + totalpizzaPrice + totallemonadePrice;
        // Console.WriteLine("toplam fiyat: " + totalprice + "TL");

        
                   #endregion

            //variables (string, int, char, double,decimal,float,bool,var...)

            #region double degiskenler
            // double
            // double number;
            // number = 4.85;
            // Console.WriteLine(number);
        //     Console.WriteLine("*******fiyat listesi********");
        //     Console.WriteLine();
        //     double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;
        //     appleprice = 14.85;
        //     orangeprice = 20.95;
        //     strawberryprice = 45;
        //     potatoprice = 9.74;
        //     tomatoprice = 6.88;

        //     Console.WriteLine("----- Elma birim fiyati: " + appleprice + " TL");
        //     Console.WriteLine("----- Portakal birim fiyati: " + orangeprice + " TL");
        //     Console.WriteLine("----- Cilek birim fiyati: " + strawberryprice + " TL");
        //     Console.WriteLine("----- Patates birim fiyati: " + potatoprice + " TL");
        //     Console.WriteLine("----- Domates birim fiyati: " + tomatoprice + " TL");
        //     Console.WriteLine();
        //     Console.WriteLine();

        //     double applegram, orangegram, strawberrygram, potatogram, tomatogram;
        //     applegram = 1.245;
        //     orangegram = 2.650;
        //     strawberrygram = 0.750;
        //     potatogram = 4.859;
        //     tomatogram = 3.745;
        // double appletotalprice, orangetotalprice, strawberrytotalprice, potatototalprice, tomatototalprice;
        //     appletotalprice = appleprice * applegram;
        //     orangetotalprice = orangeprice * orangegram;
        //     strawberrytotalprice = strawberryprice * strawberrygram;
        //     potatototalprice = potatoprice * potatogram;
        //     tomatototalprice = tomatoprice * tomatogram;        
        //     Console.WriteLine("alinan urun: Elma - " + "birim fiyat: " + appleprice + "-gramaj:" + applegram + "-toplam tutar: " + appletotalprice);
        //     Console.WriteLine("alinan urun: Portakal - " + "birim fiyat: " + orangeprice + "-gramaj:" + orangegram + "-toplam tutar: " + orangetotalprice);
        //     Console.WriteLine("alinan urun: Cilek - " + "birim fiyat: " + strawberryprice + "-gramaj:" + strawberrygram + "-toplam tutar: " + strawberrytotalprice);
        //     Console.WriteLine("alinan urun: Patates - " + "birim fiyat: " + potatoprice + "-gramaj:" + potatogram + "-toplam tutar: " + potatototalprice);
        //     Console.WriteLine("alinan urun: Domates - " + "birim fiyat: " + tomatoprice + "-gramaj:" + tomatogram + "-toplam tutar: " + tomatototalprice);
        //     Console.WriteLine();

        //     double shopppingtotalprice = appletotalprice + orangeprice + strawberryprice+ potatoprice + tomatoprice;
        //     Console.WriteLine();
        //      Console.WriteLine();
        //      Console.WriteLine("alisveris toplam tutar:" + shopppingtotalprice + "TL");






            #endregion
            #region char degiskenler
            // karskter olusturmak icin kullanilir
            // tek tirnak ile tanimlanir 

            // char symbol;
            // symbol = 'a';
            // Console.WriteLine(symbol);


            #endregion
            #region klavyeden veri girisleri string degiskenler

            // Console.WriteLine("***csharp havayollari yolcu bilgileri***");
            // Console.WriteLine();

            // string passengername, passengersurname, passengerdistrict, passengercity, passengerage, passengeridnumber;
            // Console.Write("yolcu adi:  ");
            // passengername = Console.ReadLine();
            // Console.Write("yolcu soyadi:  ");
            // passengersurname = Console.ReadLine();
            // Console.Write("yolcu ilce:  ");
            // passengerdistrict = Console.ReadLine();
            // Console.Write("yolcu sehir:  ");
            // passengercity = Console.ReadLine();
            // Console.Write("yolcu yas:  ");
            // passengerage = Console.ReadLine();
            // Console.Write("yolcu tc kimlik no:  ");
            // passengeridnumber = Console.ReadLine();
            // Console.WriteLine();
            // Console.WriteLine("----------------------------");
            // Console.WriteLine("yolcu tc kimlik no: " + passengeridnumber + "- yolcu ad soyad: " + passengername + " " + passengersurname + " " + passengerdistrict + "/" + passengercity + " " + passengerage);
            



            





            #endregion
            #region klavyeden veri girisleri ve donusumler

            // girilen degerleri string olarak kabul ediyor o yuzden donusum kullanlir.
            //ABC12D 1 ve 2 nin sayisal degeri yoktur 

            // int shoesprice, computerprice, chairprice, tvprice;
            // shoesprice = 1000;
            // computerprice = 20000;
            // chairprice = 5000;
            // tvprice = 12000;

            // int shoescount, computercount, chaircount, tvcount;

            // Console.Write("lutfen aldiginiz ayakkabi sayisini giriniz: ");
            // shoescount = int.Parse(Console.ReadLine());

            // Console.Write("lutfen aldiginiz bilgisayar sayisini giriniz: ");
            // computercount =int.Parse(Console.ReadLine());

            // Console.Write("lutfen aldiginiz sandalye sayisini giriniz: ");
            // chaircount = int.Parse(Console.ReadLine());

            // Console.Write("lutfen aldiginiz tv sayisini giriniz: ");
            // tvcount = int.Parse(Console.ReadLine());
            
            // int totalprice = shoescount*shoesprice + computercount*computerprice + chaircount*chairprice+ tvcount*tvprice;
            // Console.WriteLine();
            // Console.WriteLine("toplam odemeniz gereken tutar: " + totalprice );
            




            #endregion
   
             #region klavyeden ondalikli sayi islemleri

            // double exam1, exam2, exam3, result;
            // Console.Write("lutfen 1. sinav notunu giriniz: ");
            // exam1 = double.Parse(Console.ReadLine());
            // Console.Write("lutfen 2. sinav notunu giriniz: ");
            // exam2 = double.Parse(Console.ReadLine());
            // Console.Write("lutfen 3. sinav notunu giriniz: ");
            // exam3 = double.Parse(Console.ReadLine());   
            // result = (exam1 + exam2 + exam3) /3;
            // Console.WriteLine();
            // Console.WriteLine("sinav ortalamasi: " + result);




            #endregion
            #region klavyeden karakter girisleri
            // char gender;
            // Console.Write("lutfen cinsiyet seciniz: ");
            // gender = char.Parse(Console.ReadLine());

            // Console.WriteLine("sectiginiz cinsiyet: " + gender);

            #endregion 
       
       
       
        }

    }
}