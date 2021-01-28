using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List diye bir komut olmasaydı biz kendimi nasıl yazardık
            MyList <string> myList = new MyList <string> (); //Burada string yazılan yere başka bir türde yazabiliriz çünkü MyList class içinde istediğimiz türü yazabiliriz dendi.
            myList.Add("Engin");
        }
    }
}
