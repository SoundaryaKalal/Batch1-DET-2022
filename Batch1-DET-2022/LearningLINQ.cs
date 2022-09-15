using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LearningLINQ
    {
        public static void Main()
        {
            //     Sample_OrderByDescending_Lambda();
            //Sample_FirstOrDefault_Lambda();
            // Sample_First_Lambda_Simple();
            // Sample_ElementAtOrDefault_Lambda();
            //  Sample_ElementAt_Lambda();
            // Sample_Union_Lambda();
            //Sample_Intersect_Lambda();
            // Sample__Lambda();
            //Sample_Distinct_Lambda();
            // Sample_Sum_Lambda();
            // Sample_Max_Lambda();
            //Sample_Min_Lambda();
            // Sample_Count_Lambda();
            //Sample_Average_Lambda();
            //Sample_OrderBy_Lambda_Numbers();
            //Sample_OrderByDescending_Lambda();
            //Sample_Reverse_Lambda();
            // Sample_ThenBy_Lambda();
            // Sample_ThenByDescending_Lambda();
            // Sample_Aggregate_Lambda_Simple();
            // Sample_TakeWhile_Lambda();
           // Sample_Skip_Lambda();
            //Sample_SkipWhile_Lambda();
            //Sample_Take_Lambda();
              //  Sample_TakeWhile_Lambda();



        }

       


        //The  Three parts of linq query: differed execution
        // 1. Data source.
        // List<int> numbers= new List<int>();
        // numbers.Add(100);
        // numbers.Add(106);
        // numbers.Add(105);
        // numbers.Add(104);

        //2. query creation. sql type

        //ex for deffered execution
        // var numQuery = (from num in numbers  //select num from numbers
        //              select num);

        //lamda exp
        //  var numQuery = numbers.Select(x => x);





        //var numQuery = from num in numbers //select num from numbers
        //               where num>102
        //               select num;




        //Query execution.

        // foreach (int num in numQuery)
        //{
        //    Console.Write("{0} ", num);
        //num.Dump();// this is for LINQpad not for VS
        // }
        // Console.ReadLine();
        // }

        static void Sample_OrderBy_Lambda_Numbers()

        {
            int[] numbers = { 7, 9, 5, 4 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        static void Sample_OrderByDescending_Lambda()
        {
            string[] names = { "Ned", "Ben", "Susan" };

            var result = names.OrderByDescending(n => n);

            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);
        }

        static void Sample_Reverse_Lambda()
        {
            char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Console.WriteLine(character);
        }

        static void Sample_ThenBy_Lambda()
        {
            string[] capitals = { "Berlin", "Madras", "Ballary", "Tokyo", "London",
                          "Athens", "Beijing", "Belgaum" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }


        static void Sample_ThenByDescending_Lambda()
        {
            var dates = new DateTime[]
    {
                new DateTime(2015, 3, 1),
                new DateTime(2014, 7, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 7, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }

        static void Sample_Skip_Lambda()
            {

                string[] words = { "one", "two", "three", "four", "five", "six" };

                var result = words.Skip(4);

                Console.WriteLine("Skips the first 4 words:");
                foreach (string word in result)
                    Console.WriteLine(word);
            }


        static void Sample_SkipWhile_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };
            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words While the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }

        static void Sample_Take_Lambda()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var result = numbers.Take(5);

                Console.WriteLine("Takes the first 5 numbers only:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }

            static void Sample_TakeWhile_Lambda()
            {

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var result = numbers.TakeWhile(n => n < 5);

                Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }

            static void Sample_Aggregate_Lambda_Simple()
            {
                var numbers = new int[] { 1, 2, 3, 4, 5 };

                var result = numbers.Aggregate((a, b) => a * b);

                Console.WriteLine("Aggregated numbers by multiplication:");
                Console.WriteLine(result);
            }



            static void Sample_Average_Lambda()
            {
                int[] numbers = { 10, 10, 11, 11 };

                var result = numbers.Average();

                Console.WriteLine("Average is:");
                Console.WriteLine(result);
            }


            static void Sample_Count_Lambda()
            {
                string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

                var result = names.Count();

                Console.WriteLine("Counting names gives:");
                Console.WriteLine(result);
            }

            static void Sample_Min_Lambda()
            {
                int[] numbers = { 6, 9, 3, 7, 5 };

                var result = numbers.Min();

                Debug.WriteLine("Lowest number is:");
                Debug.WriteLine(result);
            }

            static void Sample_Max_Lambda()
            {
                int[] numbers = { 2, 8, 5, 6, 1 };

                var result = numbers.Max();

                Console.WriteLine("Highest number is:");
                Console.WriteLine(result);
            }


            static void Sample_Sum_Lambda()
            {
                int[] numbers = { 2, 5, 10 };

                var result = numbers.Sum();

                Console.WriteLine("Summing the numbers yields:");
                Console.WriteLine(result);
            }

            static void Sample_Distinct_Lambda()
            {
                int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

                var result = numbers.Distinct();

                Console.WriteLine("Distinct removes duplicate elements:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }





            static void Sample_Intersect_Lambda()
            {
                int[] numbers1 = { 1, 2, 3 };
                int[] numbers2 = { 3, 4, 5 };

                var result = numbers1.Intersect(numbers2);

                Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }


            static void Sample_Union_Lambda()
            {
                int[] numbers1 = { 1, 2, 3 };
                int[] numbers2 = { 3, 4, 5 };

                var result = numbers1.Union(numbers2);

                Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }


            static void Sample_ElementAt_Lambda()
            {
                string[] words = { "One", "Two", "Three" };

                var result = words.ElementAt(1);

                Console.WriteLine("Element at index 1 in the array is:");
                Console.WriteLine(result);
            }


            static void Sample_ElementAtOrDefault_Lambda()
            {
                string[] colors = { "Red", "Green", "Blue" };

                var resultIndex1 = colors.ElementAtOrDefault(1);

                var resultIndex10 = colors.ElementAtOrDefault(10);

                Console.WriteLine("Element at index 1 in the array contains:");
                Console.WriteLine(resultIndex1);

                Console.WriteLine("Element at index 10 in the array does not exist:");
                Console.WriteLine(resultIndex10 == null);
            }


            static void Sample_First_Lambda_Simple()
            {
                string[] fruits = { "Banana", "Apple", "Orange" };

                var result = fruits.First();

                Console.WriteLine("First element in the array is:");
                Console.WriteLine(result);
            }



            static void Sample_FirstOrDefault_Lambda()
            {
                string[] countries = { "Denmark", "Sweden", "Norway" };
                string[] empty = { };

                var result = countries.FirstOrDefault();

                var resultEmpty = empty.FirstOrDefault();

                Console.WriteLine("First element in the countries array contains:");
                Console.WriteLine(result);

                Console.WriteLine("First element in the empty array does not exist:");
                Console.WriteLine(resultEmpty == null);
            }






        }
    }




