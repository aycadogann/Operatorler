using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            // ||  , &&  , !

            bool isSuccess=true;
            bool isCompleted=false;

            if(isSuccess && isCompleted)
               Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
               Console.WriteLine("Gerat");

            if(isSuccess && !isCompleted)
               Console.WriteLine("Fine");

            //İlişkisel operatörler
            //<  , >  , <=   , >=   , ==  , !=

            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc= a>b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik operatörler
            //+   , -  , /  , *
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;  
            //sayi1 sonuc değişkenine atanır sonuc değişkeni 10 olur
            //sayi1 değeri sonra artırılır ve sayi1 11 olur
            Console.WriteLine(sonuc1);
            Console.WriteLine(sayi1);

            sonuc1=++sayi1;
            //sayi1 bir artırılır sayi1 12 olur 
            //ve sonuc değişkenine atanır sonuc değişkeni 12 olur  
            Console.WriteLine(sonuc1);
            Console.WriteLine(sayi1);


            // % mod alma operatörü
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);


        }
    }
}
