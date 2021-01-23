using System;
using System.Collections.Generic;

namespace CreateDictionaryType
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customer = new MyDictionary<int, string>();
            customer.Add(1, "Ali");
            customer.Add(2, "Veli");
            customer.Add(3, "Deli");

            var a = customer[0];
            Console.WriteLine(a);

            foreach (var item in customer.Items)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
