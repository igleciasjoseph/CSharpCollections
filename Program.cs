using System;
using System.Collections.Generic;

namespace C_Fund1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            boolArray = new bool[] {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Cookies and Cream");
            flavors.Add("Cookie Dough");
            Console.WriteLine($"We currently have {flavors.Count} ice cream flavors.");
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine($"We currently have {flavors.Count} ice cream flavors.");

            Dictionary<string,string> names = new Dictionary<string,string>();
            Random rand = new Random(); 

            names.Add("Tim", "Cookie Dough");
            names.Add("Martin", "Cookies and Cream");
            names.Add("Nikki", "Chocolate");
            names.Add("Sara", "Vanilla");

            foreach (var entry in names) {
                Console.WriteLine(entry);
            }
        }
    }
}
