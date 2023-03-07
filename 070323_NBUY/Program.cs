using System;
using System.Security.Cryptography.X509Certificates;

namespace _070323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Araç Kiralama Metodu
            /*   static void aracsirket()
               {
                   Console.WriteLine("Araba kiralama şirketimize hoşgeldiniz.....");
                   Console.WriteLine("********************************************");
                   Console.Write("kiralayan kişinin adı =");
                   string ad = Console.ReadLine();
                   Console.Write("kiralayan kişinin soyadı =");
                   string soyad = Console.ReadLine();
                   kiralayan(ad, soyad);
                   Console.Write("kaç saat kiralayacaksınız=");
                   double saat = double.Parse(Console.ReadLine());
                   double deger = saatfiyat(saat); Console.WriteLine(deger + " indirim yapılmadı");
                   Console.WriteLine(indirimyap(deger));
                   Console.WriteLine($"Toplam kiralanacak saat= {saat}");
                   Console.WriteLine($"kiralayan kişinin adı ={ad}");
                   Console.WriteLine($"kiralayan kişinin soyadı ={soyad}");

               }
               static double indirimyap(double x)
               {
                   if (x > 1500)
                   {
                       x = x - x * 0.10;
                       return x;
                   }
                   else
                   {
                       return x;
                   }
               }
               static string kiralayan(string ad, string soyad)
               {
                   return "";
               }
               static double saatfiyat(double saat)
               {
                   double değer = 0;
                   Console.WriteLine("hangi arabayı kiralayacaksınız(Lütfen 1-4 arasında bir sayı giriniz)=\n1-reanult saati=700 Tl\n2-porsche saati=950 Tl\n3-fiat saati=500 Tl\n4-volvo saati=785 Tl");
                   string secim = Console.ReadLine();
                   if (secim == "1")
                   {
                       double renault = 700;
                       return renault * saat;

                   }
                   else if (secim == "2")
                   {
                       int porsche = 950;
                       return porsche * saat;

                   }
                   else if (secim == "3")
                   {
                       int fiat = 500;
                       return fiat * saat;

                   }
                   else if (secim == "4")
                   {
                       int volvo = 785;
                       return volvo * saat;

                   }
                   else
                   {
                       Console.WriteLine("lütfen geçerli bir seçim yapınız ,1 ile 4 arasında bir sayı giriniz...");
                   }
                   return 0;
               } */
            #endregion

            #region Topla Metodu Overload
            /*   topla();
               topla(3, 5);
               topla(4, 6, 7);

           }
           static void topla()
           {
               Console.WriteLine("İki Sayı gir");
               int a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());
               Console.WriteLine("Sonuc:" + (a + b));
           }
           static void topla(int a, int b)
           {
               Console.WriteLine("Sonuc:" + (a + b));
           }
           static void topla(int a, int b, int c)
           {
               Console.WriteLine("Sonuc:" + (a + b + c));
           } */
            #endregion

            #region string.format
            /*   Console.WriteLine("-------------------------------------------------------");
               Console.WriteLine("Sıra No | Adınız | Soyadınız");
               Console.WriteLine("-------------------------------------------------------");
               Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 1, "Ömer", "ERTÜRK"));
               Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 2, "Tevfik", "ULUÇ"));
               Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 3, "Yücel", "CAN"));
               Console.WriteLine("-------------------------------------------------------");
               Console.ReadLine();



    Console.WriteLine(string.Format("{0:00000}", 15));
               Console.WriteLine(string.Format("{0:00000}", -15));
               Console.WriteLine(string.Format("{0,5}", 15));
               Console.WriteLine(string.Format("{0,-5}", 15));
               Console.ReadLine();



    String.Format("{0:00000}", 15); // "00015"
               ifadesiyle 15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.

               String.Format("{0:00000}", -15); // "-00015"
               ifadesiyle -15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.

               String.Format("{0,5}", 15); // " 15"
               /*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.

               String.Format("{0,-5}", 15); // "15 "
               /*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.

               String.Format("{0,5:000}", 15); // " 015"
               /*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.

               String.Format("{0,-5:000}", 15); // "015 "
               /*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.

               Console.WriteLine(String.Format("{0:### ## ##}", 1234567)); ; // 123 45 67
               Console.WriteLine(String.Format("{0:(#) ###-##-##}", 12345678)); ; //(1) 234-56-78
               /* Sayıları isteğe bağlı biçimlendirmek istersek (örneğin bir telefon numarasını  alan kodu ve telefon numarası ayrı ayrı yazılsın istiyorsak), biçimlendirme işleminde diyez (#) işareti ile formatımızı belirleriz;*/

            /* Ondalıklı sayılarda virgülden (programlamada nokta) sonra kaç basamak görünsün istiyorsak köşeli parantezler ({ }) içerisindeki biçimleme kısmında noktadan sonra o kadar sıfır (0) koymamız gerekir;
            String.Format("{0:0.00}", 123.4567); // "123.46"
            String.Format("{0:0.00}", 123.4); // "123.40"
            String.Format("{0:0.00}", 123); // "123.00"

            /*Eğer ondalıklı sayının en fazla kaç basamağının ekranda çıkmasını istiyorsak, bu sefer sıfır yerine o kadar sayıda diyez (#) işareti kullanmamız gerekir;
            String.Format("{0:0.##}", 123.4567); // "123.46"
            String.Format("{0:0.##}", 123.4); // "123.4"
            String.Format("{0:0.##}", 123); // "123"

            /*Ondalıklı sayılarda virgülden önce kaç basamak görüntülemek istiyorsak biçimlendirme yaparken, noktadan önce kaç basamak istiyorsak o kadar sıfır (0) kullanmamız gerekir;
            String.Format("{0:000.0}", 123.4567); // "123.5"
            String.Format("{0:000.0}", 23.4567); // "023.5"
            String.Format("{0:00.00}", 3.4567); // "03.46"
            String.Format("{0:00.00}", -3.4567); // "-03.46"

            //Eğer sayıların görüntülenmesinde bin ayracı kullanılmak isteniyorsa;
            String.Format("{0:0,0.0}", 12345.678); // "12,345.7"
            String.Format("{0:0,0.00}", 12345.678); // "12,345.68"
            String.Format("{0:0,0}", 12345.678); // "12,346"

            /*0 ile 1 arasındaki ondalıklı sayıların gösterimi iki şekilde olur. Birincisinde sayının tam kısmı 0 ve noktadan sonra ondalıklı kısmı gelir (Örn: 0.123 şeklinde), bir diğer gösterim şeklinde ise sayının tam kısmı yazılmaz sadece nokta ve sonrasındaki ondalıklı kısım yazılır (Örn: .123 şeklinde).İşte bu durumlardaki sayıların gösterimi ise şu şekilde gerçekleştirilir;
            String.Format("{0:0.0}", 0.0); // "0.0"
            String.Format("{0:0.#}", 0.0); // "0"
            String.Format("{0:#.0}", 0.0); // ".0"
            String.Format("{0:#.#}", 0.0); // ""

            /*Bütün bu formların dışında sayılarımızı aşağıdaki gibi istediğimiz metinler ile birlikte yazmamız da mümkündür;
            String.Format("{0:sonuç 0.0}", 12.3); // "sonuç 12.3"
            String.Format("{0:x0x.yy0yy}", 12.3); // "x12x.yy3yy" */


            #endregion

            #region DateTime zaman saat dakika gösterme
            /* DateTime zaman = DateTime.Now;

             Console.WriteLine("şuan tarih ve saat");
             Console.WriteLine(zaman.Year);
             Console.WriteLine(zaman.Month);
             Console.WriteLine(zaman.Day);
             Console.WriteLine(zaman.Hour);
             Console.WriteLine(zaman.Minute);
             Console.WriteLine(zaman.Second); */
            #endregion

            #region TimeSpan Doğumdan itibaren geçen süreyi hesaplama
            /* DateTime bugün; TimeSpan süre;
             bugün = DateTime.Now;
             Console.WriteLine("Doğum tarihinizi girin: ");
             DateTime doğumtarihiniz = DateTime.Parse(Console.ReadLine());
             süre = bugün.Subtract(doğumtarihiniz);
             Console.WriteLine("Dünya üzerine geleli {0} gün olmuş.", süre.TotalDays);
             Console.WriteLine("Dünya üzerine geleli {0} saat olmuş.", süre.TotalHours);
             Console.WriteLine("Dünya üzerine geleli {0} dakika olmuş.", süre.TotalMinutes);
             Console.WriteLine("Dünya üzerine geleli {0} saniye olmuş.", süre.TotalSeconds);
             Console.WriteLine("Dünya üzerine geleli {0} salise olmuş.", süre.TotalMilliseconds);
             Console.ReadLine(); */
            #endregion

            #region tarihe ay yıl ekleme
            /*
             DateTime ilktarih = new DateTime(2000, 07, 12, 20, 12, 23, 33);
             DateTime bitistarih = ilktarih.AddYears(6);
             bitistarih = ilktarih.AddMonths(6);
             Console.WriteLine("ilk tarih:" + " " + ilktarih);
             Console.WriteLine("son tarih:" + " " + bitistarih);
            */
            #endregion

            #region Kişi Sınıf tanımlaması
            /*   kisi fatih = new kisi();
               fatih.ad = "fatih";
               fatih.soyad = "terim";
               fatih.yas = 69;
               fatih.gozrengi = "kahverengi";
               fatih.ırk = "Türk";
               Console.WriteLine(fatih.ad + " " + fatih.soyad + " " + fatih.yas + " " + fatih.ırk + " " + fatih.gozrengi);

               static void ozellik()
               {

               }
           }
       }
       class kisi
       {
           public byte yas;
           public string ad;
           public string soyad;
           public string ırk;
           public string gozrengi;

       } */
            #endregion

            #region Kitap Sınıfı Oluşturma ve Yazdırma
            /*   kitap yenikitap = new kitap();
               yenikitap.yazar = "Ali Veli";
               yenikitap.sayfa = 560;
               yenikitap.konu = "Biyografi";
               yenikitap.tarih = 1980;
               yenikitap.ad = "Normandiya";
               yenikitap.ozellik();

           }
           class kitap
           {
               public string yazar;
               public string ad;
               public int sayfa;
               public int tarih;
               public string konu;

               public void ozellik()
               {
                   Console.WriteLine(ad + " " + yazar + " " + sayfa + " " + tarih + " " + konu);
               }
           } */
            #endregion



        }
    }
}

