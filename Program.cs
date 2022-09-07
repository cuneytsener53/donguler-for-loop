using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EKRANA GİRİLEN SAYIYA KADAR OLAN TEK SAYILARINI EKRANA YAZDIR.

            Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                //Komutlar

                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların içlerinde toplamları ekrana yazdır.

            int tekToplam = 0;
            int ciftToplan= 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%2 == 1)
                    tekToplam += i; //tektoplam = tektoplam + i;
                else
                    ciftToplan += i; //cifttoplam = cifttoplam + i;
            }

            Console.WriteLine("Tek Toplamm" + tekToplam);
            Console.WriteLine("Çift Toplam" + ciftToplan);
        }

        // Break Continue //eğer bir döngü içerisinde sonlandırmak istiyorsanız break döngüsünü kullanabilirsiniz

        for (int i = ; i < 10; i++)
        {
            if (i == 4)
            break; // BREAK İSE 4 'Ü GÖRDÜĞÜ ZAMAN ORADA O İŞLEMİ KESİP DURMAKTADIR.
            Console.WriteLine(i);
        }
        for (int i = ; i < 10; i++)
        {
            if (i == 4)
            Continue; /// SADECE 4'ÜN OLDUĞU SYCİLİ ATLADI CONTİNUE BU İŞLEME DENK GELMEKTEDİR
            Console.WriteLine(i);
        }
    }
}