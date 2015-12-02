using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;
using System.Reflection;

namespace ParserTests
{
    class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtility.ShowProblem(testName, "FAILED: Parse and sum should have returned 0 on an empty string");
                }
                else
                {
                    TestUtility.ShowProblem(testName, "PASSED");
                }
            }
            catch (Exception e)
            {
                TestUtility.ShowProblem(testName, string.Format("FAILED: {0}", e.ToString()));
            }
        }

        public static void TestReturnsNumberWhenStringContainsOneNumber()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                string numbers = "324";
                int result = p.ParseAndSum(numbers);
                if (result == Convert.ToInt32(numbers))
                {
                    TestUtility.ShowProblem(testName, "PASSED");

                }
                else
                {
                    TestUtility.ShowProblem(testName, "FAILED: Parse and sum should have returned a single number.");
                }
            }
            catch (Exception e)
            {
                TestUtility.ShowProblem(testName, string.Format("FAILED: {0}", e.ToString()));
            }
        }

        public static void TestReturnsSumWhenStringContainsMoreThanOneNumber()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                string numbers = "5,10,15,20,25,30,40";
                int result = p.ParseAndSum(numbers);
                if(result == 145)
                {
                    TestUtility.ShowProblem(testName, "PASSED");
                }
                else
                {
                    TestUtility.ShowProblem(testName, "FAILED: Parse and sum should have returned the correct summation");
                }
            }
            catch (Exception e)
            {
                TestUtility.ShowProblem(testName, string.Format("FAILED: {0}", e.ToString()));
            }
        }
    }
}
