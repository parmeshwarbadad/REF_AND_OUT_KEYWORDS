using System;

namespace REF_AND_OUT_KEYWORDS
{
    class ValueType
    {
        public void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Value of a is : "+a);
        }
        static void Main(string[] args)
        {
            int value = 10;
            ValueType vt = new ValueType();
            vt.PassByValue(value);
            Console.WriteLine("Original value : "+value); 

        }
    }
}
