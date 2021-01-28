using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Hatice", "Melek", "Umut","Hasan"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);      //Bu şekilde dizi elemanlarını yazdık.
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];           //Yeni bir eleman eklemek için bu şekilde diziyi genişletmeyi umduk
            isimler[4] = "İlker";               //Yeni elemanı belirttik.
            Console.WriteLine(isimler[4]);      //Ekrana yazdırdık
            Console.WriteLine(isimler[0]);      //Bunu ekrana yazdırmayı denedik fakat başarılı olamadık. Bunun nedeni yeni bir dizi oluşturduk new ile. Diğer tüm elemanları boş kaldı.

            //Bunu yapabilmek için kolaksiyonlarda kullanırız.

            List<string> isimler2 = new List<string>(); //bunu kullanabilmek için solda çıkan ampulde system.Collections.Generic eklenir en başa.
            isimler2.Add("Engin");

            //yada bu şekilde kullanılır

            List<string> isimler3 = new List<string> { "Hatice", "Melek", "Umut", "Hasan" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Engin");              //burada ekleme yapılır. Ve hata oluşmaz
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);

        }
    }
}
