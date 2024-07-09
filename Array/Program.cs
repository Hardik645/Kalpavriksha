
namespace Array
{
    internal class Program
    {   
        //array have fixed size
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = {1,2,3,4};

            arr2[3] = 0;

            // arr2= new int[10];

            //arr1 = arr2;

            for (int i = 0; i < arr1.Length; i++) { arr1[i] = i + 1; }

            arr1.SetValue(100, 5);
            arr1[5] = 6;

            //arr1.CopyTo(arr2, 0);

            for (int i = 0; i < arr1.Length; i++) { Console.Write($"{arr1[i]} "); }
            Console.WriteLine();
            foreach(var i in arr1) {  Console.Write($"{i} "); }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++) { Console.Write($"{arr2[i]} "); }

            
        }
    }
}
