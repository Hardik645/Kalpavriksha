using System.Globalization;
namespace Practice2
{
    class abc
    {
        public int a=10;
        public int b=20;
    };
    internal class Program : abc
    {
        static void Main(string[] args)
        {
            var number = 2;
            abc newObj = new abc();
            Console.WriteLine($@"my number is ""{number}""  ");
            Console.WriteLine(newObj.a);

        }
    }
}
