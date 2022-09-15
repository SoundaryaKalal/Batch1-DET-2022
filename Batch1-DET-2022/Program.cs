//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class program
//    {
//        public static void String_Groupby()

//            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "banana", "abacus", "apple", "chees" };

//        //var wordGroups = from w in words
//        //                 group w by w[0] into g
//        //                 select new { FirstLetter = g.Key, Words = g };

//        var wordGroups = words.GroupBy(x => x[0]).Select
//            (y=> new { FirstLetter = y.Key,Words = y });


//        foreach ( var item in wordGroups )
//            {

//            Console.WriteLine("Words that start with the" +
//                     " letter '{0}':",item.FirstLetter);

//            foreach(var w in item.words)
//            {
             // Console.WriteLine(w);
    //}
//}
