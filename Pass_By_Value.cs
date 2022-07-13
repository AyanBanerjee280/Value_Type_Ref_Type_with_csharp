using System;
namespace Value_Ref_Type
{//pass by value
    class Program
    {//Class is a reference type
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Value is {0} ", a);
        }
        public static void Main(string[] args)
        {
            int value = 5;
            Program.PassByValue(10);//Result will be 20
            PassByValue(value);//Results will be 15
            Console.WriteLine(value);
            Console.Read();
        }
    }
}
