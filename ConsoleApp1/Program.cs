using System;
using System.Globalization;

namespace MyNamespace
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("3 adet sayi giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int sayi1) && int.TryParse(Console.ReadLine(), out int sayi2) && int.TryParse(Console.ReadLine(), out int sayi3))
            {

                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    Console.WriteLine($"En büyük sayi: {sayi1}'dir");
                    
                }
                else if (sayi2 >= sayi1 && sayi2 >= sayi3)
                {
                    Console.WriteLine($"En büyük sayi: {sayi2}'dir");
                }
                else
                {
                    Console.WriteLine($"En büyük sayi: {sayi3}'dir");
                }
            }

            else
            {
                Console.WriteLine("Lutfen gecerli bir deger giriniz!");
            }


        }
    }
}
