using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.Contains('L')
                                          select fruit;
            foreach (var Lfruit in LFruits)
            {
                Console.WriteLine($"Fruits that start with L {Lfruit}");
            }


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            IEnumerable<int> fourSixMultiples = numbers.Where(numbers => numbers % 4 == 0 || numbers % 6 == 0);

            foreach (var number in fourSixMultiples)
            {
                Console.WriteLine($"the multiplies of 4 or 6 from the list are {number}");
            }

            //Ordering Operations

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(names => names).ToList();

            foreach (var name in descend)
            {
                Console.WriteLine(name);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersAsc = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            List<int> Ascend = numbersAsc.OrderBy(numbersAsc => numbersAsc).ToList();
            foreach (var up in Ascend)
            {
                Console.Write($"List of ascending #'s ");
                Console.WriteLine(up);
            }

            //Aggregate Operations

            // Output how many numbers are in this list
            List<int> numbersAgg = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var AggregateNumbers = numbersAgg.Count();
            System.Console.WriteLine($"there are {AggregateNumbers} numbers in list");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            double sumOfNum = purchases.Sum();
            System.Console.WriteLine($"the sum is {sumOfNum}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            double expensiveProduct = prices.Max();
            System.Console.WriteLine($"The most expensive product cost ${expensiveProduct}");

            //Partitioning Operations
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            IEnumerable<int> Squared = wheresSquaredo.TakeWhile(number => (Math.Sqrt(number) % 1) != 0);
            foreach (var sq in Squared)
            {
                System.Console.WriteLine($"number can not be squared {sq}");   
            }
        }
    }
}
