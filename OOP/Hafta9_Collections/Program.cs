using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            byte girisTipiSecimi = 9;
            while (girisTipiSecimi != 0) {
                Console.WriteLine("\n\nGiriş Tipinizi Seçiniz: \n1- Kullanıcı\n2-Müşteri Temsilcisi\n0-Programı kapat (Veriler silinir!)");
                girisTipiSecimi = Convert.ToByte(Console.ReadLine());
                switch (girisTipiSecimi) {
                    case 1: Console.WriteLine("Kullanıcı girişi yapıldı.");
                        KullaniciGirisi(); 
                        break;
                    case 2: Console.WriteLine("Müşteri temsilcisi girişi yapıldı.");
                        MusteriTemsilcisiGirisi();
                        break;
                    case 0: Console.WriteLine("Programdan çıkış yapıldı."); break;
                }
            
            } 
        }


        public static void KullaniciGirisi()
        {
            Queue musteriSirasi = new Queue();
            byte kullaniciTercihi;

            Console.WriteLine("Hoşgeldiniz. \nMüşteri temsilcisiyle görüşmek için sıraya girmek ister misiniz?");
            Console.WriteLine("1-Müşteri temsilcisine bağlan.\n2-Hayır\n3-Sıramı gör.");
            kullaniciTercihi = Convert.ToByte(Console.ReadLine());

            switch (kullaniciTercihi) {

                case 1: SirayaKullaniciKaydet(musteriSirasi); break;
                case 2: break;
                case 3:
                    foreach (var kullanici in musteriSirasi)
                    {
                        musteriSirasi.Peek();
                     
                    } 
            }

            if (Console.ReadLine() == "1") {
                musteriBaglanacakMi = true;
            } else if { 
                musteriBaglanacakMi = false; 
            }


        if (musteriBaglanacakMi == true)
            {
               Console.WriteLine("Adınız nedir? ");
               musteriSirasi.Enqueue(Console.ReadLine());
               Console.WriteLine("Teşekkürler kaydınız alındı.\nSıranız: " + (musteriSirasi.Count));
            }
        }


        public static void MusteriTemsilcisiGirisi()
        {
            Console.WriteLine("Hoşgeldiniz.");
            Console.WriteLine("Sıradaki anlık müşteri sayısı:");
        }

    }
}
            /*
                Çagrı merkezi, 
             *kullanan kisi ya kullanıcı ya da musteri temsilcisi olcak
            cagrı merkezinde sırada bekleyen kullanıcılar var.
            
             *musteri temsilcisi rolu ile bu uygulamaya giris yapılınca 
            kullanıcıların sırasıyla birlikte goruntuleyebilsin
            
             *sıradaki kullanıcıya baglan diyince o kullanıcının bilgisi gosterilsin sırada bulunan kullanıcıyla is bitince silinsin sıradan.
            
             *kullanıcı roluyle girdiginde musteri temsilcisine baglan secenegi vs kullanıcının bilgileri alınsın. 
                "kacıncı sıradayım" diye bir menü olsun onundeki musteri sayısı azaldıkca sırası guncel sekilde gozuksun.


             */
