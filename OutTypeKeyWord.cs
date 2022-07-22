using System;
using System.Collections.Generic;
using System.Text;

namespace REF_AND_OUT_KEYWORDS
{
    class OutTypeKeyWord
    {
        public static void OutKeyWord(out int a)
        {
            a = 10;
            Console.WriteLine("Value of function variable : "+a);
        }
        static void Main(string[] args)
        {
            int value;
            OutKeyWord(out value);
            Console.WriteLine(value);

        }
    }
}
