using System;
using System.Collections.Generic;
using System.Text;

namespace REF_AND_OUT_KEYWORDS
{
    class VariablesInCSharp
    {
        public const double PI = 3.14;
        public const string  companyname="Think Quotient";
        public readonly int a=7;


        VariablesInCSharp()
        {
            a = 5;
            Console.WriteLine(a);
        }
           public static void Main(string[] args)
           {
            VariablesInCSharp v = new VariablesInCSharp();
            Console.WriteLine(PI);
            Console.WriteLine(companyname);
           }
    }
}
