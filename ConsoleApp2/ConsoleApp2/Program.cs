using System;

namespace ConsoleApp2
{
    public class test1
    {
        public int a;

        public test1()
        {
            a = 10;
        }
        public test1(int a)
        {
            this.a = a;
        }
        public test1(int a, int b)
        {
            this.a = a + b;
        }
        public test1(test1 obj)
        {
            this.a = obj.a;
        }
        ~test1()
        {
            Console.WriteLine("Destructor called");
        }
    };
    public class Program
    {
        static void Main(string[] args)
        {
            test1 testObj1 = new test1();
            test1 testObj2 = new test1(20);
            test1 testObj3 = new test1(testObj1);
            test1 testObj4 = new test1(10, 20);

            Console.WriteLine(testObj1.a);
            Console.WriteLine(testObj2.a);
            Console.WriteLine(testObj3.a);
            Console.WriteLine(testObj4.a);





            //Console.ReadLine();
        }
    }
}
