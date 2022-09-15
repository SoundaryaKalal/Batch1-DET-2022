using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class linq
    {
        private static void sampleIntLinst()
        {
            //The  Three parts of linq query: differed execution
            // 1. Data source.
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2. query creation. sql type
            var numQuery = (from num in numbers  //select num from numbers
                           select num).ToList();

            numbers.Add(200);

            //Query execution.

            foreach (int num in numQuery)
            {
                Console.Write("{0}", num);
                //num.Dump();// this is for LINQpad not for VS
            }
            Console.ReadLine();
        }
    }
}
