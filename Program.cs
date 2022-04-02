using System;

namespace dongu_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            ////1 den baslayarak consoldan girilen sayilarin ortalamasini hesaplayip yazdiran program
            /*Console.WriteLine("lutfen bir sayi giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //a'dan z'ye kadar tum harfleri konsola yazdiran program
            char character='a';
            while(character<'z')
            {
                Console.Write(character);
                character++;
            }*/

            Console.WriteLine(".....FOREACH.....");
            string[] arabalar={"BMW","Ford","Toyota","Nissan"};
            
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        
        }
        


    }
}
