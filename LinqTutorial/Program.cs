using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.MethodSyntax;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD SYNTAX

            //Any.Run();
            //All.Run();
            //Count.Run();
            //Contains.Run();
            //+OrderBy.Run();
            //MinMax.Run();
            //Average.Run();
            //Sum.Run();
            //ElementAt.Run();
            //FirstLast.Run();
            //SingleElement.Run();
            //Where.Run();
            //Take.Run();
            //Skip.Run();
            //OfType.Run();
            //Distinct.Run();
            //PrependAppend.Run();
            //ConcatUnion.Run();
            //TypeSwitching.Run();           
            //Select.Run();
            //SelectMany.Run();
            //GeneratingNewCollection.Run();
            //GroupBy.Run();
            //IntersectExcept.Run();
            //Joins.Run();
            //Aggregate.Run();
            //Zip.Run();

            //QUERY SYNTAX

            //OrderBy.QuerySyntax.Run();
            //Where.QuerySyntax.Run();
            //Select.QuerySyntax.Run();
            //SelectMany.QuerySyntax.Run();
            //GroupBy.QuerySyntax.Run();
            //Joins.QuerySyntax.Run();

            var numbers = new[] {5, 9, 2, 12};
            bool isAnyLarger = numbers.Any(x => x > 10);
            Console.WriteLine(isAnyLarger);
            Console.ReadKey();
        }


         
        public static bool IsAnyWordUpperCase(IEnumerable<string> word)
        {
            bool areAllUpperCase = true;
            foreach (string word2 in word)
            {
                foreach (var letter in word2)
                {
                    if (char.IsLower(letter))
                    {
                        areAllUpperCase = false;
                    }

                    if (areAllUpperCase)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
}
