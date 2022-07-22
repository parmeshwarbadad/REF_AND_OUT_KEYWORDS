using System;
using System.Collections.Generic;
using System.Text;

namespace REF_AND_OUT_KEYWORDS
{
    class ParamsKeyord
    {
        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum +=i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int a=ParamsKeyord.Add(10, 20, 30, 40);

            Console.WriteLine(a);
        }
    }
}
