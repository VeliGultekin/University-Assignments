using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ilk tarihi GG/AA//YYYY seklinde giriniz!");
        if (DateTime.TryParse(Console.ReadLine(), out var date1))
        {
            Console.WriteLine("Ikinci tarihi GG/AA//YYYY seklinde giriniz!");
            if (DateTime.TryParse(Console.ReadLine(), out var date2))
            {
                int gunFarki = (int)Math.Abs((date1 - date2).TotalDays);
                Console.WriteLine($"Aradaki gun farki: {gunFarki}");
            }
            else
            {
                Console.WriteLine("Lutfen date2'yi gecerli formatta bir tarih giriniz!");
            }
        }

        else
        {
            Console.WriteLine("Lutfen date1'i gecerli formatta bir tarih giriniz!");
        }
        
    }
}
