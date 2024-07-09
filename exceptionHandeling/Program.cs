using System.Threading.Channels;

namespace exceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // int a= int.Parse(Console.ReadLine());

                // int[] arr = new int[10];
                // Console.WriteLine(arr[15]);

                //int a = 0;
                //Console.WriteLine(10/a);

                int a;
                a = int.Parse(Console.ReadLine());
                if (a == 0) {
                    throw new Exception("Divide with zero is not possible");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Err Solved");
            }

        }
    }
}
