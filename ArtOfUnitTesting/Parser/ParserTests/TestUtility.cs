using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTests
{
    public class TestUtility
    {
        public static void ShowProblem(string testName, string message)
        {
            string msg = string.Format(@"
            ---{0}---
                    {1}
            --------------------
            ", testName, message);

            Console.WriteLine(msg);
        }
    }
}
