using System;
using System.Collections.Generic;
using System.Text;

namespace REF_AND_OUT_KEYWORDS
{
    class ReferenceType
    {
        public void PassByreference(ref int a)
        {
            a += 10;
            Console.WriteLine("Value of a is : "+a);
        }
        static void Main(string[] args)
        {
            int value = 10;
            ReferenceType rt = new ReferenceType();
            rt.PassByreference(ref value);
            Console.WriteLine("Assigned value : "+value);
        }
    }
}
