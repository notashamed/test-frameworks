using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SimpleParser
    {
        //Method that sums a string of comma-separated numbers.
        public int ParseAndSum(string numbers)
        {
            try
            {
                if (numbers.Length == 0)
                {
                    return 0;
                }
                else if (!numbers.Contains(","))
                {
                    return int.Parse(numbers);
                }
                else
                {
                    int sum = 0;
                    string[] values = numbers.Split(',');
                    foreach (var value in values)
                    {
                        sum += Convert.ToInt32(value);
                    }

                    return sum;
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid string format.");
            }
            
        }
    }
}
