using System;
using System.Collections.Generic;

namespace GenericCollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // generates a random integer 

            var ints = new List<int>(); // creates a list 
           
            for(var idx = 0; idx < 30; idx++) // loop for a set number of times
            {
                var score = rnd.Next(0, 31); // supplies integers for amount requested
                ints.Add(score);
            }
            var total = 0; // create var for total 
           foreach(var i in ints) // var i signals every int in list of ints
            {
                total = total + i; 
            }
            Console.WriteLine($"Grand total is {total}");
        }
    }
}
