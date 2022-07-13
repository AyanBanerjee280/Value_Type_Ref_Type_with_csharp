using System;
namespace Value_Ref_Type
{//Objects of Value type are strored in Stack Memory
//Objects of reference type are stored in Heap memory
    struct Employee
    {//Struct is a value type
        public int salary;
        public int age;
    }
    class Reference
    {//class is a reference type
        static void Main(string[] args)
        {
            Employee obj = new Employee();//These objects will be stored in stack memory(value type)
            obj.salary = 150000;
            obj.age = 35;
            Employee obj1 = obj;
            Employee obj2 = obj;
            obj.age = 38;

            Console.WriteLine("Revised age: " + obj.age);//Revised age
            Console.WriteLine("Previous age: " + obj1.age);//Age is not updated
            Console.WriteLine("Previous age: " + obj2.age);//Age is not updated
            Console.ReadLine();
        }
    }
}
