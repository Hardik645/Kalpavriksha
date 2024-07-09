using System.Collections;

namespace CollectionsAndList
{
    class CustomStack
    {
        private int top;
        private int[] Arr;
        private int size;
        public CustomStack(int size)
        {
            top = -1;
            this.size = size;
            Arr = new int[size];
        }
        public void Push(int value) {
            if(top<size)
                Arr[++top] = value;
            Console.WriteLine(value+" is pushed in stack");
        }
        public void Pop()
        {
            Console.WriteLine(Arr[top--] + "is poped from stack");
        }
        public void isEmpty() {
            Console.WriteLine(top == -1?"stack is Empty":"stack is not Empty"); 
        }
        public void topOfStack()
        {
            Console.WriteLine(Arr[top] + " is top of stack");
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack st = new CustomStack(10);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Pop();
            st.topOfStack();
            st.isEmpty();

            Queue q= new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine("Poped ele from queue is " + q.Dequeue());
            Console.WriteLine("front ele from queue is " + q.Peek());
            
            List<int> ls = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                ls.Add(r.Next(100));
            }
            foreach (int i in ls)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            ls.Sort();
            ls.ForEach(x => Console.Write(x+" "));
            Console.WriteLine();

            List<List<int>> twoDLs= new List<List<int>>();
            twoDLs.Add(new List<int>() { 1, 2, 3 });
            twoDLs.Add(new List<int>() { 4, 5, 6 });
            foreach(List<int> list in twoDLs)
            {
                foreach(int i in list)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

            Dictionary<char,int> dic = new Dictionary<char,int>();
            for (int i = 0; i < 26; i++)
            {
                dic.Add( (char)((int)'a'+i), (int)'a' + i);
            }

            dic.Remove( 'a' );

            foreach(var i in dic)
            {
                Console.Write("("+i.Key+","+i.Value+") ");
            }
            Console.WriteLine();

            Console.WriteLine(dic['g']);
        }
    }
}
