using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //burada bana roduct türünde birşey ver diyo
        {
            Console.WriteLine(product.ProductName + "Sepetinize eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "Sepetiniz güncellendi.");
        }

    }
}
//Void ne işe yarıyor git sil, ekle, yap anlamındadır. İşlem sonucunun ne olduğu önemli değilse kullanılır.
//public int Topla (int sayi1, int sayi2)
//{
//    return sayi1 + sayi2;
//}

        //ilkinde int kullanılınca return ifadesini kullanaildik
        //fakat void kullanınca return ifadesini kullanmaya izn vermiyor.
        //Niye return kullanılır.alttaki işlem sonucunu biryerde kullanmak istersek kullanma imkanımız olur.
        //void kullanılınca onunla bağlantı kopar.
        //asıl program içinde
        //productManager.Topla2(3,6); bu tek yapılabilir voidle
        //int toplamaSonucu = productManager.Topla(3,6); şeklinde tekrar kullanabiliriz
        //Console.WriteLine(toplamaSonucu*2); şeklinde kullanabiliriz

//public void Topla2 (int sayi1, int sayi2)
//{
//    Console.WriteLine(sayi1 + sayi2);
//}
