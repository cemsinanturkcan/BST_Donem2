using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_S2_29_09_Slayt2
    //  Temel Veri Türleri   //
    /*  String ve object referans tipi,
     *  int, double, char, float value (değer) tipleri */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*char karakter = 'A';
            Console.WriteLine(karakter);
            */

            int sayi1 = 0, sayi2 = 0;
            Console.WriteLine("1.Sayiyi giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayiyi giriniz");

            sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            
            // 1.Yol
            Console.WriteLine("1.Sayı: {0}\n2.Sayı: {1}\nToplamları: {2} ",sayi1,sayi2,toplam);

            // 2.Yol
            // Console.WriteLine("1.Sayı: "+sayi1+"\n2.Sayı: "+sayi2+"\nToplamları: "+toplam);

            

            //       String bir karakter dizisidir.        //
            
            char[] ach = { 'm', 'e', 'r', 'h', 'a', 'b', 'a' };

            string str = new string(ach);
            Console.WriteLine(str);


            //  Scope mevzuları 

            int z = 10;

            { 
                int x = 29;
                Console.WriteLine(x);
                // Console.WriteLine(y); y değişkeni bu scopeta tanımlanmadı.
                Console.WriteLine(z); // z değişkeni aynı classta tanımlı zaten.
            }
            {
                int x = 10; // x bir daha tanımlanabilir burası ayrı bir scope içi.
                int y = 15;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }






        }
    }
}
