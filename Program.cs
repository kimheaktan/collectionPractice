using System;
using System.Collections.Generic;

namespace collectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //three basic arrays
            int[] number = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[] {"Tim", "Nikki", "Sara"};
            bool[] trueFalse = new bool[] {true,false,true,false,true,false,true,false,true,false}; 

            //list of Flavors
            List<string> iceCream = new List<string>();
            iceCream.Add("Mint Chip");
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Rainbow");
            iceCream.Add("Bubble Gum");

            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            //User info Dictionary
            Dictionary<string,string> people = new Dictionary<string,string>();
            foreach(string name in names){
                Random rand = new Random();
                people.Add(name, iceCream[rand.Next(0,4)]); // [0,4] is the range in which it will select from in iceCream arr's length
            }
            foreach(var name in people){
                Console.WriteLine(name.Key + " likes " + name.Value);
            }
        }
    }
}

