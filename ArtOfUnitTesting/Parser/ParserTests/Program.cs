using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTests
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
                SimpleParserTests.TestReturnsNumberWhenStringContainsOneNumber();
                SimpleParserTests.TestReturnsSumWhenStringContainsMoreThanOneNumber();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
