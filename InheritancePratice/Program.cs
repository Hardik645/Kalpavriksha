namespace InheritancePratice
{
    class A {
        public int data1 = 0;
    }
    class C {
        public int data1 = 1;
    }

    class B : A {
        private int data2 = 0;
        public void changeA() { 
            data1=1;
        }
        public int showDataB()
        {
            return data2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.WriteLine(obj.data1);
            obj.changeA();
            Console.WriteLine(obj.data1);
            Console.WriteLine( obj.showDataB());
            Console.WriteLine("Hello, World!");
        }
    }
}
