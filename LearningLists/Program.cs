using System;
using System.Collections.Generic;

namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<String>();

            customers.Add("hoo");
            customers.Add("ha");
            customers.Add("he");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine(customers[1]);
        }
    }
}
