using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TestStack
    {

        public static void Print<T> (T[] a)  where T : IComparable<T>
        {
            foreach (T v in a)
                Console.WriteLine(v);
        }
    
        public static void Main()
        {
            int[] nums = new int[] { 10, 20, 38, 03 };
            Print(nums);

            /*
            Time[] times = new Time[] { new Time { Hours = 10, Mins = 20, Secs = 30 } };
            Print(times);
            */


            #region old stack example
            /*
            IntStack s = new IntStack();
            s.Push(10);
            s.Push(20);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            StringStack ss = new StringStack();
            ss.Push("First");
            ss.Push("Second");
            Console.WriteLine(ss.Pop());
            */
#endregion


            var names = new Stack<string>();
            names.Push("Abc");
            names.Push("Xyz");
            names.Push("Pqr");
            Console.WriteLine(names.Pop());


            var prices = new Stack<double>();
            prices.Push(29.29);
            prices.Push(19.19);
            Console.WriteLine(prices.Pop());

            var stack = new CommonStack();
            stack.Push("String1");
            stack.Push("String2");
            stack.Push(10);
            stack.Push(DateTime.Now);
            var s = stack.Pop();

            string st = s as string;
        }
    }


    // Generic Stack 
    class Stack<T>
    {
        private T[] data = new T[10];
        private int top = 0;

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = default(T);  // Take default value of type T

            top = 0; 

        } 

        public void Push(T value)
        {
            data[top] = value;
            top++;
        }
        public T Pop()
        {
            top--;
            return data[top];
        }
    }

    class CommonStack
    {
        private  object [] data = new  object[10];
        private int top = 0;

        public void Push(object value)
        {
            data[top] = value;
            top++;
        }
        public object Pop()
        {
            top--;
            return data[top];
        }
    }

    class IntStack
    {
        private int[] data = new int[10];
        private int top = 0;

        public void Push(int n)
        {
            data[top] = n;
            top++;
        }

        public int Pop()
        {
            top--;
            return data[top];
        }

    }

    class StringStack
    {
        private string [] data = new string[10];
        private int top = 0;

        public void Push(string value)
        {
            data[top] = value;
            top++;
        }

        public string Pop()
        {
            top--;
            return data[top];
        }

    }
}
