namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = { 1, 2, 3, 4 };

            int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] twoDArray2 = new int[3][];
            twoDArray2[0] = new int[] { 1, 2, 3 };
            twoDArray2[1] = new int[] { 4, 5, 6 };
            twoDArray2[2] = new int[] { 7, 8, 9 };

            arr2[3] = 0;

            // arr2= new int[10];

            //arr1 = arr2;

            for (int i = 0; i < arr1.Length; i++) { arr1[i] = i + 1; }

            arr1.SetValue(100, 5);
            arr1[5] = 6;

            //arr1.CopyTo(arr2, 0);

            Array.Reverse(arr1);

            Array.Sort(arr2);

            Console.WriteLine($"Max Value in arr1 is {arr1.Max()}");
            Console.WriteLine($"Min Value in arr1 is {arr1.Min()}");
            Console.WriteLine($"Sum of arr1 is {arr1.Sum()}");
            Console.WriteLine($"Average of arr1 is {arr1.Average()}");
            Console.WriteLine($"count of 3 in arr1 is {arr1.Count(n=> n==3)}");

            for (int i = 0; i < arr1.Length; i++) { Console.Write($"{arr1[i]} "); }
            Console.WriteLine();
            foreach (var i in arr1) { Console.Write($"{i} "); }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++) { Console.Write($"{arr2[i]} "); }
            Console.WriteLine();

            Console.WriteLine($" twoDArray1 on index 1 , 1 has value as {twoDArray[1,1]}");

            foreach (var arr in twoDArray2)
            {
                foreach (var i in arr)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < twoDArray2.Length; i++) {
                for (int j = 0; j < twoDArray2[i].Length; j++) {
                    Console.Write(twoDArray2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}