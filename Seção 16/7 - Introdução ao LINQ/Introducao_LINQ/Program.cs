using System;
using System.Collections.Generic;
using System.Linq;

namespace Introducao_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query
                /*var*/
            IEnumerable<int> result = numbers
                            .Where(x => x % 2 == 0)
                            .Select(x => x * 10);

            // Execute Query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
