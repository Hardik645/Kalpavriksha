namespace abstrationAndInterface
{
    // there is no instance need for this class
    // it can have non-abstract and abstract funtions also
    // use of override keyword for overriding funtion
    // can have fields, constructors
    // Abstract class members can have access modifiers
    //  A class can inherit only one abstract class 
    // Abstract classes can have constructors, which are called when an instance of a derived class is created.

    public abstract class A
    {
        public int data1 = 1;
        public A() {
            data1 = 10;
        }
        public abstract void printMessage();
        public void printNumber(int a)
        {
            Console.WriteLine(a);
        }

    };
    class B : A
    {
        public int data2 = 1;
        public B(){
            data2=10;
            }
        public override void printMessage()
        {
            Console.WriteLine("Hello");
        }
/*        public void printNumber(int a)
        {
            Console.WriteLine(a+10);
        }
*/
    }

    // only contain method declarations
    // cannot contain any fields, constructors, destructors, or static members
    // can implement multiple interfaces
    // All members of an interface are implicitly public and cannot have access modifiers


    interface I1
    {
        void sum(int a,int b);
    };
    interface I2 {
        void sub(int a, int b);
    }
    class C : I1 ,I2 {
        public void sum(int a, int b) { Console.WriteLine(a + b); }
        public void sub(int a, int b) {
            Console.WriteLine(a-b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.WriteLine(obj.data1);
            Console.WriteLine(obj.data2);
            obj.printMessage();
            obj.printNumber(1);
            Console.WriteLine();

            C obj2 = new C();
            obj2.sum(1, 2);
            obj2.sub(1,2);
        }
    }
}
