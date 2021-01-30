using System;
using System.Collections.Generic;                      // DICTIONARY de ampulden using System.Collections.Generic; ı eklememiz şart

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();        
            cities.Add(1, "Adana");
            cities.Add(2, "Adıyaman");
            cities.Add(3, "Afyon");
            cities.Add(4, "Ağrı");
            cities.Add(5, "Amasya");
            cities.Add(6, "Ankara");
            cities.Add(7, "Antalya");
            cities.Add(14, "Bolu");
            cities.Add(23, "Elazığ");


            cities.Remove(2);
            cities.Remove(7);


            foreach (var city in cities)
            {
                Console.WriteLine(city.Key + " " + city.Value);
            }

            Console.WriteLine("----------------------\n");

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Turkey", "Ankara");
            capitals.Add("England", "London");
            capitals.Add("France", "Paris");
            capitals.Add("Germany", "Berlin");
            capitals.Add("Italy", "Rome");

            Console.WriteLine(capitals["Turkey"]);             // Turkey anahtarını çağırdım bana Ankara Değerini verdi
            Console.WriteLine();


            foreach (var capital in capitals)
            {
                Console.WriteLine(capital.Key + " : " + capital.Value);
            }
        }
    }
}
