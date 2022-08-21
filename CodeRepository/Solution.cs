using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepository
{
    internal class Solution
    {
        public int FirstFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * FirstFactorial(num - 1);
        }

        public string FirstReverse(string str)
        {
            string reverseStr = "";
            for (int i = str.Length; i > 0; i--)
            {
                reverseStr += str[i-1];
            }
            return reverseStr;
        }

    }
}
