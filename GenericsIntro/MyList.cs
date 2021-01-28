using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T> //bir önceki prjede list string olarak belirlenmişti. fakat burda sadece Type anlamında T yazdık. yani her türü kabul eder.
    {
        T[] items;
        //constructer
        //ctor tab ta 
        public MyList()
        {
            items = new T[0];       //İlerde elemanları yazabilmek için onun new'lenmesi gerekir. Bu yüzden bu ifade bloğu yazılır.
        }
        public void Add(T item) //T burada yazıldı
        {
            T[] tempArray = items; //elemanların kaybolmaması için geçici bir şekilde emanet ettik.
            items = new T[items.Length+1]; //diziye eleman eklemek için önce eleman sayısını arttırmak gerekir.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];    //geçici kısımdaki itemleri geri alırız
            }

            items[items.Length - 1] = item; //aslında eklenmek istenen eleman şuan eklenmiştir.
        }
    }
}
