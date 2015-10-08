//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerable_Extensions
{
    class IEnumerableExtensionMain
    {
        static void Main(string[] args)
        {
            IEnumerable<int> test = new List<int> {1, 2, 3, 4, 5 };
            Console.WriteLine(test.SumOfCollection());
            IEnumerable<double> test1 = new[] {1.1, 2.2, 3.3, 4.4, 5.5};

            Console.WriteLine(test1.SumOfCollection());
            Console.WriteLine(test1.ProductOfCollection());
            Console.WriteLine(test1.MinValueOfCollection());
            Console.WriteLine(test1.MaxValueOfCollection());
            Console.WriteLine(test1.CollectionAverage());

            Console.WriteLine(IEnumerableExt.CollectionAverage(test));
            Console.WriteLine(IEnumerableExt.ProductOfCollection(test1));
        }
    }
}
